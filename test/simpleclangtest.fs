open System
open Clang.Generated.Index

let translationUnitVisitor (cursor : CXCursor) parent client_data =
    printfn "Visited %A" (cursor.kind)
    CXChildVisitResult.CXChildVisit_Recurse

[<EntryPoint>]
let main _ =
    let idx = createIndex 1 1
    let tu = createTranslationUnit idx "/work/mono/llvm-fs/test/IndexTest.pch"
    let visitor = new CXCursorVisitor(translationUnitVisitor)
    let cursor = getTranslationUnitCursor tu
    let visit = visitChildren cursor visitor (new CXClientData(IntPtr.Zero))
    disposeTranslationUnit tu
    disposeIndex idx
    GC.KeepAlive visitor
    0
