open System
open System.IO
open Microsoft.FSharp.Text.Lexing

open FSExternHelper.HeaderSyntax
open FSExternHelper.Lexer
open FSExternHelper.Parser

let llvmCPrefix = "LLVM"

let toFSharpFunName (cFunName : string) =
    if cFunName.StartsWith llvmCPrefix then
        let baseName = cFunName.Substring llvmCPrefix.Length
        let fstChar = (baseName.Substring (0, 1)).ToLower ()
        fstChar + baseName.Substring 1
    else
        failwith ("unexpected function name: " + cFunName)

let toFSharpDataName (cDataName : string) =
    if cDataName.StartsWith llvmCPrefix then
        cDataName.Substring llvmCPrefix.Length
    else
        failwith ("unexpected data name: " + cDataName)

// indented fprintf
let inline ifprintf depth out fmt =
    let printIndented s =
        for i = 0 to depth - 1 do
            fprintf out "    "
        fprintf out "%s" s
    Printf.ksprintf printIndented fmt

// indented fprintfn
let inline ifprintfn depth out fmt =
    let printIndented s =
        for i = 0 to depth - 1 do
            fprintf out "    "
        fprintfn out "%s" s
    Printf.ksprintf printIndented fmt

let getStructDefs (defs : CDef list) =
    let rec go (structs : Set<string>)= function
    | [] -> structs
    | defHead :: defs ->
        match defHead with
        | CTypeAlias ({CFullType.baseType = StructType _; CFullType.pointerDepth = 1}, name) ->
            go (structs.Add name) defs
        | CTypeAlias ({CFullType.baseType = StructType _}, name) ->
            failwith "only know how to deal with single-pointer structs"
        | _ ->
            go structs defs

    go Set.empty defs

let getEnumDefs (defs : CDef list) =
    let rec go (enums : Set<string>) = function
    | [] -> enums
    | defHead :: defs ->
        match defHead with
        | CEnumDef (enumName, _) ->
            go (enums.Add enumName) defs
        | _ ->
            go enums defs

    go Set.empty defs

let toFSharpSource
        (moduleName : string)
        (out : System.IO.TextWriter)
        (deps : (string * CDef list) list)
        (defs : CDef list) =

    // using a black-list to prevent auto-generation of certain function bindings
    let blacklistedFuncs =
        Set.ofList [
            "LLVMDisposeMessage"
            "LLVMCreateSimpleMCJITMemoryManager"
            "LLVMDisposeMCJITMemoryManager"
            "LLVMInstallFatalErrorHandler"
            "LLVMResetFatalErrorHandler"
        ]

    let nsLen = moduleName.LastIndexOf '.'
    let simpleModuleName = moduleName.Substring (nsLen + 1)
    let nsName = moduleName.Substring (0, nsLen)

    let friendlyFuncCount = ref 0
    let nativeFuncCount = ref 0

    let depDefs = List.map snd deps
    let allDefs = defs @ List.concat depDefs
    
    let structRefs = getStructDefs allDefs
    let enums = getEnumDefs allDefs
    let rec go (defs : CDef list) =
        match defs with
        | [] -> ()
        | def :: defTail ->
            match def with
            | CFuncDef (retType, fName, fArgs) ->
                nativeFuncCount := !nativeFuncCount + 1
                let typeToStr (isParam : bool) (cType : CFullType) =
                    let pointerAdjust ptrDepth typeStr =
                        match ptrDepth with
                        | 0 -> typeStr
                        | 1 -> typeStr + "*"
                        | _ -> failwith (sprintf "don't know how to deal with %i pointer depth" ptrDepth)
                    let defPtrAdj = pointerAdjust cType.pointerDepth
                    
                    match cType.baseType with
                    | GeneralType "LLVMBool" -> defPtrAdj "bool"
                    | GeneralType typeName ->
                        if enums.Contains typeName then
                            defPtrAdj (sprintf "int (* %s *)" (cType.ToString ()))
                        elif typeName.EndsWith "Ref" then
                            sprintf "void* (* %s *)" (cType.ToString ()) // TODO
                        else
                            failwith (sprintf "don't know how to deal with: %s" typeName)
                    | StructType typeName ->
                        if cType.pointerDepth = 1 then
                            sprintf "void* (* struct %s* *)" (cType.ToString ())
                        else
                            failwith "can't deal with naked struct type"
                    | IntType -> defPtrAdj "int"
                    | VoidType -> defPtrAdj "void"
                    | CharType ->
                        if cType.pointerDepth = 0 then
                            "char"
                        elif cType.pointerDepth = 1 then
                            if isParam then
                                "string"
                            else
                                "void*"
                        elif cType.pointerDepth = 2 then
                            "void*"
                        else
                            failwith (sprintf "don't know how to deal with %i pointer depth" cType.pointerDepth)
                    | UnsignedIntType -> defPtrAdj "uint32"
                    | UnsignedLongLongType -> defPtrAdj "uint64"
                    | LongLongType -> defPtrAdj "int64"
                    | UnsignedByteType -> defPtrAdj "uint8"
                    | SizeTType -> defPtrAdj "nativeint (* size_t *)"
                    | DoubleType -> defPtrAdj "double"

                if blacklistedFuncs.Contains fName then
                    ifprintfn 2 out "// %s is blacklisted by the binding generator" fName
                else
                    // the native function def
                    ifprintfn 2 out "[<DllImport("
                    ifprintfn 3 out "llvmAssemblyName,"
                    ifprintfn 3 out "EntryPoint=\"%s\"," fName
                    ifprintfn 3 out "CallingConvention=CallingConvention.Cdecl,"
                    ifprintfn 3 out "CharSet=CharSet.Ansi)>]"
                    ifprintf 2 out "extern %s %sNative(" (typeToStr false retType) (toFSharpFunName fName)
                    let fArgs =
                        Array.ofList fArgs
                        |> Array.mapi (fun i a -> (fst a, match snd a with Some x -> x | None -> sprintf "arg%i" i))
                    if fArgs.Length >= 1 then
                        out.WriteLine ()
                        for i = 0 to fArgs.Length - 2 do
                            let cType, name = fArgs.[i]
                            ifprintfn 3 out "%s %s," (typeToStr true cType) name
                        let cType, name = fArgs.[fArgs.Length - 1]
                        ifprintfn 3 out "%s %s)" (typeToStr true cType) name
                    else
                        out.WriteLine ')'

                    // the more F# friendly function def
                    let isFunFriendly =
                        let isTypeFriendly t =
                            match t.baseType with
                            | GeneralType _ | StructType _ | IntType | VoidType
                            | UnsignedIntType | UnsignedLongLongType | LongLongType
                            | UnsignedByteType | DoubleType | SizeTType ->
                                t.pointerDepth = 0
                            | CharType ->
                                t.pointerDepth <= 1
                        let rec go = function
                            | x :: xt -> isTypeFriendly x && go xt
                            | [] -> true
                        isTypeFriendly retType && go (List.ofArray (Array.map fst fArgs))
                    if isFunFriendly then
                        friendlyFuncCount := !friendlyFuncCount + 1
                        if fArgs.Length >= 1 then
                            ifprintf 2 out "let %s " (toFSharpFunName fName)
                            for i = 0 to fArgs.Length - 2 do
                                fprintf out "_%s " (snd fArgs.[i])
                            fprintfn out "_%s =" (snd fArgs.[fArgs.Length - 1])
                        else
                            ifprintfn 2 out "let %s () =" (toFSharpFunName fName)
                        let toNativeParam (arg : CFullType * string) =
                            let cType, name = arg
                            let name = "_" + name
                            if cType.pointerDepth = 0 then
                                match cType.baseType with
                                | GeneralType "LLVMBool" -> name
                                | GeneralType typeName ->
                                    if enums.Contains typeName then
                                        sprintf "(int (%s : %s))" name (toFSharpDataName typeName)
                                    elif typeName.EndsWith "Ref" then
                                        sprintf "(%s : %s).Ptr" name (toFSharpDataName typeName)
                                    else
                                        failwith (sprintf "don't know how to deal with: %s" typeName)
                                | _ -> name
                            else
                                name
                        let nativeFunCall () =
                            if fArgs.Length >= 1 then
                                fprintf out "%sNative (" (toFSharpFunName fName)
                                for i = 0 to fArgs.Length - 2 do
                                    fprintf out "%s, " (toNativeParam fArgs.[i])
                                fprintf out "%s)" (toNativeParam fArgs.[fArgs.Length - 1])
                            else
                                fprintf out "%sNative ()" (toFSharpFunName fName)
                        let retTypeIsString =
                            match retType with
                            | {pointerDepth = 1; baseType = CharType} -> true
                            | _ -> false
                        if retTypeIsString then
                            ifprintf 3 out "Marshal.PtrToStringAuto ("
                            nativeFunCall ()
                            fprintf out ")"
                        elif retType.pointerDepth = 0 then
                            match retType.baseType with
                            | GeneralType "LLVMBool" ->
                                ifprintf 3 out ""
                                nativeFunCall ()
                            | GeneralType typeName ->
                                if enums.Contains typeName then
                                    ifprintf 3 out "enum<%s> (" (toFSharpDataName typeName)
                                    nativeFunCall ()
                                    fprintf out ")"
                                elif typeName.EndsWith "Ref" then
                                    ifprintf 3 out "new %s (" (toFSharpDataName typeName)
                                    nativeFunCall ()
                                    fprintf out ")"
                                else
                                    failwith (sprintf "don't know how to deal with: %s" typeName)
                            | _ ->
                                ifprintf 3 out ""
                                nativeFunCall ()
                        else
                            ifprintf 3 out ""
                            nativeFunCall ()
                        out.WriteLine ()
                    else
                        ifprintfn 2 out "// I don't know how to generate an \"F# friendly\" version of %s" fName

                out.WriteLine ()
                
                go defTail
            
            | CEnumDef (enumName, enumVals) ->
                ifprintfn 2 out "type %s =" (toFSharpDataName enumName)
                let mutable nextEnumVal = 0
                for eValName, maybeEnumVal in enumVals do
                    match maybeEnumVal with
                    | Some enumVal -> nextEnumVal <- enumVal
                    | None -> ()
                    
                    ifprintfn 3 out "| %s = %i" (toFSharpDataName eValName) nextEnumVal
                    nextEnumVal <- nextEnumVal + 1
                out.WriteLine ()
                
                go defTail

            | CTypeAlias ({CFullType.baseType = StructType _; CFullType.pointerDepth = 1}, name) ->
                let dataName = toFSharpDataName name
                ifprintfn 2 out "type %s (thePtr : nativeint) =" dataName
                ifprintfn 3 out "member x.Ptr = (x :> ILLVMRef).Ptr"
                ifprintfn 3 out "interface ILLVMRef with member x.Ptr = thePtr"
                out.WriteLine ()
                
                go defTail

            | _ -> go defTail

    fprintfn out "// This file should not be edited. It is automatically generated from a C header file"
    fprintfn out "namespace %s" nsName

    out.WriteLine ()

    ifprintfn 1 out "open LLVM.FFIUtil"
    ifprintfn 1 out "open System.Runtime.InteropServices"
    List.iter (ifprintfn 1 out "open %s" << fst) deps

    out.WriteLine ()

    ifprintfn 1 out "module %s =" simpleModuleName

    out.WriteLine ()
    
    go defs

    (!friendlyFuncCount, !nativeFuncCount)


[<EntryPoint>]
let main (args : string array) =
    match args with
    | [|llvmHome; outSrcFile|] ->
        let cPrefix = Path.Combine [|llvmHome; "include"; "llvm-c"|]
        let modulePrefix = "LLVM.Generated."
        let parseMod (m : string) =
            let hFile = Path.Combine (cPrefix, Path.Combine (m.Split '.') + ".h")
            let reader = new StreamReader(hFile)
            let lexbuf = LexBuffer<_>.FromTextReader reader
            start tokenize lexbuf
        let writer = new StreamWriter(outSrcFile)
        let rec processModules friendlyCount nativeCount (mods : (string * string list) list) =
            match mods with
            | [] -> (friendlyCount, nativeCount)
            | ((m : string), deps) :: mTail ->
                let modName m = "LLVM.Generated." + m
                let depDefs = List.map (fun m -> (modName m, parseMod m)) deps
                let friendlyFuncCount, nativeFuncCount =
                    toFSharpSource (modName m) writer depDefs (parseMod m)
                printfn
                    "inferred friendly types for %i/%i functions in %s"
                    friendlyFuncCount
                    nativeFuncCount
                    m
                
                processModules
                    (friendlyCount + friendlyFuncCount)
                    (nativeCount + nativeFuncCount)
                    mTail
        
        let modulesToProcess = [
            ("Support",             [])
            ("Core",                ["Support"])
            ("BitReader",           ["Core"])
            ("BitWriter",           ["Core"])
            ("Target",              ["Core"])
            ("TargetMachine",       ["Core"; "Target"])
            ("ExecutionEngine",     ["Core"; "Target"; "TargetMachine"])
            ("Analysis",            ["Core"])
            ("Transforms.Scalar",   ["Core"])
            ("Transforms.IPO",      ["Core"])]
        let friendlyFuncCount, nativeFuncCount =
            processModules 0 0 modulesToProcess
        writer.Close ()
        printfn "inferred friendly types for %i/%i functions in total" friendlyFuncCount nativeFuncCount
    
    | _ ->
        failwith "usage: bindinggen llvmHome outSrcFile"
    
    // Exit code
    0

