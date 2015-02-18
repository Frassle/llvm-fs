open System
open System.IO
open Microsoft.FSharp.Text.Lexing

open FSExternHelper.HeaderSyntax
open FSExternHelper.Lexer
open FSExternHelper.Parser

let llvmCPrefix = "LLVM"
let clangCPrefix = "clang_"

let toFSharpFunName (cFunName : string) =
    if cFunName.StartsWith llvmCPrefix then
        let baseName = cFunName.Substring llvmCPrefix.Length
        let fstChar = (baseName.Substring (0, 1)).ToLower ()
        fstChar + baseName.Substring 1
    elif cFunName.StartsWith clangCPrefix then
        let baseName = cFunName.Substring clangCPrefix.Length
        let fstChar = (baseName.Substring (0, 1)).ToLower ()
        fstChar + baseName.Substring 1
    else
        failwith ("unexpected function name: " + cFunName)

let toFSharpDataName (cDataName : string) =
    if cDataName.StartsWith llvmCPrefix then
        cDataName.Substring llvmCPrefix.Length
    else
        let fstChar = (cDataName.Substring (0, 1)).ToUpper ()
        fstChar + cDataName.Substring 1

let toFSharpVariableName (cVariableName : string) =
    let reservedWords = set ["string"; "begin"; "end"; "module"; "base"; "const"]
    if reservedWords.Contains(cVariableName) then
        "_" + cVariableName
    else
        cVariableName

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

let getFuncTypeDefs (defs : CDef list) =
    let rec go (funcs : Set<string>)= function
    | [] -> funcs
    | defHead :: defs ->
        match defHead with
        | CFuncPtrDef (_, name, _) ->
            go (funcs.Add name) defs
        | _ ->
            go funcs defs

    go Set.empty defs

let getAliasDefs (defs : CDef list) =
    let rec go (aliases : Set<string>)= function
    | [] -> aliases
    | defHead :: defs ->
        match defHead with
        | CTypeAlias ({CFullType.baseType = StructType _; CFullType.pointerDepth = 1}, name) ->
            go (aliases.Add name) defs
        | CTypeAlias ({CFullType.baseType = VoidType; CFullType.pointerDepth = 1}, name) ->
            go (aliases.Add name) defs
        | _ ->
            go aliases defs

    go Set.empty defs

let getStructDefs (defs : CDef list) =
    let rec go (structs : Set<string>) = function
    | [] -> structs
    | defHead :: defs ->
        match defHead with
        | CStructDef (structName, _) ->
            go (structs.Add structName) defs
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
        (modulePrefix : string)
        (moduleName : string)
        (out : System.IO.TextWriter)
        (deps : (string * CDef list) list)
        (defs : CDef list) =

    // using a black-list to prevent auto-generation of certain function bindings
    let blacklistedFuncs =
        Set.ofList [
            "LLVMCreateMessage"
            "LLVMDisposeMessage"
        ]

    let nsLen = moduleName.LastIndexOf '.'
    let simpleModuleName = moduleName.Substring (nsLen + 1)
    let nsName = moduleName.Substring (0, nsLen)

    let friendlyFuncCount = ref 0
    let nativeFuncCount = ref 0

    let depDefs = List.map snd deps
    let allDefs = defs @ List.concat depDefs
    
    let funcTypes = getFuncTypeDefs allDefs
    let aliasTypes = getAliasDefs allDefs
    let structTypes = getStructDefs allDefs
    let enums = getEnumDefs allDefs

    let rec typeToStr (isNative : bool) (isParam : bool) (cType : CFullType) =
        let rec pointerAdjust ptrDepth typeStr =
            match ptrDepth with
            | 0 -> typeStr
            | i ->
                let subType = pointerAdjust (ptrDepth - 1) typeStr
                if isNative then
                    subType + "*"
                else
                    "nativeptr<" + subType + ">"
        let defPtrAdj = pointerAdjust cType.pointerDepth

        match cType.baseType with
        | GeneralType "LLVMBool" -> defPtrAdj "bool"
        | GeneralType typeName ->
            if enums.Contains typeName then
                if isNative then
                    defPtrAdj (sprintf "int (* %s *)" (cType.ToString ()))
                else
                    defPtrAdj (sprintf "%s (* %s *)" (toFSharpDataName typeName) (cType.ToString ()))
            elif funcTypes.Contains typeName then
                sprintf "%s (* function pointer *)" (toFSharpDataName typeName)
            elif aliasTypes.Contains typeName then
                if isNative then
                    sprintf "void* (* %s *)" (cType.ToString ()) // TODO
                else
                    sprintf "nativeint (* %s *)" (cType.ToString ())
            elif structTypes.Contains typeName then
                sprintf "%s" (toFSharpDataName typeName)
            else
                failwith (sprintf "don't know how to deal with: %s" typeName)
        | FunctionType (name, _, _) ->
            sprintf "%s (* %s *)" (toFSharpDataName name) (cType.ToString())
        | StructType typeName ->
            if cType.pointerDepth = 1 then
                if isNative then
                    sprintf "%s*" (toFSharpDataName typeName)
                else
                    sprintf "nativeptr<%s>" (toFSharpDataName typeName)
            else
                failwith "can't deal with naked struct type"
        | IntType -> defPtrAdj "int"
        | VoidType ->
            if isNative then
                defPtrAdj "void"
            elif not isParam && cType.pointerDepth = 0 then
                "Unit" (* not a parameter, so a return value and pointer depth = 0 *)
            else
                sprintf "nativeint (* %s *)" (defPtrAdj "void")
        | CharType ->
            if cType.pointerDepth = 0 then
                "byte"
            elif cType.pointerDepth = 1 then
                if isParam then
                    "string"
                else
                    sprintf "%s (* %s *)" (if isNative then "void*" else "nativeint") (cType.ToString())
            elif cType.pointerDepth = 2 then
                sprintf "%s (* %s *)" (if isNative then "void*" else "nativeint") (cType.ToString())
            else
                failwith (sprintf "don't know how to deal with %i pointer depth" cType.pointerDepth)
        | UnsignedIntType -> defPtrAdj "uint32"
        | UnsignedLongLongType -> defPtrAdj "uint64"
        | LongLongType -> defPtrAdj "int64"
        | UnsignedByteType -> defPtrAdj "uint8"
        | SizeTType -> defPtrAdj "nativeint (* size_t *)"
        | TimeTType -> defPtrAdj "uint64 (* time_t *)"
        | UIntPtrTType -> defPtrAdj "unativeint (* uintptr_t *)"
        | DoubleType -> defPtrAdj "double"

    let rec go (defs : CDef list) =
        match defs with
        | [] -> ()
        | def :: defTail ->
            match def with
            | CFuncDef (retType, fName, fArgs) ->
                nativeFuncCount := !nativeFuncCount + 1

                if blacklistedFuncs.Contains fName then
                    ifprintfn 2 out "// %s is blacklisted by the binding generator" fName
                else
                    for (arg, _) in fArgs do
                        match arg.baseType with
                        | FunctionType (name, retTy, args) ->
                            // An unnamed function type is being passed in, generate a type for it
                            let dTy = String.concat "" [
                                        (sprintf "type %s = delegate of " (toFSharpDataName name))
                                        (String.concat " * " (args |> Seq.map (fun (arg, _) -> typeToStr false true arg)))
                                        (sprintf " -> %s" (typeToStr false false retTy))]

                            ifprintfn 2 out "%s" dTy
                            out.WriteLine()
                        | _ -> ()

                    // the native function def
                    ifprintfn 2 out "[<DllImport("
                    ifprintfn 3 out "%sAssemblyName," (modulePrefix.ToLower())
                    ifprintfn 3 out "EntryPoint=\"%s\"," fName
                    ifprintfn 3 out "CallingConvention=CallingConvention.Cdecl,"
                    ifprintfn 3 out "CharSet=CharSet.Ansi)>]"
                    ifprintf 2 out "extern %s %sNative(" (typeToStr true false retType) (toFSharpFunName fName)
                    let fArgs =
                        Array.ofList fArgs
                        |> Array.mapi (fun i a -> (fst a, match snd a with Some x -> x | None -> sprintf "arg%i" i))
                    if fArgs.Length >= 1 then
                        out.WriteLine ()
                        for i = 0 to fArgs.Length - 2 do
                            let cType, name = fArgs.[i]
                            ifprintfn 3 out "%s %s," (typeToStr true true cType) (toFSharpVariableName name)
                        let cType, name = fArgs.[fArgs.Length - 1]
                        ifprintfn 3 out "%s %s)" (typeToStr true true cType) (toFSharpVariableName name)
                    else
                        out.WriteLine ')'

                    // the more F# friendly function def
                    let isFunFriendly =
                        let isTypeFriendly t =
                            match t.baseType with
                            | GeneralType _ | StructType _ | IntType
                            | UnsignedIntType | UnsignedLongLongType | LongLongType
                            | UnsignedByteType | DoubleType | SizeTType | UIntPtrTType 
                            | TimeTType | FunctionType _ ->
                                t.pointerDepth = 0
                            | CharType ->
                                t.pointerDepth <= 1
                            | VoidType -> true
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
                                    elif funcTypes.Contains typeName then
                                        sprintf "%s" name
                                    elif aliasTypes.Contains typeName then
                                        sprintf "(%s : %s).Ptr" name (toFSharpDataName typeName)
                                    elif structTypes.Contains typeName then
                                        sprintf "(%s : %s)" name (toFSharpDataName typeName)
                                    else
                                        failwith (sprintf "don't know how to deal with: %s" typeName)
                                | _ -> name
                            else
                                match cType.baseType with
                                | VoidType -> sprintf "(%s : nativeint)" name
                                | _ -> name
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
                                elif aliasTypes.Contains typeName then
                                    ifprintf 3 out "new %s (" (toFSharpDataName typeName)
                                    nativeFunCall ()
                                    fprintf out ")"
                                elif structTypes.Contains typeName then
                                    ifprintf 3 out ""
                                    nativeFunCall ()
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

            | CFuncPtrDef (retTy, name, args) ->
                let dTy = String.concat "" [
                            (sprintf "type %s = delegate of " (toFSharpDataName name))
                            (String.concat " * " (args |> Seq.map (fun (arg, _) -> typeToStr false true arg)))
                            (sprintf " -> %s" (typeToStr false false retTy))]

                ifprintfn 2 out "%s" dTy

                out.WriteLine()

                go defTail

            | CEnumDef (enumName, enumVals) ->
                let rec evalEnum enums value =
                    match value with
                    | CExprInt i -> i
                    | CExprName n ->
                        Seq.pick (fun (name, value) -> 
                            if name = n then
                                match value with
                                | Some value -> Some (evalEnum enums value)
                                | None -> failwith "Tried to eval an enum with no value"
                            else
                                None) enums
                    | CExprBitOr (a, b) -> (evalEnum enums a) ||| (evalEnum enums b)
                    | CExprMinus (a, b) -> (evalEnum enums a) - (evalEnum enums b)

                ifprintfn 2 out "type %s =" (toFSharpDataName enumName)
                let mutable nextEnumVal = 0
                for eValName, maybeEnumVal in enumVals do
                    match maybeEnumVal with
                    | Some enumVal -> nextEnumVal <- (evalEnum enumVals enumVal)
                    | None -> ()
                    
                    ifprintfn 3 out "| %s = %i" (toFSharpDataName eValName) nextEnumVal
                    nextEnumVal <- nextEnumVal + 1
                out.WriteLine ()
                
                go defTail

            | CStructDef (structName, structFields) ->
                for (_, field) in structFields do
                    match field.baseType with
                    | FunctionType (name, retTy, args) ->
                        // An unnamed function type is being passed in, generate a type for it
                        let dTy = String.concat "" [
                                    (sprintf "type %s = delegate of " (toFSharpDataName name))
                                    (String.concat " * " (args |> Seq.map (fun (arg, _) -> typeToStr false true arg)))
                                    (sprintf " -> %s" (typeToStr false false retTy))]

                        ifprintfn 2 out "%s" dTy
                        out.WriteLine()
                    | _ -> ()

                ifprintfn 2 out "[<Struct>]"
                ifprintfn 2 out "type %s =" (toFSharpDataName structName)
                for (fieldName, fieldType) in structFields do
                    match fieldType.arraySize with
                    | None -> ifprintfn 3 out "val mutable %s : %s" (toFSharpVariableName fieldName) (typeToStr false false fieldType)
                    | Some size ->
                        // Fixed array, need to hack in multiple fields untill F# supports this
                        for i = 0 to size - 1 do
                            let ty = { fieldType with arraySize = None }
                            let name = sprintf "%s%i" (toFSharpVariableName fieldName) i
                            ifprintfn 3 out "val mutable %s : %s" name (typeToStr false false ty)

                out.WriteLine ()

                go defTail

            | CTypeAlias ({CFullType.baseType = StructType _; CFullType.pointerDepth = 1}, name) ->
                let dataName = toFSharpDataName name
                ifprintfn 2 out "type %s (thePtr : nativeint) =" dataName
                ifprintfn 3 out "member x.Ptr = (x :> ILLVMRef).Ptr"
                ifprintfn 3 out "interface ILLVMRef with member x.Ptr = thePtr"
                out.WriteLine ()
                
                go defTail

            | CTypeAlias ({CFullType.baseType = VoidType; CFullType.pointerDepth = 1}, name) ->
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

let parse cPrefix modulePrefix modulesToProcess (outSrcFile : string) =
    let parseMod (m : string) =
        let hFile = Path.Combine (cPrefix, Path.Combine (m.Split '.') + ".h")
        let reader = new StreamReader(hFile)
        let lexbuf = LexBuffer<_>.FromTextReader reader
        start tokenize lexbuf
    let writer = new StreamWriter(outSrcFile, true (* append *))
    let rec processModules friendlyCount nativeCount (mods : (string * string list) list) =
        match mods with
        | [] -> (friendlyCount, nativeCount)
        | ((m : string), deps) :: mTail ->
            let modName m = modulePrefix + ".Generated." + m
            let depDefs = List.map (fun m -> (modName m, parseMod m)) deps
            let friendlyFuncCount, nativeFuncCount =
                toFSharpSource modulePrefix (modName m) writer depDefs (parseMod m)
            printfn
                "inferred friendly types for %i/%i functions in %s"
                friendlyFuncCount
                nativeFuncCount
                m
            
            processModules
                (friendlyCount + friendlyFuncCount)
                (nativeCount + nativeFuncCount)
                mTail
    
    let friendlyFuncCount, nativeFuncCount =
        processModules 0 0 modulesToProcess
    writer.Close ()
    printfn "inferred friendly types for %i/%i functions in total" friendlyFuncCount nativeFuncCount

[<EntryPoint>]
let main (args : string array) =
    match args with
    | [|llvmHome; outSrcFile|] ->
        System.IO.File.Delete(outSrcFile)

        let llvmPrefix = Path.Combine [|llvmHome; "include"; "llvm-c"|]
        let llvmModules = [
            ("Support",             [])
            ("Object",              ["Support"])
            ("Core",                ["Support"])
            ("Initialization",      ["Core"])
            ("BitReader",           ["Support"; "Core"])
            ("BitWriter",           ["Support"; "Core"])
            ("Target",              ["Core"])
            ("TargetMachine",       ["Support"; "Core"; "Target"])
            ("ExecutionEngine",     ["Core"; "Target"; "TargetMachine"])
            ("Analysis",            ["Core"])
            ("Transforms.Scalar",   ["Core"])
            ("Transforms.IPO",      ["Core"])]
        parse llvmPrefix "LLVM" llvmModules outSrcFile

        let clangPrefix = Path.Combine [|llvmHome; "tools"; "clang"; "include"; "clang-c"|]
        let clangModules = [
            ("CXString",              [])
            ("CXErrorCode",           [])
            ("CXCompilationDatabase", ["CXString"])
            ("BuildSystem",           ["CXString"; "CXErrorCode"])
            ("Index",                 ["CXString"; "CXErrorCode"; "BuildSystem"])
           //("Documentation",         ["Index"])
           ]
        parse clangPrefix "Clang" clangModules outSrcFile
    | _ ->
        failwith "usage: bindinggen llvmHome outSrcFile"
    
    // Exit code
    0
