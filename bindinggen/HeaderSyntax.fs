module FSExternHelper.HeaderSyntax

type CExpr =
    | CExprName of string
    | CExprInt of int
    | CExprBitOr of CExpr * CExpr
    | CExprMinus of CExpr * CExpr

type CBaseType =
    | GeneralType of string
    | StructType of string
    | FunctionType of string * CFullType * (CFullType * string option) list
    | IntType
    | VoidType
    | CharType
    | UnsignedIntType
    | UnsignedLongLongType
    | LongLongType
    | UnsignedByteType
    | SizeTType
    | UIntPtrTType
    | TimeTType
    | DoubleType
    override self.ToString() =
        match self with
        | GeneralType s -> s
        | StructType s -> "struct " + s
        | FunctionType (name, returnTy, paramTys) ->
            let args = String.concat ", " (Seq.map (fun (p, _) -> p.ToString()) paramTys)
            String.concat "" [returnTy.ToString(); " ( *"; name; " )( "; args; " )"]
        | IntType -> "int"
        | VoidType -> "void"
        | CharType -> "char"
        | UnsignedIntType -> "unsigned"
        | UnsignedLongLongType -> "unsigned long long"
        | LongLongType -> "long long"
        | UnsignedByteType -> "uint8_t"
        | SizeTType -> "size_t"
        | UIntPtrTType -> "uintptr_t"
        | TimeTType -> "time_t"
        | DoubleType -> "double"

and CFullType = {
    baseType : CBaseType
    isConst : bool
    pointerDepth: int
    arraySize : int option} with
    override x.ToString() =
        let mutable str = x.baseType.ToString ()
        if x.isConst then
            str <- "const " + str
        for i = 0 to x.pointerDepth - 1 do
            str <- str + "*"
        match x.arraySize with
        | Some size ->
            str <- str + "["
            if size <> 0 then
                str <- str + (size.ToString())
            str <- str + "]"
        | None -> ()
        str

type CDef =
    | CFuncPtrDef of CFullType * string * (CFullType * string option) list
    | CFuncDef of CFullType * string * (CFullType * string option) list
    | CEnumDef of string * (string * CExpr option) list
    | CStructDef of string * (string * CFullType) list
    | CTypeAlias of CFullType * string

