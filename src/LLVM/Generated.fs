// This file should not be edited. It is automatically generated from a C header file
namespace LLVM.Generated

    open LLVM.FFIUtil
    open System.Runtime.InteropServices

    module Support =

        type MemoryBufferRef (thePtr : nativeint) =
            member x.Ptr = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr = thePtr

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMLoadLibraryPermanently",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool loadLibraryPermanentlyNative(
            string Filename)
        let loadLibraryPermanently _Filename =
            loadLibraryPermanentlyNative (_Filename)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMParseCommandLineOptions",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void parseCommandLineOptionsNative(
            int argc,
            void* (* const char** *) argv,
            string Overview)
        // I don't know how to generate an "F# friendly" version of LLVMParseCommandLineOptions

// This file should not be edited. It is automatically generated from a C header file
namespace LLVM.Generated

    open LLVM.FFIUtil
    open System.Runtime.InteropServices
    open LLVM.Generated.Support

    module Object =

        type ObjectFileRef (thePtr : nativeint) =
            member x.Ptr = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr = thePtr

        type SectionIteratorRef (thePtr : nativeint) =
            member x.Ptr = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr = thePtr

        type SymbolIteratorRef (thePtr : nativeint) =
            member x.Ptr = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr = thePtr

        type RelocationIteratorRef (thePtr : nativeint) =
            member x.Ptr = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr = thePtr

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMCreateObjectFile",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMObjectFileRef *) createObjectFileNative(
            void* (* LLVMMemoryBufferRef *) MemBuf)
        let createObjectFile _MemBuf =
            new ObjectFileRef (createObjectFileNative ((_MemBuf : MemoryBufferRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMDisposeObjectFile",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void disposeObjectFileNative(
            void* (* LLVMObjectFileRef *) ObjectFile)
        let disposeObjectFile _ObjectFile =
            disposeObjectFileNative ((_ObjectFile : ObjectFileRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetSections",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMSectionIteratorRef *) getSectionsNative(
            void* (* LLVMObjectFileRef *) ObjectFile)
        let getSections _ObjectFile =
            new SectionIteratorRef (getSectionsNative ((_ObjectFile : ObjectFileRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMDisposeSectionIterator",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void disposeSectionIteratorNative(
            void* (* LLVMSectionIteratorRef *) SI)
        let disposeSectionIterator _SI =
            disposeSectionIteratorNative ((_SI : SectionIteratorRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMIsSectionIteratorAtEnd",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool isSectionIteratorAtEndNative(
            void* (* LLVMObjectFileRef *) ObjectFile,
            void* (* LLVMSectionIteratorRef *) SI)
        let isSectionIteratorAtEnd _ObjectFile _SI =
            isSectionIteratorAtEndNative ((_ObjectFile : ObjectFileRef).Ptr, (_SI : SectionIteratorRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMMoveToNextSection",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void moveToNextSectionNative(
            void* (* LLVMSectionIteratorRef *) SI)
        let moveToNextSection _SI =
            moveToNextSectionNative ((_SI : SectionIteratorRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMMoveToContainingSection",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void moveToContainingSectionNative(
            void* (* LLVMSectionIteratorRef *) Sect,
            void* (* LLVMSymbolIteratorRef *) Sym)
        let moveToContainingSection _Sect _Sym =
            moveToContainingSectionNative ((_Sect : SectionIteratorRef).Ptr, (_Sym : SymbolIteratorRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetSymbols",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMSymbolIteratorRef *) getSymbolsNative(
            void* (* LLVMObjectFileRef *) ObjectFile)
        let getSymbols _ObjectFile =
            new SymbolIteratorRef (getSymbolsNative ((_ObjectFile : ObjectFileRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMDisposeSymbolIterator",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void disposeSymbolIteratorNative(
            void* (* LLVMSymbolIteratorRef *) SI)
        let disposeSymbolIterator _SI =
            disposeSymbolIteratorNative ((_SI : SymbolIteratorRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMIsSymbolIteratorAtEnd",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool isSymbolIteratorAtEndNative(
            void* (* LLVMObjectFileRef *) ObjectFile,
            void* (* LLVMSymbolIteratorRef *) SI)
        let isSymbolIteratorAtEnd _ObjectFile _SI =
            isSymbolIteratorAtEndNative ((_ObjectFile : ObjectFileRef).Ptr, (_SI : SymbolIteratorRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMMoveToNextSymbol",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void moveToNextSymbolNative(
            void* (* LLVMSymbolIteratorRef *) SI)
        let moveToNextSymbol _SI =
            moveToNextSymbolNative ((_SI : SymbolIteratorRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetSectionName",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* const char* *) getSectionNameNative(
            void* (* LLVMSectionIteratorRef *) SI)
        let getSectionName _SI =
            Marshal.PtrToStringAuto (getSectionNameNative ((_SI : SectionIteratorRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetSectionSize",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint64 getSectionSizeNative(
            void* (* LLVMSectionIteratorRef *) SI)
        let getSectionSize _SI =
            getSectionSizeNative ((_SI : SectionIteratorRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetSectionContents",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* const char* *) getSectionContentsNative(
            void* (* LLVMSectionIteratorRef *) SI)
        let getSectionContents _SI =
            Marshal.PtrToStringAuto (getSectionContentsNative ((_SI : SectionIteratorRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetSectionAddress",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint64 getSectionAddressNative(
            void* (* LLVMSectionIteratorRef *) SI)
        let getSectionAddress _SI =
            getSectionAddressNative ((_SI : SectionIteratorRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetSectionContainsSymbol",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool getSectionContainsSymbolNative(
            void* (* LLVMSectionIteratorRef *) SI,
            void* (* LLVMSymbolIteratorRef *) Sym)
        let getSectionContainsSymbol _SI _Sym =
            getSectionContainsSymbolNative ((_SI : SectionIteratorRef).Ptr, (_Sym : SymbolIteratorRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetRelocations",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMRelocationIteratorRef *) getRelocationsNative(
            void* (* LLVMSectionIteratorRef *) Section)
        let getRelocations _Section =
            new RelocationIteratorRef (getRelocationsNative ((_Section : SectionIteratorRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMDisposeRelocationIterator",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void disposeRelocationIteratorNative(
            void* (* LLVMRelocationIteratorRef *) RI)
        let disposeRelocationIterator _RI =
            disposeRelocationIteratorNative ((_RI : RelocationIteratorRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMIsRelocationIteratorAtEnd",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool isRelocationIteratorAtEndNative(
            void* (* LLVMSectionIteratorRef *) Section,
            void* (* LLVMRelocationIteratorRef *) RI)
        let isRelocationIteratorAtEnd _Section _RI =
            isRelocationIteratorAtEndNative ((_Section : SectionIteratorRef).Ptr, (_RI : RelocationIteratorRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMMoveToNextRelocation",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void moveToNextRelocationNative(
            void* (* LLVMRelocationIteratorRef *) RI)
        let moveToNextRelocation _RI =
            moveToNextRelocationNative ((_RI : RelocationIteratorRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetSymbolName",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* const char* *) getSymbolNameNative(
            void* (* LLVMSymbolIteratorRef *) SI)
        let getSymbolName _SI =
            Marshal.PtrToStringAuto (getSymbolNameNative ((_SI : SymbolIteratorRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetSymbolAddress",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint64 getSymbolAddressNative(
            void* (* LLVMSymbolIteratorRef *) SI)
        let getSymbolAddress _SI =
            getSymbolAddressNative ((_SI : SymbolIteratorRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetSymbolSize",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint64 getSymbolSizeNative(
            void* (* LLVMSymbolIteratorRef *) SI)
        let getSymbolSize _SI =
            getSymbolSizeNative ((_SI : SymbolIteratorRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetRelocationAddress",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint64 getRelocationAddressNative(
            void* (* LLVMRelocationIteratorRef *) RI)
        let getRelocationAddress _RI =
            getRelocationAddressNative ((_RI : RelocationIteratorRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetRelocationOffset",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint64 getRelocationOffsetNative(
            void* (* LLVMRelocationIteratorRef *) RI)
        let getRelocationOffset _RI =
            getRelocationOffsetNative ((_RI : RelocationIteratorRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetRelocationSymbol",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMSymbolIteratorRef *) getRelocationSymbolNative(
            void* (* LLVMRelocationIteratorRef *) RI)
        let getRelocationSymbol _RI =
            new SymbolIteratorRef (getRelocationSymbolNative ((_RI : RelocationIteratorRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetRelocationType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint64 getRelocationTypeNative(
            void* (* LLVMRelocationIteratorRef *) RI)
        let getRelocationType _RI =
            getRelocationTypeNative ((_RI : RelocationIteratorRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetRelocationTypeName",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* const char* *) getRelocationTypeNameNative(
            void* (* LLVMRelocationIteratorRef *) RI)
        let getRelocationTypeName _RI =
            Marshal.PtrToStringAuto (getRelocationTypeNameNative ((_RI : RelocationIteratorRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetRelocationValueString",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* const char* *) getRelocationValueStringNative(
            void* (* LLVMRelocationIteratorRef *) RI)
        let getRelocationValueString _RI =
            Marshal.PtrToStringAuto (getRelocationValueStringNative ((_RI : RelocationIteratorRef).Ptr))

// This file should not be edited. It is automatically generated from a C header file
namespace LLVM.Generated

    open LLVM.FFIUtil
    open System.Runtime.InteropServices
    open LLVM.Generated.Support

    module Core =

        type ContextRef (thePtr : nativeint) =
            member x.Ptr = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr = thePtr

        type ModuleRef (thePtr : nativeint) =
            member x.Ptr = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr = thePtr

        type TypeRef (thePtr : nativeint) =
            member x.Ptr = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr = thePtr

        type ValueRef (thePtr : nativeint) =
            member x.Ptr = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr = thePtr

        type BasicBlockRef (thePtr : nativeint) =
            member x.Ptr = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr = thePtr

        type BuilderRef (thePtr : nativeint) =
            member x.Ptr = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr = thePtr

        type ModuleProviderRef (thePtr : nativeint) =
            member x.Ptr = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr = thePtr

        type PassManagerRef (thePtr : nativeint) =
            member x.Ptr = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr = thePtr

        type PassRegistryRef (thePtr : nativeint) =
            member x.Ptr = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr = thePtr

        type UseRef (thePtr : nativeint) =
            member x.Ptr = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr = thePtr

        type DiagnosticInfoRef (thePtr : nativeint) =
            member x.Ptr = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr = thePtr

        type Attribute =
            | ZExtAttribute = 1
            | SExtAttribute = 2
            | NoReturnAttribute = 4
            | InRegAttribute = 8
            | StructRetAttribute = 16
            | NoUnwindAttribute = 32
            | NoAliasAttribute = 64
            | ByValAttribute = 128
            | NestAttribute = 256
            | ReadNoneAttribute = 512
            | ReadOnlyAttribute = 1024
            | NoInlineAttribute = 2048
            | AlwaysInlineAttribute = 4096
            | OptimizeForSizeAttribute = 8192
            | StackProtectAttribute = 16384
            | StackProtectReqAttribute = 32768
            | Alignment = 2031616
            | NoCaptureAttribute = 2097152
            | NoRedZoneAttribute = 4194304
            | NoImplicitFloatAttribute = 8388608
            | NakedAttribute = 16777216
            | InlineHintAttribute = 33554432
            | StackAlignment = 469762048
            | ReturnsTwice = 536870912
            | UWTable = 1073741824
            | NonLazyBind = -2147483648

        type Opcode =
            | Ret = 1
            | Br = 2
            | Switch = 3
            | IndirectBr = 4
            | Invoke = 5
            | Unreachable = 7
            | Add = 8
            | FAdd = 9
            | Sub = 10
            | FSub = 11
            | Mul = 12
            | FMul = 13
            | UDiv = 14
            | SDiv = 15
            | FDiv = 16
            | URem = 17
            | SRem = 18
            | FRem = 19
            | Shl = 20
            | LShr = 21
            | AShr = 22
            | And = 23
            | Or = 24
            | Xor = 25
            | Alloca = 26
            | Load = 27
            | Store = 28
            | GetElementPtr = 29
            | Trunc = 30
            | ZExt = 31
            | SExt = 32
            | FPToUI = 33
            | FPToSI = 34
            | UIToFP = 35
            | SIToFP = 36
            | FPTrunc = 37
            | FPExt = 38
            | PtrToInt = 39
            | IntToPtr = 40
            | BitCast = 41
            | AddrSpaceCast = 60
            | ICmp = 42
            | FCmp = 43
            | PHI = 44
            | Call = 45
            | Select = 46
            | UserOp1 = 47
            | UserOp2 = 48
            | VAArg = 49
            | ExtractElement = 50
            | InsertElement = 51
            | ShuffleVector = 52
            | ExtractValue = 53
            | InsertValue = 54
            | Fence = 55
            | AtomicCmpXchg = 56
            | AtomicRMW = 57
            | Resume = 58
            | LandingPad = 59

        type TypeKind =
            | VoidTypeKind = 0
            | HalfTypeKind = 1
            | FloatTypeKind = 2
            | DoubleTypeKind = 3
            | X86_FP80TypeKind = 4
            | FP128TypeKind = 5
            | PPC_FP128TypeKind = 6
            | LabelTypeKind = 7
            | IntegerTypeKind = 8
            | FunctionTypeKind = 9
            | StructTypeKind = 10
            | ArrayTypeKind = 11
            | PointerTypeKind = 12
            | VectorTypeKind = 13
            | MetadataTypeKind = 14
            | X86_MMXTypeKind = 15

        type Linkage =
            | ExternalLinkage = 0
            | AvailableExternallyLinkage = 1
            | LinkOnceAnyLinkage = 2
            | LinkOnceODRLinkage = 3
            | LinkOnceODRAutoHideLinkage = 4
            | WeakAnyLinkage = 5
            | WeakODRLinkage = 6
            | AppendingLinkage = 7
            | InternalLinkage = 8
            | PrivateLinkage = 9
            | DLLImportLinkage = 10
            | DLLExportLinkage = 11
            | ExternalWeakLinkage = 12
            | GhostLinkage = 13
            | CommonLinkage = 14
            | LinkerPrivateLinkage = 15
            | LinkerPrivateWeakLinkage = 16

        type Visibility =
            | DefaultVisibility = 0
            | HiddenVisibility = 1
            | ProtectedVisibility = 2

        type DLLStorageClass =
            | DefaultStorageClass = 0
            | DLLImportStorageClass = 1
            | DLLExportStorageClass = 2

        type CallConv =
            | CCallConv = 0
            | FastCallConv = 8
            | ColdCallConv = 9
            | WebKitJSCallConv = 12
            | AnyRegCallConv = 13
            | X86StdcallCallConv = 64
            | X86FastcallCallConv = 65

        type IntPredicate =
            | IntEQ = 32
            | IntNE = 33
            | IntUGT = 34
            | IntUGE = 35
            | IntULT = 36
            | IntULE = 37
            | IntSGT = 38
            | IntSGE = 39
            | IntSLT = 40
            | IntSLE = 41

        type RealPredicate =
            | RealPredicateFalse = 0
            | RealOEQ = 1
            | RealOGT = 2
            | RealOGE = 3
            | RealOLT = 4
            | RealOLE = 5
            | RealONE = 6
            | RealORD = 7
            | RealUNO = 8
            | RealUEQ = 9
            | RealUGT = 10
            | RealUGE = 11
            | RealULT = 12
            | RealULE = 13
            | RealUNE = 14
            | RealPredicateTrue = 15

        type LandingPadClauseTy =
            | LandingPadCatch = 0
            | LandingPadFilter = 1

        type ThreadLocalMode =
            | NotThreadLocal = 0
            | GeneralDynamicTLSModel = 1
            | LocalDynamicTLSModel = 2
            | InitialExecTLSModel = 3
            | LocalExecTLSModel = 4

        type AtomicOrdering =
            | AtomicOrderingNotAtomic = 0
            | AtomicOrderingUnordered = 1
            | AtomicOrderingMonotonic = 2
            | AtomicOrderingAcquire = 4
            | AtomicOrderingRelease = 5
            | AtomicOrderingAcquireRelease = 6
            | AtomicOrderingSequentiallyConsistent = 7

        type AtomicRMWBinOp =
            | AtomicRMWBinOpXchg = 0
            | AtomicRMWBinOpAdd = 1
            | AtomicRMWBinOpSub = 2
            | AtomicRMWBinOpAnd = 3
            | AtomicRMWBinOpNand = 4
            | AtomicRMWBinOpOr = 5
            | AtomicRMWBinOpXor = 6
            | AtomicRMWBinOpMax = 7
            | AtomicRMWBinOpMin = 8
            | AtomicRMWBinOpUMax = 9
            | AtomicRMWBinOpUMin = 10

        type DiagnosticSeverity =
            | DSError = 0
            | DSWarning = 1
            | DSRemark = 2
            | DSNote = 3

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMInitializeCore",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void initializeCoreNative(
            void* (* LLVMPassRegistryRef *) R)
        let initializeCore _R =
            initializeCoreNative ((_R : PassRegistryRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMShutdown",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void shutdownNative()
        let shutdown () =
            shutdownNative ()

        // LLVMCreateMessage is blacklisted by the binding generator

        // LLVMDisposeMessage is blacklisted by the binding generator

        type FatalErrorHandler = delegate of string -> Unit

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMInstallFatalErrorHandler",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void installFatalErrorHandlerNative(
            FatalErrorHandler (* function pointer *) Handler)
        let installFatalErrorHandler _Handler =
            installFatalErrorHandlerNative (_Handler)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMResetFatalErrorHandler",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void resetFatalErrorHandlerNative()
        let resetFatalErrorHandler () =
            resetFatalErrorHandlerNative ()

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMEnablePrettyStackTrace",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void enablePrettyStackTraceNative()
        let enablePrettyStackTrace () =
            enablePrettyStackTraceNative ()

        type DiagnosticHandler = delegate of nativeint (* LLVMDiagnosticInfoRef *) * nativeint (* nativeptr<void> *) -> Unit

        type YieldCallback = delegate of nativeint (* LLVMContextRef *) * nativeint (* nativeptr<void> *) -> Unit

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMContextCreate",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMContextRef *) contextCreateNative()
        let contextCreate () =
            new ContextRef (contextCreateNative ())

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetGlobalContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMContextRef *) getGlobalContextNative()
        let getGlobalContext () =
            new ContextRef (getGlobalContextNative ())

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMContextSetDiagnosticHandler",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void contextSetDiagnosticHandlerNative(
            void* (* LLVMContextRef *) C,
            DiagnosticHandler (* function pointer *) Handler,
            void* DiagnosticContext)
        let contextSetDiagnosticHandler _C _Handler _DiagnosticContext =
            contextSetDiagnosticHandlerNative ((_C : ContextRef).Ptr, _Handler, (_DiagnosticContext : nativeint))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMContextSetYieldCallback",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void contextSetYieldCallbackNative(
            void* (* LLVMContextRef *) C,
            YieldCallback (* function pointer *) Callback,
            void* OpaqueHandle)
        let contextSetYieldCallback _C _Callback _OpaqueHandle =
            contextSetYieldCallbackNative ((_C : ContextRef).Ptr, _Callback, (_OpaqueHandle : nativeint))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMContextDispose",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void contextDisposeNative(
            void* (* LLVMContextRef *) C)
        let contextDispose _C =
            contextDisposeNative ((_C : ContextRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetDiagInfoDescription",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* char* *) getDiagInfoDescriptionNative(
            void* (* LLVMDiagnosticInfoRef *) DI)
        let getDiagInfoDescription _DI =
            Marshal.PtrToStringAuto (getDiagInfoDescriptionNative ((_DI : DiagnosticInfoRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetDiagInfoSeverity",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int (* LLVMDiagnosticSeverity *) getDiagInfoSeverityNative(
            void* (* LLVMDiagnosticInfoRef *) DI)
        let getDiagInfoSeverity _DI =
            enum<DiagnosticSeverity> (getDiagInfoSeverityNative ((_DI : DiagnosticInfoRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetMDKindIDInContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 getMDKindIDInContextNative(
            void* (* LLVMContextRef *) C,
            string Name,
            uint32 SLen)
        let getMDKindIDInContext _C _Name _SLen =
            getMDKindIDInContextNative ((_C : ContextRef).Ptr, _Name, _SLen)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetMDKindID",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 getMDKindIDNative(
            string Name,
            uint32 SLen)
        let getMDKindID _Name _SLen =
            getMDKindIDNative (_Name, _SLen)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMModuleCreateWithName",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMModuleRef *) moduleCreateWithNameNative(
            string ModuleID)
        let moduleCreateWithName _ModuleID =
            new ModuleRef (moduleCreateWithNameNative (_ModuleID))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMModuleCreateWithNameInContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMModuleRef *) moduleCreateWithNameInContextNative(
            string ModuleID,
            void* (* LLVMContextRef *) C)
        let moduleCreateWithNameInContext _ModuleID _C =
            new ModuleRef (moduleCreateWithNameInContextNative (_ModuleID, (_C : ContextRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMCloneModule",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMModuleRef *) cloneModuleNative(
            void* (* LLVMModuleRef *) M)
        let cloneModule _M =
            new ModuleRef (cloneModuleNative ((_M : ModuleRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMDisposeModule",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void disposeModuleNative(
            void* (* LLVMModuleRef *) M)
        let disposeModule _M =
            disposeModuleNative ((_M : ModuleRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetDataLayout",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* const char* *) getDataLayoutNative(
            void* (* LLVMModuleRef *) M)
        let getDataLayout _M =
            Marshal.PtrToStringAuto (getDataLayoutNative ((_M : ModuleRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMSetDataLayout",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void setDataLayoutNative(
            void* (* LLVMModuleRef *) M,
            string Triple)
        let setDataLayout _M _Triple =
            setDataLayoutNative ((_M : ModuleRef).Ptr, _Triple)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetTarget",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* const char* *) getTargetNative(
            void* (* LLVMModuleRef *) M)
        let getTarget _M =
            Marshal.PtrToStringAuto (getTargetNative ((_M : ModuleRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMSetTarget",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void setTargetNative(
            void* (* LLVMModuleRef *) M,
            string Triple)
        let setTarget _M _Triple =
            setTargetNative ((_M : ModuleRef).Ptr, _Triple)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMDumpModule",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void dumpModuleNative(
            void* (* LLVMModuleRef *) M)
        let dumpModule _M =
            dumpModuleNative ((_M : ModuleRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMPrintModuleToFile",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool printModuleToFileNative(
            void* (* LLVMModuleRef *) M,
            string Filename,
            void* (* char** *) ErrorMessage)
        // I don't know how to generate an "F# friendly" version of LLVMPrintModuleToFile

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMPrintModuleToString",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* char* *) printModuleToStringNative(
            void* (* LLVMModuleRef *) M)
        let printModuleToString _M =
            Marshal.PtrToStringAuto (printModuleToStringNative ((_M : ModuleRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMSetModuleInlineAsm",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void setModuleInlineAsmNative(
            void* (* LLVMModuleRef *) M,
            string Asm)
        let setModuleInlineAsm _M _Asm =
            setModuleInlineAsmNative ((_M : ModuleRef).Ptr, _Asm)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetModuleContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMContextRef *) getModuleContextNative(
            void* (* LLVMModuleRef *) M)
        let getModuleContext _M =
            new ContextRef (getModuleContextNative ((_M : ModuleRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetTypeByName",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) getTypeByNameNative(
            void* (* LLVMModuleRef *) M,
            string Name)
        let getTypeByName _M _Name =
            new TypeRef (getTypeByNameNative ((_M : ModuleRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetNamedMetadataNumOperands",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 getNamedMetadataNumOperandsNative(
            void* (* LLVMModuleRef *) M,
            string name)
        let getNamedMetadataNumOperands _M _name =
            getNamedMetadataNumOperandsNative ((_M : ModuleRef).Ptr, _name)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetNamedMetadataOperands",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void getNamedMetadataOperandsNative(
            void* (* LLVMModuleRef *) M,
            string name,
            void* (* LLVMValueRef* *) Dest)
        // I don't know how to generate an "F# friendly" version of LLVMGetNamedMetadataOperands

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddNamedMetadataOperand",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addNamedMetadataOperandNative(
            void* (* LLVMModuleRef *) M,
            string name,
            void* (* LLVMValueRef *) Val)
        let addNamedMetadataOperand _M _name _Val =
            addNamedMetadataOperandNative ((_M : ModuleRef).Ptr, _name, (_Val : ValueRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddFunction",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) addFunctionNative(
            void* (* LLVMModuleRef *) M,
            string Name,
            void* (* LLVMTypeRef *) FunctionTy)
        let addFunction _M _Name _FunctionTy =
            new ValueRef (addFunctionNative ((_M : ModuleRef).Ptr, _Name, (_FunctionTy : TypeRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetNamedFunction",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getNamedFunctionNative(
            void* (* LLVMModuleRef *) M,
            string Name)
        let getNamedFunction _M _Name =
            new ValueRef (getNamedFunctionNative ((_M : ModuleRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetFirstFunction",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getFirstFunctionNative(
            void* (* LLVMModuleRef *) M)
        let getFirstFunction _M =
            new ValueRef (getFirstFunctionNative ((_M : ModuleRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetLastFunction",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getLastFunctionNative(
            void* (* LLVMModuleRef *) M)
        let getLastFunction _M =
            new ValueRef (getLastFunctionNative ((_M : ModuleRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetNextFunction",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getNextFunctionNative(
            void* (* LLVMValueRef *) Fn)
        let getNextFunction _Fn =
            new ValueRef (getNextFunctionNative ((_Fn : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetPreviousFunction",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getPreviousFunctionNative(
            void* (* LLVMValueRef *) Fn)
        let getPreviousFunction _Fn =
            new ValueRef (getPreviousFunctionNative ((_Fn : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetTypeKind",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int (* LLVMTypeKind *) getTypeKindNative(
            void* (* LLVMTypeRef *) Ty)
        let getTypeKind _Ty =
            enum<TypeKind> (getTypeKindNative ((_Ty : TypeRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMTypeIsSized",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool typeIsSizedNative(
            void* (* LLVMTypeRef *) Ty)
        let typeIsSized _Ty =
            typeIsSizedNative ((_Ty : TypeRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetTypeContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMContextRef *) getTypeContextNative(
            void* (* LLVMTypeRef *) Ty)
        let getTypeContext _Ty =
            new ContextRef (getTypeContextNative ((_Ty : TypeRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMDumpType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void dumpTypeNative(
            void* (* LLVMTypeRef *) Val)
        let dumpType _Val =
            dumpTypeNative ((_Val : TypeRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMPrintTypeToString",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* char* *) printTypeToStringNative(
            void* (* LLVMTypeRef *) Val)
        let printTypeToString _Val =
            Marshal.PtrToStringAuto (printTypeToStringNative ((_Val : TypeRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMInt1TypeInContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) int1TypeInContextNative(
            void* (* LLVMContextRef *) C)
        let int1TypeInContext _C =
            new TypeRef (int1TypeInContextNative ((_C : ContextRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMInt8TypeInContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) int8TypeInContextNative(
            void* (* LLVMContextRef *) C)
        let int8TypeInContext _C =
            new TypeRef (int8TypeInContextNative ((_C : ContextRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMInt16TypeInContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) int16TypeInContextNative(
            void* (* LLVMContextRef *) C)
        let int16TypeInContext _C =
            new TypeRef (int16TypeInContextNative ((_C : ContextRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMInt32TypeInContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) int32TypeInContextNative(
            void* (* LLVMContextRef *) C)
        let int32TypeInContext _C =
            new TypeRef (int32TypeInContextNative ((_C : ContextRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMInt64TypeInContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) int64TypeInContextNative(
            void* (* LLVMContextRef *) C)
        let int64TypeInContext _C =
            new TypeRef (int64TypeInContextNative ((_C : ContextRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMIntTypeInContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) intTypeInContextNative(
            void* (* LLVMContextRef *) C,
            uint32 NumBits)
        let intTypeInContext _C _NumBits =
            new TypeRef (intTypeInContextNative ((_C : ContextRef).Ptr, _NumBits))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMInt1Type",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) int1TypeNative()
        let int1Type () =
            new TypeRef (int1TypeNative ())

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMInt8Type",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) int8TypeNative()
        let int8Type () =
            new TypeRef (int8TypeNative ())

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMInt16Type",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) int16TypeNative()
        let int16Type () =
            new TypeRef (int16TypeNative ())

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMInt32Type",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) int32TypeNative()
        let int32Type () =
            new TypeRef (int32TypeNative ())

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMInt64Type",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) int64TypeNative()
        let int64Type () =
            new TypeRef (int64TypeNative ())

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMIntType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) intTypeNative(
            uint32 NumBits)
        let intType _NumBits =
            new TypeRef (intTypeNative (_NumBits))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetIntTypeWidth",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 getIntTypeWidthNative(
            void* (* LLVMTypeRef *) IntegerTy)
        let getIntTypeWidth _IntegerTy =
            getIntTypeWidthNative ((_IntegerTy : TypeRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMHalfTypeInContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) halfTypeInContextNative(
            void* (* LLVMContextRef *) C)
        let halfTypeInContext _C =
            new TypeRef (halfTypeInContextNative ((_C : ContextRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMFloatTypeInContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) floatTypeInContextNative(
            void* (* LLVMContextRef *) C)
        let floatTypeInContext _C =
            new TypeRef (floatTypeInContextNative ((_C : ContextRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMDoubleTypeInContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) doubleTypeInContextNative(
            void* (* LLVMContextRef *) C)
        let doubleTypeInContext _C =
            new TypeRef (doubleTypeInContextNative ((_C : ContextRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMX86FP80TypeInContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) x86FP80TypeInContextNative(
            void* (* LLVMContextRef *) C)
        let x86FP80TypeInContext _C =
            new TypeRef (x86FP80TypeInContextNative ((_C : ContextRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMFP128TypeInContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) fP128TypeInContextNative(
            void* (* LLVMContextRef *) C)
        let fP128TypeInContext _C =
            new TypeRef (fP128TypeInContextNative ((_C : ContextRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMPPCFP128TypeInContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) pPCFP128TypeInContextNative(
            void* (* LLVMContextRef *) C)
        let pPCFP128TypeInContext _C =
            new TypeRef (pPCFP128TypeInContextNative ((_C : ContextRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMHalfType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) halfTypeNative()
        let halfType () =
            new TypeRef (halfTypeNative ())

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMFloatType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) floatTypeNative()
        let floatType () =
            new TypeRef (floatTypeNative ())

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMDoubleType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) doubleTypeNative()
        let doubleType () =
            new TypeRef (doubleTypeNative ())

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMX86FP80Type",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) x86FP80TypeNative()
        let x86FP80Type () =
            new TypeRef (x86FP80TypeNative ())

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMFP128Type",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) fP128TypeNative()
        let fP128Type () =
            new TypeRef (fP128TypeNative ())

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMPPCFP128Type",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) pPCFP128TypeNative()
        let pPCFP128Type () =
            new TypeRef (pPCFP128TypeNative ())

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMFunctionType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) functionTypeNative(
            void* (* LLVMTypeRef *) ReturnType,
            void* (* LLVMTypeRef* *) ParamTypes,
            uint32 ParamCount,
            bool IsVarArg)
        // I don't know how to generate an "F# friendly" version of LLVMFunctionType

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMIsFunctionVarArg",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool isFunctionVarArgNative(
            void* (* LLVMTypeRef *) FunctionTy)
        let isFunctionVarArg _FunctionTy =
            isFunctionVarArgNative ((_FunctionTy : TypeRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetReturnType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) getReturnTypeNative(
            void* (* LLVMTypeRef *) FunctionTy)
        let getReturnType _FunctionTy =
            new TypeRef (getReturnTypeNative ((_FunctionTy : TypeRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMCountParamTypes",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 countParamTypesNative(
            void* (* LLVMTypeRef *) FunctionTy)
        let countParamTypes _FunctionTy =
            countParamTypesNative ((_FunctionTy : TypeRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetParamTypes",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void getParamTypesNative(
            void* (* LLVMTypeRef *) FunctionTy,
            void* (* LLVMTypeRef* *) Dest)
        // I don't know how to generate an "F# friendly" version of LLVMGetParamTypes

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMStructTypeInContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) structTypeInContextNative(
            void* (* LLVMContextRef *) C,
            void* (* LLVMTypeRef* *) ElementTypes,
            uint32 ElementCount,
            bool Packed)
        // I don't know how to generate an "F# friendly" version of LLVMStructTypeInContext

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMStructType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) structTypeNative(
            void* (* LLVMTypeRef* *) ElementTypes,
            uint32 ElementCount,
            bool Packed)
        // I don't know how to generate an "F# friendly" version of LLVMStructType

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMStructCreateNamed",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) structCreateNamedNative(
            void* (* LLVMContextRef *) C,
            string Name)
        let structCreateNamed _C _Name =
            new TypeRef (structCreateNamedNative ((_C : ContextRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetStructName",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* const char* *) getStructNameNative(
            void* (* LLVMTypeRef *) Ty)
        let getStructName _Ty =
            Marshal.PtrToStringAuto (getStructNameNative ((_Ty : TypeRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMStructSetBody",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void structSetBodyNative(
            void* (* LLVMTypeRef *) StructTy,
            void* (* LLVMTypeRef* *) ElementTypes,
            uint32 ElementCount,
            bool Packed)
        // I don't know how to generate an "F# friendly" version of LLVMStructSetBody

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMCountStructElementTypes",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 countStructElementTypesNative(
            void* (* LLVMTypeRef *) StructTy)
        let countStructElementTypes _StructTy =
            countStructElementTypesNative ((_StructTy : TypeRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetStructElementTypes",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void getStructElementTypesNative(
            void* (* LLVMTypeRef *) StructTy,
            void* (* LLVMTypeRef* *) Dest)
        // I don't know how to generate an "F# friendly" version of LLVMGetStructElementTypes

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMIsPackedStruct",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool isPackedStructNative(
            void* (* LLVMTypeRef *) StructTy)
        let isPackedStruct _StructTy =
            isPackedStructNative ((_StructTy : TypeRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMIsOpaqueStruct",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool isOpaqueStructNative(
            void* (* LLVMTypeRef *) StructTy)
        let isOpaqueStruct _StructTy =
            isOpaqueStructNative ((_StructTy : TypeRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetElementType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) getElementTypeNative(
            void* (* LLVMTypeRef *) Ty)
        let getElementType _Ty =
            new TypeRef (getElementTypeNative ((_Ty : TypeRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMArrayType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) arrayTypeNative(
            void* (* LLVMTypeRef *) ElementType,
            uint32 ElementCount)
        let arrayType _ElementType _ElementCount =
            new TypeRef (arrayTypeNative ((_ElementType : TypeRef).Ptr, _ElementCount))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetArrayLength",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 getArrayLengthNative(
            void* (* LLVMTypeRef *) ArrayTy)
        let getArrayLength _ArrayTy =
            getArrayLengthNative ((_ArrayTy : TypeRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMPointerType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) pointerTypeNative(
            void* (* LLVMTypeRef *) ElementType,
            uint32 AddressSpace)
        let pointerType _ElementType _AddressSpace =
            new TypeRef (pointerTypeNative ((_ElementType : TypeRef).Ptr, _AddressSpace))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetPointerAddressSpace",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 getPointerAddressSpaceNative(
            void* (* LLVMTypeRef *) PointerTy)
        let getPointerAddressSpace _PointerTy =
            getPointerAddressSpaceNative ((_PointerTy : TypeRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMVectorType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) vectorTypeNative(
            void* (* LLVMTypeRef *) ElementType,
            uint32 ElementCount)
        let vectorType _ElementType _ElementCount =
            new TypeRef (vectorTypeNative ((_ElementType : TypeRef).Ptr, _ElementCount))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetVectorSize",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 getVectorSizeNative(
            void* (* LLVMTypeRef *) VectorTy)
        let getVectorSize _VectorTy =
            getVectorSizeNative ((_VectorTy : TypeRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMVoidTypeInContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) voidTypeInContextNative(
            void* (* LLVMContextRef *) C)
        let voidTypeInContext _C =
            new TypeRef (voidTypeInContextNative ((_C : ContextRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMLabelTypeInContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) labelTypeInContextNative(
            void* (* LLVMContextRef *) C)
        let labelTypeInContext _C =
            new TypeRef (labelTypeInContextNative ((_C : ContextRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMX86MMXTypeInContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) x86MMXTypeInContextNative(
            void* (* LLVMContextRef *) C)
        let x86MMXTypeInContext _C =
            new TypeRef (x86MMXTypeInContextNative ((_C : ContextRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMVoidType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) voidTypeNative()
        let voidType () =
            new TypeRef (voidTypeNative ())

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMLabelType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) labelTypeNative()
        let labelType () =
            new TypeRef (labelTypeNative ())

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMX86MMXType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) x86MMXTypeNative()
        let x86MMXType () =
            new TypeRef (x86MMXTypeNative ())

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMTypeOf",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) typeOfNative(
            void* (* LLVMValueRef *) Val)
        let typeOf _Val =
            new TypeRef (typeOfNative ((_Val : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetValueName",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* const char* *) getValueNameNative(
            void* (* LLVMValueRef *) Val)
        let getValueName _Val =
            Marshal.PtrToStringAuto (getValueNameNative ((_Val : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMSetValueName",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void setValueNameNative(
            void* (* LLVMValueRef *) Val,
            string Name)
        let setValueName _Val _Name =
            setValueNameNative ((_Val : ValueRef).Ptr, _Name)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMDumpValue",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void dumpValueNative(
            void* (* LLVMValueRef *) Val)
        let dumpValue _Val =
            dumpValueNative ((_Val : ValueRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMPrintValueToString",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* char* *) printValueToStringNative(
            void* (* LLVMValueRef *) Val)
        let printValueToString _Val =
            Marshal.PtrToStringAuto (printValueToStringNative ((_Val : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMReplaceAllUsesWith",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void replaceAllUsesWithNative(
            void* (* LLVMValueRef *) OldVal,
            void* (* LLVMValueRef *) NewVal)
        let replaceAllUsesWith _OldVal _NewVal =
            replaceAllUsesWithNative ((_OldVal : ValueRef).Ptr, (_NewVal : ValueRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMIsConstant",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool isConstantNative(
            void* (* LLVMValueRef *) Val)
        let isConstant _Val =
            isConstantNative ((_Val : ValueRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMIsUndef",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool isUndefNative(
            void* (* LLVMValueRef *) Val)
        let isUndef _Val =
            isUndefNative ((_Val : ValueRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMIsAMDNode",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) isAMDNodeNative(
            void* (* LLVMValueRef *) Val)
        let isAMDNode _Val =
            new ValueRef (isAMDNodeNative ((_Val : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMIsAMDString",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) isAMDStringNative(
            void* (* LLVMValueRef *) Val)
        let isAMDString _Val =
            new ValueRef (isAMDStringNative ((_Val : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetFirstUse",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMUseRef *) getFirstUseNative(
            void* (* LLVMValueRef *) Val)
        let getFirstUse _Val =
            new UseRef (getFirstUseNative ((_Val : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetNextUse",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMUseRef *) getNextUseNative(
            void* (* LLVMUseRef *) U)
        let getNextUse _U =
            new UseRef (getNextUseNative ((_U : UseRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetUser",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getUserNative(
            void* (* LLVMUseRef *) U)
        let getUser _U =
            new ValueRef (getUserNative ((_U : UseRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetUsedValue",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getUsedValueNative(
            void* (* LLVMUseRef *) U)
        let getUsedValue _U =
            new ValueRef (getUsedValueNative ((_U : UseRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetOperand",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getOperandNative(
            void* (* LLVMValueRef *) Val,
            uint32 Index)
        let getOperand _Val _Index =
            new ValueRef (getOperandNative ((_Val : ValueRef).Ptr, _Index))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetOperandUse",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMUseRef *) getOperandUseNative(
            void* (* LLVMValueRef *) Val,
            uint32 Index)
        let getOperandUse _Val _Index =
            new UseRef (getOperandUseNative ((_Val : ValueRef).Ptr, _Index))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMSetOperand",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void setOperandNative(
            void* (* LLVMValueRef *) User,
            uint32 Index,
            void* (* LLVMValueRef *) Val)
        let setOperand _User _Index _Val =
            setOperandNative ((_User : ValueRef).Ptr, _Index, (_Val : ValueRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetNumOperands",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int getNumOperandsNative(
            void* (* LLVMValueRef *) Val)
        let getNumOperands _Val =
            getNumOperandsNative ((_Val : ValueRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstNull",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constNullNative(
            void* (* LLVMTypeRef *) Ty)
        let constNull _Ty =
            new ValueRef (constNullNative ((_Ty : TypeRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstAllOnes",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constAllOnesNative(
            void* (* LLVMTypeRef *) Ty)
        let constAllOnes _Ty =
            new ValueRef (constAllOnesNative ((_Ty : TypeRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetUndef",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getUndefNative(
            void* (* LLVMTypeRef *) Ty)
        let getUndef _Ty =
            new ValueRef (getUndefNative ((_Ty : TypeRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMIsNull",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool isNullNative(
            void* (* LLVMValueRef *) Val)
        let isNull _Val =
            isNullNative ((_Val : ValueRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstPointerNull",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constPointerNullNative(
            void* (* LLVMTypeRef *) Ty)
        let constPointerNull _Ty =
            new ValueRef (constPointerNullNative ((_Ty : TypeRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstInt",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constIntNative(
            void* (* LLVMTypeRef *) IntTy,
            uint64 N,
            bool SignExtend)
        let constInt _IntTy _N _SignExtend =
            new ValueRef (constIntNative ((_IntTy : TypeRef).Ptr, _N, _SignExtend))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstIntOfArbitraryPrecision",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constIntOfArbitraryPrecisionNative(
            void* (* LLVMTypeRef *) IntTy,
            uint32 NumWords,
            uint64* Words)
        // I don't know how to generate an "F# friendly" version of LLVMConstIntOfArbitraryPrecision

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstIntOfString",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constIntOfStringNative(
            void* (* LLVMTypeRef *) IntTy,
            string Text,
            uint8 Radix)
        let constIntOfString _IntTy _Text _Radix =
            new ValueRef (constIntOfStringNative ((_IntTy : TypeRef).Ptr, _Text, _Radix))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstIntOfStringAndSize",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constIntOfStringAndSizeNative(
            void* (* LLVMTypeRef *) IntTy,
            string Text,
            uint32 SLen,
            uint8 Radix)
        let constIntOfStringAndSize _IntTy _Text _SLen _Radix =
            new ValueRef (constIntOfStringAndSizeNative ((_IntTy : TypeRef).Ptr, _Text, _SLen, _Radix))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstReal",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constRealNative(
            void* (* LLVMTypeRef *) RealTy,
            double N)
        let constReal _RealTy _N =
            new ValueRef (constRealNative ((_RealTy : TypeRef).Ptr, _N))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstRealOfString",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constRealOfStringNative(
            void* (* LLVMTypeRef *) RealTy,
            string Text)
        let constRealOfString _RealTy _Text =
            new ValueRef (constRealOfStringNative ((_RealTy : TypeRef).Ptr, _Text))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstRealOfStringAndSize",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constRealOfStringAndSizeNative(
            void* (* LLVMTypeRef *) RealTy,
            string Text,
            uint32 SLen)
        let constRealOfStringAndSize _RealTy _Text _SLen =
            new ValueRef (constRealOfStringAndSizeNative ((_RealTy : TypeRef).Ptr, _Text, _SLen))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstIntGetZExtValue",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint64 constIntGetZExtValueNative(
            void* (* LLVMValueRef *) ConstantVal)
        let constIntGetZExtValue _ConstantVal =
            constIntGetZExtValueNative ((_ConstantVal : ValueRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstIntGetSExtValue",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int64 constIntGetSExtValueNative(
            void* (* LLVMValueRef *) ConstantVal)
        let constIntGetSExtValue _ConstantVal =
            constIntGetSExtValueNative ((_ConstantVal : ValueRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstRealGetDouble",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern double constRealGetDoubleNative(
            void* (* LLVMValueRef *) ConstantVal,
            bool* losesInfo)
        // I don't know how to generate an "F# friendly" version of LLVMConstRealGetDouble

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstStringInContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constStringInContextNative(
            void* (* LLVMContextRef *) C,
            string Str,
            uint32 Length,
            bool DontNullTerminate)
        let constStringInContext _C _Str _Length _DontNullTerminate =
            new ValueRef (constStringInContextNative ((_C : ContextRef).Ptr, _Str, _Length, _DontNullTerminate))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstString",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constStringNative(
            string Str,
            uint32 Length,
            bool DontNullTerminate)
        let constString _Str _Length _DontNullTerminate =
            new ValueRef (constStringNative (_Str, _Length, _DontNullTerminate))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMIsConstantString",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool isConstantStringNative(
            void* (* LLVMValueRef *) c)
        let isConstantString _c =
            isConstantStringNative ((_c : ValueRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetAsString",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* const char* *) getAsStringNative(
            void* (* LLVMValueRef *) c,
            nativeint (* size_t *)* out)
        // I don't know how to generate an "F# friendly" version of LLVMGetAsString

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstStructInContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constStructInContextNative(
            void* (* LLVMContextRef *) C,
            void* (* LLVMValueRef* *) ConstantVals,
            uint32 Count,
            bool Packed)
        // I don't know how to generate an "F# friendly" version of LLVMConstStructInContext

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstStruct",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constStructNative(
            void* (* LLVMValueRef* *) ConstantVals,
            uint32 Count,
            bool Packed)
        // I don't know how to generate an "F# friendly" version of LLVMConstStruct

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstArray",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constArrayNative(
            void* (* LLVMTypeRef *) ElementTy,
            void* (* LLVMValueRef* *) ConstantVals,
            uint32 Length)
        // I don't know how to generate an "F# friendly" version of LLVMConstArray

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstNamedStruct",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constNamedStructNative(
            void* (* LLVMTypeRef *) StructTy,
            void* (* LLVMValueRef* *) ConstantVals,
            uint32 Count)
        // I don't know how to generate an "F# friendly" version of LLVMConstNamedStruct

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetElementAsConstant",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getElementAsConstantNative(
            void* (* LLVMValueRef *) c,
            uint32 idx)
        let getElementAsConstant _c _idx =
            new ValueRef (getElementAsConstantNative ((_c : ValueRef).Ptr, _idx))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstVector",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constVectorNative(
            void* (* LLVMValueRef* *) ScalarConstantVals,
            uint32 Size)
        // I don't know how to generate an "F# friendly" version of LLVMConstVector

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetConstOpcode",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int (* LLVMOpcode *) getConstOpcodeNative(
            void* (* LLVMValueRef *) ConstantVal)
        let getConstOpcode _ConstantVal =
            enum<Opcode> (getConstOpcodeNative ((_ConstantVal : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAlignOf",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) alignOfNative(
            void* (* LLVMTypeRef *) Ty)
        let alignOf _Ty =
            new ValueRef (alignOfNative ((_Ty : TypeRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMSizeOf",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) sizeOfNative(
            void* (* LLVMTypeRef *) Ty)
        let sizeOf _Ty =
            new ValueRef (sizeOfNative ((_Ty : TypeRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstNeg",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constNegNative(
            void* (* LLVMValueRef *) ConstantVal)
        let constNeg _ConstantVal =
            new ValueRef (constNegNative ((_ConstantVal : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstNSWNeg",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constNSWNegNative(
            void* (* LLVMValueRef *) ConstantVal)
        let constNSWNeg _ConstantVal =
            new ValueRef (constNSWNegNative ((_ConstantVal : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstNUWNeg",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constNUWNegNative(
            void* (* LLVMValueRef *) ConstantVal)
        let constNUWNeg _ConstantVal =
            new ValueRef (constNUWNegNative ((_ConstantVal : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstFNeg",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constFNegNative(
            void* (* LLVMValueRef *) ConstantVal)
        let constFNeg _ConstantVal =
            new ValueRef (constFNegNative ((_ConstantVal : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstNot",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constNotNative(
            void* (* LLVMValueRef *) ConstantVal)
        let constNot _ConstantVal =
            new ValueRef (constNotNative ((_ConstantVal : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstAdd",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constAddNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constAdd _LHSConstant _RHSConstant =
            new ValueRef (constAddNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstNSWAdd",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constNSWAddNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constNSWAdd _LHSConstant _RHSConstant =
            new ValueRef (constNSWAddNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstNUWAdd",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constNUWAddNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constNUWAdd _LHSConstant _RHSConstant =
            new ValueRef (constNUWAddNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstFAdd",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constFAddNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constFAdd _LHSConstant _RHSConstant =
            new ValueRef (constFAddNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstSub",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constSubNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constSub _LHSConstant _RHSConstant =
            new ValueRef (constSubNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstNSWSub",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constNSWSubNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constNSWSub _LHSConstant _RHSConstant =
            new ValueRef (constNSWSubNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstNUWSub",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constNUWSubNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constNUWSub _LHSConstant _RHSConstant =
            new ValueRef (constNUWSubNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstFSub",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constFSubNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constFSub _LHSConstant _RHSConstant =
            new ValueRef (constFSubNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstMul",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constMulNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constMul _LHSConstant _RHSConstant =
            new ValueRef (constMulNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstNSWMul",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constNSWMulNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constNSWMul _LHSConstant _RHSConstant =
            new ValueRef (constNSWMulNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstNUWMul",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constNUWMulNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constNUWMul _LHSConstant _RHSConstant =
            new ValueRef (constNUWMulNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstFMul",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constFMulNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constFMul _LHSConstant _RHSConstant =
            new ValueRef (constFMulNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstUDiv",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constUDivNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constUDiv _LHSConstant _RHSConstant =
            new ValueRef (constUDivNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstSDiv",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constSDivNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constSDiv _LHSConstant _RHSConstant =
            new ValueRef (constSDivNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstExactSDiv",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constExactSDivNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constExactSDiv _LHSConstant _RHSConstant =
            new ValueRef (constExactSDivNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstFDiv",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constFDivNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constFDiv _LHSConstant _RHSConstant =
            new ValueRef (constFDivNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstURem",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constURemNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constURem _LHSConstant _RHSConstant =
            new ValueRef (constURemNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstSRem",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constSRemNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constSRem _LHSConstant _RHSConstant =
            new ValueRef (constSRemNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstFRem",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constFRemNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constFRem _LHSConstant _RHSConstant =
            new ValueRef (constFRemNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstAnd",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constAndNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constAnd _LHSConstant _RHSConstant =
            new ValueRef (constAndNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstOr",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constOrNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constOr _LHSConstant _RHSConstant =
            new ValueRef (constOrNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstXor",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constXorNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constXor _LHSConstant _RHSConstant =
            new ValueRef (constXorNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstICmp",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constICmpNative(
            int (* LLVMIntPredicate *) Predicate,
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constICmp _Predicate _LHSConstant _RHSConstant =
            new ValueRef (constICmpNative ((int (_Predicate : IntPredicate)), (_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstFCmp",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constFCmpNative(
            int (* LLVMRealPredicate *) Predicate,
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constFCmp _Predicate _LHSConstant _RHSConstant =
            new ValueRef (constFCmpNative ((int (_Predicate : RealPredicate)), (_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstShl",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constShlNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constShl _LHSConstant _RHSConstant =
            new ValueRef (constShlNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstLShr",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constLShrNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constLShr _LHSConstant _RHSConstant =
            new ValueRef (constLShrNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstAShr",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constAShrNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constAShr _LHSConstant _RHSConstant =
            new ValueRef (constAShrNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstGEP",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constGEPNative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMValueRef* *) ConstantIndices,
            uint32 NumIndices)
        // I don't know how to generate an "F# friendly" version of LLVMConstGEP

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstInBoundsGEP",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constInBoundsGEPNative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMValueRef* *) ConstantIndices,
            uint32 NumIndices)
        // I don't know how to generate an "F# friendly" version of LLVMConstInBoundsGEP

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstTrunc",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constTruncNative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMTypeRef *) ToType)
        let constTrunc _ConstantVal _ToType =
            new ValueRef (constTruncNative ((_ConstantVal : ValueRef).Ptr, (_ToType : TypeRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstSExt",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constSExtNative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMTypeRef *) ToType)
        let constSExt _ConstantVal _ToType =
            new ValueRef (constSExtNative ((_ConstantVal : ValueRef).Ptr, (_ToType : TypeRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstZExt",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constZExtNative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMTypeRef *) ToType)
        let constZExt _ConstantVal _ToType =
            new ValueRef (constZExtNative ((_ConstantVal : ValueRef).Ptr, (_ToType : TypeRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstFPTrunc",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constFPTruncNative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMTypeRef *) ToType)
        let constFPTrunc _ConstantVal _ToType =
            new ValueRef (constFPTruncNative ((_ConstantVal : ValueRef).Ptr, (_ToType : TypeRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstFPExt",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constFPExtNative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMTypeRef *) ToType)
        let constFPExt _ConstantVal _ToType =
            new ValueRef (constFPExtNative ((_ConstantVal : ValueRef).Ptr, (_ToType : TypeRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstUIToFP",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constUIToFPNative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMTypeRef *) ToType)
        let constUIToFP _ConstantVal _ToType =
            new ValueRef (constUIToFPNative ((_ConstantVal : ValueRef).Ptr, (_ToType : TypeRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstSIToFP",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constSIToFPNative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMTypeRef *) ToType)
        let constSIToFP _ConstantVal _ToType =
            new ValueRef (constSIToFPNative ((_ConstantVal : ValueRef).Ptr, (_ToType : TypeRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstFPToUI",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constFPToUINative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMTypeRef *) ToType)
        let constFPToUI _ConstantVal _ToType =
            new ValueRef (constFPToUINative ((_ConstantVal : ValueRef).Ptr, (_ToType : TypeRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstFPToSI",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constFPToSINative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMTypeRef *) ToType)
        let constFPToSI _ConstantVal _ToType =
            new ValueRef (constFPToSINative ((_ConstantVal : ValueRef).Ptr, (_ToType : TypeRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstPtrToInt",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constPtrToIntNative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMTypeRef *) ToType)
        let constPtrToInt _ConstantVal _ToType =
            new ValueRef (constPtrToIntNative ((_ConstantVal : ValueRef).Ptr, (_ToType : TypeRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstIntToPtr",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constIntToPtrNative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMTypeRef *) ToType)
        let constIntToPtr _ConstantVal _ToType =
            new ValueRef (constIntToPtrNative ((_ConstantVal : ValueRef).Ptr, (_ToType : TypeRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstBitCast",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constBitCastNative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMTypeRef *) ToType)
        let constBitCast _ConstantVal _ToType =
            new ValueRef (constBitCastNative ((_ConstantVal : ValueRef).Ptr, (_ToType : TypeRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstAddrSpaceCast",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constAddrSpaceCastNative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMTypeRef *) ToType)
        let constAddrSpaceCast _ConstantVal _ToType =
            new ValueRef (constAddrSpaceCastNative ((_ConstantVal : ValueRef).Ptr, (_ToType : TypeRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstZExtOrBitCast",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constZExtOrBitCastNative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMTypeRef *) ToType)
        let constZExtOrBitCast _ConstantVal _ToType =
            new ValueRef (constZExtOrBitCastNative ((_ConstantVal : ValueRef).Ptr, (_ToType : TypeRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstSExtOrBitCast",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constSExtOrBitCastNative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMTypeRef *) ToType)
        let constSExtOrBitCast _ConstantVal _ToType =
            new ValueRef (constSExtOrBitCastNative ((_ConstantVal : ValueRef).Ptr, (_ToType : TypeRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstTruncOrBitCast",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constTruncOrBitCastNative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMTypeRef *) ToType)
        let constTruncOrBitCast _ConstantVal _ToType =
            new ValueRef (constTruncOrBitCastNative ((_ConstantVal : ValueRef).Ptr, (_ToType : TypeRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstPointerCast",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constPointerCastNative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMTypeRef *) ToType)
        let constPointerCast _ConstantVal _ToType =
            new ValueRef (constPointerCastNative ((_ConstantVal : ValueRef).Ptr, (_ToType : TypeRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstIntCast",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constIntCastNative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMTypeRef *) ToType,
            bool isSigned)
        let constIntCast _ConstantVal _ToType _isSigned =
            new ValueRef (constIntCastNative ((_ConstantVal : ValueRef).Ptr, (_ToType : TypeRef).Ptr, _isSigned))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstFPCast",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constFPCastNative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMTypeRef *) ToType)
        let constFPCast _ConstantVal _ToType =
            new ValueRef (constFPCastNative ((_ConstantVal : ValueRef).Ptr, (_ToType : TypeRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstSelect",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constSelectNative(
            void* (* LLVMValueRef *) ConstantCondition,
            void* (* LLVMValueRef *) ConstantIfTrue,
            void* (* LLVMValueRef *) ConstantIfFalse)
        let constSelect _ConstantCondition _ConstantIfTrue _ConstantIfFalse =
            new ValueRef (constSelectNative ((_ConstantCondition : ValueRef).Ptr, (_ConstantIfTrue : ValueRef).Ptr, (_ConstantIfFalse : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstExtractElement",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constExtractElementNative(
            void* (* LLVMValueRef *) VectorConstant,
            void* (* LLVMValueRef *) IndexConstant)
        let constExtractElement _VectorConstant _IndexConstant =
            new ValueRef (constExtractElementNative ((_VectorConstant : ValueRef).Ptr, (_IndexConstant : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstInsertElement",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constInsertElementNative(
            void* (* LLVMValueRef *) VectorConstant,
            void* (* LLVMValueRef *) ElementValueConstant,
            void* (* LLVMValueRef *) IndexConstant)
        let constInsertElement _VectorConstant _ElementValueConstant _IndexConstant =
            new ValueRef (constInsertElementNative ((_VectorConstant : ValueRef).Ptr, (_ElementValueConstant : ValueRef).Ptr, (_IndexConstant : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstShuffleVector",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constShuffleVectorNative(
            void* (* LLVMValueRef *) VectorAConstant,
            void* (* LLVMValueRef *) VectorBConstant,
            void* (* LLVMValueRef *) MaskConstant)
        let constShuffleVector _VectorAConstant _VectorBConstant _MaskConstant =
            new ValueRef (constShuffleVectorNative ((_VectorAConstant : ValueRef).Ptr, (_VectorBConstant : ValueRef).Ptr, (_MaskConstant : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstExtractValue",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constExtractValueNative(
            void* (* LLVMValueRef *) AggConstant,
            uint32* IdxList,
            uint32 NumIdx)
        // I don't know how to generate an "F# friendly" version of LLVMConstExtractValue

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstInsertValue",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constInsertValueNative(
            void* (* LLVMValueRef *) AggConstant,
            void* (* LLVMValueRef *) ElementValueConstant,
            uint32* IdxList,
            uint32 NumIdx)
        // I don't know how to generate an "F# friendly" version of LLVMConstInsertValue

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMConstInlineAsm",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constInlineAsmNative(
            void* (* LLVMTypeRef *) Ty,
            string AsmString,
            string Constraints,
            bool HasSideEffects,
            bool IsAlignStack)
        let constInlineAsm _Ty _AsmString _Constraints _HasSideEffects _IsAlignStack =
            new ValueRef (constInlineAsmNative ((_Ty : TypeRef).Ptr, _AsmString, _Constraints, _HasSideEffects, _IsAlignStack))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBlockAddress",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) blockAddressNative(
            void* (* LLVMValueRef *) F,
            void* (* LLVMBasicBlockRef *) BB)
        let blockAddress _F _BB =
            new ValueRef (blockAddressNative ((_F : ValueRef).Ptr, (_BB : BasicBlockRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetGlobalParent",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMModuleRef *) getGlobalParentNative(
            void* (* LLVMValueRef *) Global)
        let getGlobalParent _Global =
            new ModuleRef (getGlobalParentNative ((_Global : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMIsDeclaration",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool isDeclarationNative(
            void* (* LLVMValueRef *) Global)
        let isDeclaration _Global =
            isDeclarationNative ((_Global : ValueRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetLinkage",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int (* LLVMLinkage *) getLinkageNative(
            void* (* LLVMValueRef *) Global)
        let getLinkage _Global =
            enum<Linkage> (getLinkageNative ((_Global : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMSetLinkage",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void setLinkageNative(
            void* (* LLVMValueRef *) Global,
            int (* LLVMLinkage *) Linkage)
        let setLinkage _Global _Linkage =
            setLinkageNative ((_Global : ValueRef).Ptr, (int (_Linkage : Linkage)))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetSection",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* const char* *) getSectionNative(
            void* (* LLVMValueRef *) Global)
        let getSection _Global =
            Marshal.PtrToStringAuto (getSectionNative ((_Global : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMSetSection",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void setSectionNative(
            void* (* LLVMValueRef *) Global,
            string Section)
        let setSection _Global _Section =
            setSectionNative ((_Global : ValueRef).Ptr, _Section)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetVisibility",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int (* LLVMVisibility *) getVisibilityNative(
            void* (* LLVMValueRef *) Global)
        let getVisibility _Global =
            enum<Visibility> (getVisibilityNative ((_Global : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMSetVisibility",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void setVisibilityNative(
            void* (* LLVMValueRef *) Global,
            int (* LLVMVisibility *) Viz)
        let setVisibility _Global _Viz =
            setVisibilityNative ((_Global : ValueRef).Ptr, (int (_Viz : Visibility)))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetDLLStorageClass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int (* LLVMDLLStorageClass *) getDLLStorageClassNative(
            void* (* LLVMValueRef *) Global)
        let getDLLStorageClass _Global =
            enum<DLLStorageClass> (getDLLStorageClassNative ((_Global : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMSetDLLStorageClass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void setDLLStorageClassNative(
            void* (* LLVMValueRef *) Global,
            int (* LLVMDLLStorageClass *) Class)
        let setDLLStorageClass _Global _Class =
            setDLLStorageClassNative ((_Global : ValueRef).Ptr, (int (_Class : DLLStorageClass)))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMHasUnnamedAddr",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool hasUnnamedAddrNative(
            void* (* LLVMValueRef *) Global)
        let hasUnnamedAddr _Global =
            hasUnnamedAddrNative ((_Global : ValueRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMSetUnnamedAddr",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void setUnnamedAddrNative(
            void* (* LLVMValueRef *) Global,
            bool HasUnnamedAddr)
        let setUnnamedAddr _Global _HasUnnamedAddr =
            setUnnamedAddrNative ((_Global : ValueRef).Ptr, _HasUnnamedAddr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetAlignment",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 getAlignmentNative(
            void* (* LLVMValueRef *) V)
        let getAlignment _V =
            getAlignmentNative ((_V : ValueRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMSetAlignment",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void setAlignmentNative(
            void* (* LLVMValueRef *) V,
            uint32 Bytes)
        let setAlignment _V _Bytes =
            setAlignmentNative ((_V : ValueRef).Ptr, _Bytes)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddGlobal",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) addGlobalNative(
            void* (* LLVMModuleRef *) M,
            void* (* LLVMTypeRef *) Ty,
            string Name)
        let addGlobal _M _Ty _Name =
            new ValueRef (addGlobalNative ((_M : ModuleRef).Ptr, (_Ty : TypeRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddGlobalInAddressSpace",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) addGlobalInAddressSpaceNative(
            void* (* LLVMModuleRef *) M,
            void* (* LLVMTypeRef *) Ty,
            string Name,
            uint32 AddressSpace)
        let addGlobalInAddressSpace _M _Ty _Name _AddressSpace =
            new ValueRef (addGlobalInAddressSpaceNative ((_M : ModuleRef).Ptr, (_Ty : TypeRef).Ptr, _Name, _AddressSpace))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetNamedGlobal",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getNamedGlobalNative(
            void* (* LLVMModuleRef *) M,
            string Name)
        let getNamedGlobal _M _Name =
            new ValueRef (getNamedGlobalNative ((_M : ModuleRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetFirstGlobal",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getFirstGlobalNative(
            void* (* LLVMModuleRef *) M)
        let getFirstGlobal _M =
            new ValueRef (getFirstGlobalNative ((_M : ModuleRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetLastGlobal",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getLastGlobalNative(
            void* (* LLVMModuleRef *) M)
        let getLastGlobal _M =
            new ValueRef (getLastGlobalNative ((_M : ModuleRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetNextGlobal",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getNextGlobalNative(
            void* (* LLVMValueRef *) GlobalVar)
        let getNextGlobal _GlobalVar =
            new ValueRef (getNextGlobalNative ((_GlobalVar : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetPreviousGlobal",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getPreviousGlobalNative(
            void* (* LLVMValueRef *) GlobalVar)
        let getPreviousGlobal _GlobalVar =
            new ValueRef (getPreviousGlobalNative ((_GlobalVar : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMDeleteGlobal",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void deleteGlobalNative(
            void* (* LLVMValueRef *) GlobalVar)
        let deleteGlobal _GlobalVar =
            deleteGlobalNative ((_GlobalVar : ValueRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetInitializer",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getInitializerNative(
            void* (* LLVMValueRef *) GlobalVar)
        let getInitializer _GlobalVar =
            new ValueRef (getInitializerNative ((_GlobalVar : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMSetInitializer",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void setInitializerNative(
            void* (* LLVMValueRef *) GlobalVar,
            void* (* LLVMValueRef *) ConstantVal)
        let setInitializer _GlobalVar _ConstantVal =
            setInitializerNative ((_GlobalVar : ValueRef).Ptr, (_ConstantVal : ValueRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMIsThreadLocal",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool isThreadLocalNative(
            void* (* LLVMValueRef *) GlobalVar)
        let isThreadLocal _GlobalVar =
            isThreadLocalNative ((_GlobalVar : ValueRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMSetThreadLocal",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void setThreadLocalNative(
            void* (* LLVMValueRef *) GlobalVar,
            bool IsThreadLocal)
        let setThreadLocal _GlobalVar _IsThreadLocal =
            setThreadLocalNative ((_GlobalVar : ValueRef).Ptr, _IsThreadLocal)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMIsGlobalConstant",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool isGlobalConstantNative(
            void* (* LLVMValueRef *) GlobalVar)
        let isGlobalConstant _GlobalVar =
            isGlobalConstantNative ((_GlobalVar : ValueRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMSetGlobalConstant",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void setGlobalConstantNative(
            void* (* LLVMValueRef *) GlobalVar,
            bool IsConstant)
        let setGlobalConstant _GlobalVar _IsConstant =
            setGlobalConstantNative ((_GlobalVar : ValueRef).Ptr, _IsConstant)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetThreadLocalMode",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int (* LLVMThreadLocalMode *) getThreadLocalModeNative(
            void* (* LLVMValueRef *) GlobalVar)
        let getThreadLocalMode _GlobalVar =
            enum<ThreadLocalMode> (getThreadLocalModeNative ((_GlobalVar : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMSetThreadLocalMode",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void setThreadLocalModeNative(
            void* (* LLVMValueRef *) GlobalVar,
            int (* LLVMThreadLocalMode *) Mode)
        let setThreadLocalMode _GlobalVar _Mode =
            setThreadLocalModeNative ((_GlobalVar : ValueRef).Ptr, (int (_Mode : ThreadLocalMode)))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMIsExternallyInitialized",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool isExternallyInitializedNative(
            void* (* LLVMValueRef *) GlobalVar)
        let isExternallyInitialized _GlobalVar =
            isExternallyInitializedNative ((_GlobalVar : ValueRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMSetExternallyInitialized",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void setExternallyInitializedNative(
            void* (* LLVMValueRef *) GlobalVar,
            bool IsExtInit)
        let setExternallyInitialized _GlobalVar _IsExtInit =
            setExternallyInitializedNative ((_GlobalVar : ValueRef).Ptr, _IsExtInit)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddAlias",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) addAliasNative(
            void* (* LLVMModuleRef *) M,
            void* (* LLVMTypeRef *) Ty,
            void* (* LLVMValueRef *) Aliasee,
            string Name)
        let addAlias _M _Ty _Aliasee _Name =
            new ValueRef (addAliasNative ((_M : ModuleRef).Ptr, (_Ty : TypeRef).Ptr, (_Aliasee : ValueRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMDeleteFunction",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void deleteFunctionNative(
            void* (* LLVMValueRef *) Fn)
        let deleteFunction _Fn =
            deleteFunctionNative ((_Fn : ValueRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetIntrinsicID",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 getIntrinsicIDNative(
            void* (* LLVMValueRef *) Fn)
        let getIntrinsicID _Fn =
            getIntrinsicIDNative ((_Fn : ValueRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetFunctionCallConv",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 getFunctionCallConvNative(
            void* (* LLVMValueRef *) Fn)
        let getFunctionCallConv _Fn =
            getFunctionCallConvNative ((_Fn : ValueRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMSetFunctionCallConv",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void setFunctionCallConvNative(
            void* (* LLVMValueRef *) Fn,
            uint32 CC)
        let setFunctionCallConv _Fn _CC =
            setFunctionCallConvNative ((_Fn : ValueRef).Ptr, _CC)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetGC",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* const char* *) getGCNative(
            void* (* LLVMValueRef *) Fn)
        let getGC _Fn =
            Marshal.PtrToStringAuto (getGCNative ((_Fn : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMSetGC",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void setGCNative(
            void* (* LLVMValueRef *) Fn,
            string Name)
        let setGC _Fn _Name =
            setGCNative ((_Fn : ValueRef).Ptr, _Name)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddFunctionAttr",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addFunctionAttrNative(
            void* (* LLVMValueRef *) Fn,
            int (* LLVMAttribute *) PA)
        let addFunctionAttr _Fn _PA =
            addFunctionAttrNative ((_Fn : ValueRef).Ptr, (int (_PA : Attribute)))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddTargetDependentFunctionAttr",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addTargetDependentFunctionAttrNative(
            void* (* LLVMValueRef *) Fn,
            string A,
            string V)
        let addTargetDependentFunctionAttr _Fn _A _V =
            addTargetDependentFunctionAttrNative ((_Fn : ValueRef).Ptr, _A, _V)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetFunctionAttr",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int (* LLVMAttribute *) getFunctionAttrNative(
            void* (* LLVMValueRef *) Fn)
        let getFunctionAttr _Fn =
            enum<Attribute> (getFunctionAttrNative ((_Fn : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMRemoveFunctionAttr",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void removeFunctionAttrNative(
            void* (* LLVMValueRef *) Fn,
            int (* LLVMAttribute *) PA)
        let removeFunctionAttr _Fn _PA =
            removeFunctionAttrNative ((_Fn : ValueRef).Ptr, (int (_PA : Attribute)))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMCountParams",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 countParamsNative(
            void* (* LLVMValueRef *) Fn)
        let countParams _Fn =
            countParamsNative ((_Fn : ValueRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetParams",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void getParamsNative(
            void* (* LLVMValueRef *) Fn,
            void* (* LLVMValueRef* *) Params)
        // I don't know how to generate an "F# friendly" version of LLVMGetParams

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetParam",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getParamNative(
            void* (* LLVMValueRef *) Fn,
            uint32 Index)
        let getParam _Fn _Index =
            new ValueRef (getParamNative ((_Fn : ValueRef).Ptr, _Index))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetParamParent",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getParamParentNative(
            void* (* LLVMValueRef *) Inst)
        let getParamParent _Inst =
            new ValueRef (getParamParentNative ((_Inst : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetFirstParam",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getFirstParamNative(
            void* (* LLVMValueRef *) Fn)
        let getFirstParam _Fn =
            new ValueRef (getFirstParamNative ((_Fn : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetLastParam",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getLastParamNative(
            void* (* LLVMValueRef *) Fn)
        let getLastParam _Fn =
            new ValueRef (getLastParamNative ((_Fn : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetNextParam",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getNextParamNative(
            void* (* LLVMValueRef *) Arg)
        let getNextParam _Arg =
            new ValueRef (getNextParamNative ((_Arg : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetPreviousParam",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getPreviousParamNative(
            void* (* LLVMValueRef *) Arg)
        let getPreviousParam _Arg =
            new ValueRef (getPreviousParamNative ((_Arg : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddAttribute",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addAttributeNative(
            void* (* LLVMValueRef *) Arg,
            int (* LLVMAttribute *) PA)
        let addAttribute _Arg _PA =
            addAttributeNative ((_Arg : ValueRef).Ptr, (int (_PA : Attribute)))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMRemoveAttribute",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void removeAttributeNative(
            void* (* LLVMValueRef *) Arg,
            int (* LLVMAttribute *) PA)
        let removeAttribute _Arg _PA =
            removeAttributeNative ((_Arg : ValueRef).Ptr, (int (_PA : Attribute)))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetAttribute",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int (* LLVMAttribute *) getAttributeNative(
            void* (* LLVMValueRef *) Arg)
        let getAttribute _Arg =
            enum<Attribute> (getAttributeNative ((_Arg : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMSetParamAlignment",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void setParamAlignmentNative(
            void* (* LLVMValueRef *) Arg,
            uint32 align)
        let setParamAlignment _Arg _align =
            setParamAlignmentNative ((_Arg : ValueRef).Ptr, _align)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMMDStringInContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) mDStringInContextNative(
            void* (* LLVMContextRef *) C,
            string Str,
            uint32 SLen)
        let mDStringInContext _C _Str _SLen =
            new ValueRef (mDStringInContextNative ((_C : ContextRef).Ptr, _Str, _SLen))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMMDString",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) mDStringNative(
            string Str,
            uint32 SLen)
        let mDString _Str _SLen =
            new ValueRef (mDStringNative (_Str, _SLen))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMMDNodeInContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) mDNodeInContextNative(
            void* (* LLVMContextRef *) C,
            void* (* LLVMValueRef* *) Vals,
            uint32 Count)
        // I don't know how to generate an "F# friendly" version of LLVMMDNodeInContext

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMMDNode",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) mDNodeNative(
            void* (* LLVMValueRef* *) Vals,
            uint32 Count)
        // I don't know how to generate an "F# friendly" version of LLVMMDNode

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetMDString",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* const char* *) getMDStringNative(
            void* (* LLVMValueRef *) V,
            uint32* Len)
        // I don't know how to generate an "F# friendly" version of LLVMGetMDString

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetMDNodeNumOperands",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 getMDNodeNumOperandsNative(
            void* (* LLVMValueRef *) V)
        let getMDNodeNumOperands _V =
            getMDNodeNumOperandsNative ((_V : ValueRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetMDNodeOperands",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void getMDNodeOperandsNative(
            void* (* LLVMValueRef *) V,
            void* (* LLVMValueRef* *) Dest)
        // I don't know how to generate an "F# friendly" version of LLVMGetMDNodeOperands

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBasicBlockAsValue",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) basicBlockAsValueNative(
            void* (* LLVMBasicBlockRef *) BB)
        let basicBlockAsValue _BB =
            new ValueRef (basicBlockAsValueNative ((_BB : BasicBlockRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMValueIsBasicBlock",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool valueIsBasicBlockNative(
            void* (* LLVMValueRef *) Val)
        let valueIsBasicBlock _Val =
            valueIsBasicBlockNative ((_Val : ValueRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMValueAsBasicBlock",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMBasicBlockRef *) valueAsBasicBlockNative(
            void* (* LLVMValueRef *) Val)
        let valueAsBasicBlock _Val =
            new BasicBlockRef (valueAsBasicBlockNative ((_Val : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetBasicBlockParent",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getBasicBlockParentNative(
            void* (* LLVMBasicBlockRef *) BB)
        let getBasicBlockParent _BB =
            new ValueRef (getBasicBlockParentNative ((_BB : BasicBlockRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetBasicBlockTerminator",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getBasicBlockTerminatorNative(
            void* (* LLVMBasicBlockRef *) BB)
        let getBasicBlockTerminator _BB =
            new ValueRef (getBasicBlockTerminatorNative ((_BB : BasicBlockRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMCountBasicBlocks",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 countBasicBlocksNative(
            void* (* LLVMValueRef *) Fn)
        let countBasicBlocks _Fn =
            countBasicBlocksNative ((_Fn : ValueRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetBasicBlocks",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void getBasicBlocksNative(
            void* (* LLVMValueRef *) Fn,
            void* (* LLVMBasicBlockRef* *) BasicBlocks)
        // I don't know how to generate an "F# friendly" version of LLVMGetBasicBlocks

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetFirstBasicBlock",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMBasicBlockRef *) getFirstBasicBlockNative(
            void* (* LLVMValueRef *) Fn)
        let getFirstBasicBlock _Fn =
            new BasicBlockRef (getFirstBasicBlockNative ((_Fn : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetLastBasicBlock",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMBasicBlockRef *) getLastBasicBlockNative(
            void* (* LLVMValueRef *) Fn)
        let getLastBasicBlock _Fn =
            new BasicBlockRef (getLastBasicBlockNative ((_Fn : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetNextBasicBlock",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMBasicBlockRef *) getNextBasicBlockNative(
            void* (* LLVMBasicBlockRef *) BB)
        let getNextBasicBlock _BB =
            new BasicBlockRef (getNextBasicBlockNative ((_BB : BasicBlockRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetPreviousBasicBlock",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMBasicBlockRef *) getPreviousBasicBlockNative(
            void* (* LLVMBasicBlockRef *) BB)
        let getPreviousBasicBlock _BB =
            new BasicBlockRef (getPreviousBasicBlockNative ((_BB : BasicBlockRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetEntryBasicBlock",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMBasicBlockRef *) getEntryBasicBlockNative(
            void* (* LLVMValueRef *) Fn)
        let getEntryBasicBlock _Fn =
            new BasicBlockRef (getEntryBasicBlockNative ((_Fn : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAppendBasicBlockInContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMBasicBlockRef *) appendBasicBlockInContextNative(
            void* (* LLVMContextRef *) C,
            void* (* LLVMValueRef *) Fn,
            string Name)
        let appendBasicBlockInContext _C _Fn _Name =
            new BasicBlockRef (appendBasicBlockInContextNative ((_C : ContextRef).Ptr, (_Fn : ValueRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAppendBasicBlock",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMBasicBlockRef *) appendBasicBlockNative(
            void* (* LLVMValueRef *) Fn,
            string Name)
        let appendBasicBlock _Fn _Name =
            new BasicBlockRef (appendBasicBlockNative ((_Fn : ValueRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMInsertBasicBlockInContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMBasicBlockRef *) insertBasicBlockInContextNative(
            void* (* LLVMContextRef *) C,
            void* (* LLVMBasicBlockRef *) BB,
            string Name)
        let insertBasicBlockInContext _C _BB _Name =
            new BasicBlockRef (insertBasicBlockInContextNative ((_C : ContextRef).Ptr, (_BB : BasicBlockRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMInsertBasicBlock",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMBasicBlockRef *) insertBasicBlockNative(
            void* (* LLVMBasicBlockRef *) InsertBeforeBB,
            string Name)
        let insertBasicBlock _InsertBeforeBB _Name =
            new BasicBlockRef (insertBasicBlockNative ((_InsertBeforeBB : BasicBlockRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMDeleteBasicBlock",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void deleteBasicBlockNative(
            void* (* LLVMBasicBlockRef *) BB)
        let deleteBasicBlock _BB =
            deleteBasicBlockNative ((_BB : BasicBlockRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMRemoveBasicBlockFromParent",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void removeBasicBlockFromParentNative(
            void* (* LLVMBasicBlockRef *) BB)
        let removeBasicBlockFromParent _BB =
            removeBasicBlockFromParentNative ((_BB : BasicBlockRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMMoveBasicBlockBefore",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void moveBasicBlockBeforeNative(
            void* (* LLVMBasicBlockRef *) BB,
            void* (* LLVMBasicBlockRef *) MovePos)
        let moveBasicBlockBefore _BB _MovePos =
            moveBasicBlockBeforeNative ((_BB : BasicBlockRef).Ptr, (_MovePos : BasicBlockRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMMoveBasicBlockAfter",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void moveBasicBlockAfterNative(
            void* (* LLVMBasicBlockRef *) BB,
            void* (* LLVMBasicBlockRef *) MovePos)
        let moveBasicBlockAfter _BB _MovePos =
            moveBasicBlockAfterNative ((_BB : BasicBlockRef).Ptr, (_MovePos : BasicBlockRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetFirstInstruction",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getFirstInstructionNative(
            void* (* LLVMBasicBlockRef *) BB)
        let getFirstInstruction _BB =
            new ValueRef (getFirstInstructionNative ((_BB : BasicBlockRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetLastInstruction",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getLastInstructionNative(
            void* (* LLVMBasicBlockRef *) BB)
        let getLastInstruction _BB =
            new ValueRef (getLastInstructionNative ((_BB : BasicBlockRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMHasMetadata",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int hasMetadataNative(
            void* (* LLVMValueRef *) Val)
        let hasMetadata _Val =
            hasMetadataNative ((_Val : ValueRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetMetadata",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getMetadataNative(
            void* (* LLVMValueRef *) Val,
            uint32 KindID)
        let getMetadata _Val _KindID =
            new ValueRef (getMetadataNative ((_Val : ValueRef).Ptr, _KindID))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMSetMetadata",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void setMetadataNative(
            void* (* LLVMValueRef *) Val,
            uint32 KindID,
            void* (* LLVMValueRef *) Node)
        let setMetadata _Val _KindID _Node =
            setMetadataNative ((_Val : ValueRef).Ptr, _KindID, (_Node : ValueRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetInstructionParent",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMBasicBlockRef *) getInstructionParentNative(
            void* (* LLVMValueRef *) Inst)
        let getInstructionParent _Inst =
            new BasicBlockRef (getInstructionParentNative ((_Inst : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetNextInstruction",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getNextInstructionNative(
            void* (* LLVMValueRef *) Inst)
        let getNextInstruction _Inst =
            new ValueRef (getNextInstructionNative ((_Inst : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetPreviousInstruction",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getPreviousInstructionNative(
            void* (* LLVMValueRef *) Inst)
        let getPreviousInstruction _Inst =
            new ValueRef (getPreviousInstructionNative ((_Inst : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMInstructionEraseFromParent",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void instructionEraseFromParentNative(
            void* (* LLVMValueRef *) Inst)
        let instructionEraseFromParent _Inst =
            instructionEraseFromParentNative ((_Inst : ValueRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetInstructionOpcode",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int (* LLVMOpcode *) getInstructionOpcodeNative(
            void* (* LLVMValueRef *) Inst)
        let getInstructionOpcode _Inst =
            enum<Opcode> (getInstructionOpcodeNative ((_Inst : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetICmpPredicate",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int (* LLVMIntPredicate *) getICmpPredicateNative(
            void* (* LLVMValueRef *) Inst)
        let getICmpPredicate _Inst =
            enum<IntPredicate> (getICmpPredicateNative ((_Inst : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetFCmpPredicate",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int (* LLVMRealPredicate *) getFCmpPredicateNative(
            void* (* LLVMValueRef *) Inst)
        let getFCmpPredicate _Inst =
            enum<RealPredicate> (getFCmpPredicateNative ((_Inst : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMInstructionClone",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) instructionCloneNative(
            void* (* LLVMValueRef *) Inst)
        let instructionClone _Inst =
            new ValueRef (instructionCloneNative ((_Inst : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMSetInstructionCallConv",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void setInstructionCallConvNative(
            void* (* LLVMValueRef *) Instr,
            uint32 CC)
        let setInstructionCallConv _Instr _CC =
            setInstructionCallConvNative ((_Instr : ValueRef).Ptr, _CC)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetInstructionCallConv",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 getInstructionCallConvNative(
            void* (* LLVMValueRef *) Instr)
        let getInstructionCallConv _Instr =
            getInstructionCallConvNative ((_Instr : ValueRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddInstrAttribute",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addInstrAttributeNative(
            void* (* LLVMValueRef *) Instr,
            uint32 index,
            int (* LLVMAttribute *) arg2)
        let addInstrAttribute _Instr _index _arg2 =
            addInstrAttributeNative ((_Instr : ValueRef).Ptr, _index, (int (_arg2 : Attribute)))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMRemoveInstrAttribute",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void removeInstrAttributeNative(
            void* (* LLVMValueRef *) Instr,
            uint32 index,
            int (* LLVMAttribute *) arg2)
        let removeInstrAttribute _Instr _index _arg2 =
            removeInstrAttributeNative ((_Instr : ValueRef).Ptr, _index, (int (_arg2 : Attribute)))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMSetInstrParamAlignment",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void setInstrParamAlignmentNative(
            void* (* LLVMValueRef *) Instr,
            uint32 index,
            uint32 align)
        let setInstrParamAlignment _Instr _index _align =
            setInstrParamAlignmentNative ((_Instr : ValueRef).Ptr, _index, _align)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMIsTailCall",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool isTailCallNative(
            void* (* LLVMValueRef *) CallInst)
        let isTailCall _CallInst =
            isTailCallNative ((_CallInst : ValueRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMSetTailCall",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void setTailCallNative(
            void* (* LLVMValueRef *) CallInst,
            bool IsTailCall)
        let setTailCall _CallInst _IsTailCall =
            setTailCallNative ((_CallInst : ValueRef).Ptr, _IsTailCall)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetNumSuccessors",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 getNumSuccessorsNative(
            void* (* LLVMValueRef *) Term)
        let getNumSuccessors _Term =
            getNumSuccessorsNative ((_Term : ValueRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetSuccessor",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMBasicBlockRef *) getSuccessorNative(
            void* (* LLVMValueRef *) Term,
            uint32 i)
        let getSuccessor _Term _i =
            new BasicBlockRef (getSuccessorNative ((_Term : ValueRef).Ptr, _i))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMSetSuccessor",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void setSuccessorNative(
            void* (* LLVMValueRef *) Term,
            uint32 i,
            void* (* LLVMBasicBlockRef *) block)
        let setSuccessor _Term _i _block =
            setSuccessorNative ((_Term : ValueRef).Ptr, _i, (_block : BasicBlockRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMIsConditional",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool isConditionalNative(
            void* (* LLVMValueRef *) Branch)
        let isConditional _Branch =
            isConditionalNative ((_Branch : ValueRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetCondition",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getConditionNative(
            void* (* LLVMValueRef *) Branch)
        let getCondition _Branch =
            new ValueRef (getConditionNative ((_Branch : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMSetCondition",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void setConditionNative(
            void* (* LLVMValueRef *) Branch,
            void* (* LLVMValueRef *) Cond)
        let setCondition _Branch _Cond =
            setConditionNative ((_Branch : ValueRef).Ptr, (_Cond : ValueRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetSwitchDefaultDest",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMBasicBlockRef *) getSwitchDefaultDestNative(
            void* (* LLVMValueRef *) SwitchInstr)
        let getSwitchDefaultDest _SwitchInstr =
            new BasicBlockRef (getSwitchDefaultDestNative ((_SwitchInstr : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddIncoming",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addIncomingNative(
            void* (* LLVMValueRef *) PhiNode,
            void* (* LLVMValueRef* *) IncomingValues,
            void* (* LLVMBasicBlockRef* *) IncomingBlocks,
            uint32 Count)
        // I don't know how to generate an "F# friendly" version of LLVMAddIncoming

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMCountIncoming",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 countIncomingNative(
            void* (* LLVMValueRef *) PhiNode)
        let countIncoming _PhiNode =
            countIncomingNative ((_PhiNode : ValueRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetIncomingValue",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getIncomingValueNative(
            void* (* LLVMValueRef *) PhiNode,
            uint32 Index)
        let getIncomingValue _PhiNode _Index =
            new ValueRef (getIncomingValueNative ((_PhiNode : ValueRef).Ptr, _Index))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetIncomingBlock",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMBasicBlockRef *) getIncomingBlockNative(
            void* (* LLVMValueRef *) PhiNode,
            uint32 Index)
        let getIncomingBlock _PhiNode _Index =
            new BasicBlockRef (getIncomingBlockNative ((_PhiNode : ValueRef).Ptr, _Index))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMCreateBuilderInContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMBuilderRef *) createBuilderInContextNative(
            void* (* LLVMContextRef *) C)
        let createBuilderInContext _C =
            new BuilderRef (createBuilderInContextNative ((_C : ContextRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMCreateBuilder",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMBuilderRef *) createBuilderNative()
        let createBuilder () =
            new BuilderRef (createBuilderNative ())

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMPositionBuilder",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void positionBuilderNative(
            void* (* LLVMBuilderRef *) Builder,
            void* (* LLVMBasicBlockRef *) Block,
            void* (* LLVMValueRef *) Instr)
        let positionBuilder _Builder _Block _Instr =
            positionBuilderNative ((_Builder : BuilderRef).Ptr, (_Block : BasicBlockRef).Ptr, (_Instr : ValueRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMPositionBuilderBefore",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void positionBuilderBeforeNative(
            void* (* LLVMBuilderRef *) Builder,
            void* (* LLVMValueRef *) Instr)
        let positionBuilderBefore _Builder _Instr =
            positionBuilderBeforeNative ((_Builder : BuilderRef).Ptr, (_Instr : ValueRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMPositionBuilderAtEnd",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void positionBuilderAtEndNative(
            void* (* LLVMBuilderRef *) Builder,
            void* (* LLVMBasicBlockRef *) Block)
        let positionBuilderAtEnd _Builder _Block =
            positionBuilderAtEndNative ((_Builder : BuilderRef).Ptr, (_Block : BasicBlockRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetInsertBlock",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMBasicBlockRef *) getInsertBlockNative(
            void* (* LLVMBuilderRef *) Builder)
        let getInsertBlock _Builder =
            new BasicBlockRef (getInsertBlockNative ((_Builder : BuilderRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMClearInsertionPosition",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void clearInsertionPositionNative(
            void* (* LLVMBuilderRef *) Builder)
        let clearInsertionPosition _Builder =
            clearInsertionPositionNative ((_Builder : BuilderRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMInsertIntoBuilder",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void insertIntoBuilderNative(
            void* (* LLVMBuilderRef *) Builder,
            void* (* LLVMValueRef *) Instr)
        let insertIntoBuilder _Builder _Instr =
            insertIntoBuilderNative ((_Builder : BuilderRef).Ptr, (_Instr : ValueRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMInsertIntoBuilderWithName",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void insertIntoBuilderWithNameNative(
            void* (* LLVMBuilderRef *) Builder,
            void* (* LLVMValueRef *) Instr,
            string Name)
        let insertIntoBuilderWithName _Builder _Instr _Name =
            insertIntoBuilderWithNameNative ((_Builder : BuilderRef).Ptr, (_Instr : ValueRef).Ptr, _Name)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMDisposeBuilder",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void disposeBuilderNative(
            void* (* LLVMBuilderRef *) Builder)
        let disposeBuilder _Builder =
            disposeBuilderNative ((_Builder : BuilderRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMSetCurrentDebugLocation",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void setCurrentDebugLocationNative(
            void* (* LLVMBuilderRef *) Builder,
            void* (* LLVMValueRef *) L)
        let setCurrentDebugLocation _Builder _L =
            setCurrentDebugLocationNative ((_Builder : BuilderRef).Ptr, (_L : ValueRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetCurrentDebugLocation",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getCurrentDebugLocationNative(
            void* (* LLVMBuilderRef *) Builder)
        let getCurrentDebugLocation _Builder =
            new ValueRef (getCurrentDebugLocationNative ((_Builder : BuilderRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMSetInstDebugLocation",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void setInstDebugLocationNative(
            void* (* LLVMBuilderRef *) Builder,
            void* (* LLVMValueRef *) Inst)
        let setInstDebugLocation _Builder _Inst =
            setInstDebugLocationNative ((_Builder : BuilderRef).Ptr, (_Inst : ValueRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildRetVoid",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildRetVoidNative(
            void* (* LLVMBuilderRef *) arg0)
        let buildRetVoid _arg0 =
            new ValueRef (buildRetVoidNative ((_arg0 : BuilderRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildRet",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildRetNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) V)
        let buildRet _arg0 _V =
            new ValueRef (buildRetNative ((_arg0 : BuilderRef).Ptr, (_V : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildAggregateRet",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildAggregateRetNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef* *) RetVals,
            uint32 N)
        // I don't know how to generate an "F# friendly" version of LLVMBuildAggregateRet

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildBr",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildBrNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMBasicBlockRef *) Dest)
        let buildBr _arg0 _Dest =
            new ValueRef (buildBrNative ((_arg0 : BuilderRef).Ptr, (_Dest : BasicBlockRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildCondBr",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildCondBrNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) If,
            void* (* LLVMBasicBlockRef *) Then,
            void* (* LLVMBasicBlockRef *) Else)
        let buildCondBr _arg0 _If _Then _Else =
            new ValueRef (buildCondBrNative ((_arg0 : BuilderRef).Ptr, (_If : ValueRef).Ptr, (_Then : BasicBlockRef).Ptr, (_Else : BasicBlockRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildSwitch",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildSwitchNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) V,
            void* (* LLVMBasicBlockRef *) Else,
            uint32 NumCases)
        let buildSwitch _arg0 _V _Else _NumCases =
            new ValueRef (buildSwitchNative ((_arg0 : BuilderRef).Ptr, (_V : ValueRef).Ptr, (_Else : BasicBlockRef).Ptr, _NumCases))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildIndirectBr",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildIndirectBrNative(
            void* (* LLVMBuilderRef *) B,
            void* (* LLVMValueRef *) Addr,
            uint32 NumDests)
        let buildIndirectBr _B _Addr _NumDests =
            new ValueRef (buildIndirectBrNative ((_B : BuilderRef).Ptr, (_Addr : ValueRef).Ptr, _NumDests))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildInvoke",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildInvokeNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Fn,
            void* (* LLVMValueRef* *) Args,
            uint32 NumArgs,
            void* (* LLVMBasicBlockRef *) Then,
            void* (* LLVMBasicBlockRef *) Catch,
            string Name)
        // I don't know how to generate an "F# friendly" version of LLVMBuildInvoke

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildLandingPad",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildLandingPadNative(
            void* (* LLVMBuilderRef *) B,
            void* (* LLVMTypeRef *) Ty,
            void* (* LLVMValueRef *) PersFn,
            uint32 NumClauses,
            string Name)
        let buildLandingPad _B _Ty _PersFn _NumClauses _Name =
            new ValueRef (buildLandingPadNative ((_B : BuilderRef).Ptr, (_Ty : TypeRef).Ptr, (_PersFn : ValueRef).Ptr, _NumClauses, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildResume",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildResumeNative(
            void* (* LLVMBuilderRef *) B,
            void* (* LLVMValueRef *) Exn)
        let buildResume _B _Exn =
            new ValueRef (buildResumeNative ((_B : BuilderRef).Ptr, (_Exn : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildUnreachable",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildUnreachableNative(
            void* (* LLVMBuilderRef *) arg0)
        let buildUnreachable _arg0 =
            new ValueRef (buildUnreachableNative ((_arg0 : BuilderRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddCase",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addCaseNative(
            void* (* LLVMValueRef *) Switch,
            void* (* LLVMValueRef *) OnVal,
            void* (* LLVMBasicBlockRef *) Dest)
        let addCase _Switch _OnVal _Dest =
            addCaseNative ((_Switch : ValueRef).Ptr, (_OnVal : ValueRef).Ptr, (_Dest : BasicBlockRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddDestination",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addDestinationNative(
            void* (* LLVMValueRef *) IndirectBr,
            void* (* LLVMBasicBlockRef *) Dest)
        let addDestination _IndirectBr _Dest =
            addDestinationNative ((_IndirectBr : ValueRef).Ptr, (_Dest : BasicBlockRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddClause",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addClauseNative(
            void* (* LLVMValueRef *) LandingPad,
            void* (* LLVMValueRef *) ClauseVal)
        let addClause _LandingPad _ClauseVal =
            addClauseNative ((_LandingPad : ValueRef).Ptr, (_ClauseVal : ValueRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMSetCleanup",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void setCleanupNative(
            void* (* LLVMValueRef *) LandingPad,
            bool Val)
        let setCleanup _LandingPad _Val =
            setCleanupNative ((_LandingPad : ValueRef).Ptr, _Val)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildAdd",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildAddNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildAdd _arg0 _LHS _RHS _Name =
            new ValueRef (buildAddNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildNSWAdd",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildNSWAddNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildNSWAdd _arg0 _LHS _RHS _Name =
            new ValueRef (buildNSWAddNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildNUWAdd",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildNUWAddNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildNUWAdd _arg0 _LHS _RHS _Name =
            new ValueRef (buildNUWAddNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildFAdd",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildFAddNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildFAdd _arg0 _LHS _RHS _Name =
            new ValueRef (buildFAddNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildSub",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildSubNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildSub _arg0 _LHS _RHS _Name =
            new ValueRef (buildSubNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildNSWSub",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildNSWSubNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildNSWSub _arg0 _LHS _RHS _Name =
            new ValueRef (buildNSWSubNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildNUWSub",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildNUWSubNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildNUWSub _arg0 _LHS _RHS _Name =
            new ValueRef (buildNUWSubNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildFSub",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildFSubNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildFSub _arg0 _LHS _RHS _Name =
            new ValueRef (buildFSubNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildMul",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildMulNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildMul _arg0 _LHS _RHS _Name =
            new ValueRef (buildMulNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildNSWMul",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildNSWMulNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildNSWMul _arg0 _LHS _RHS _Name =
            new ValueRef (buildNSWMulNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildNUWMul",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildNUWMulNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildNUWMul _arg0 _LHS _RHS _Name =
            new ValueRef (buildNUWMulNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildFMul",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildFMulNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildFMul _arg0 _LHS _RHS _Name =
            new ValueRef (buildFMulNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildUDiv",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildUDivNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildUDiv _arg0 _LHS _RHS _Name =
            new ValueRef (buildUDivNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildSDiv",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildSDivNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildSDiv _arg0 _LHS _RHS _Name =
            new ValueRef (buildSDivNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildExactSDiv",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildExactSDivNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildExactSDiv _arg0 _LHS _RHS _Name =
            new ValueRef (buildExactSDivNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildFDiv",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildFDivNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildFDiv _arg0 _LHS _RHS _Name =
            new ValueRef (buildFDivNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildURem",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildURemNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildURem _arg0 _LHS _RHS _Name =
            new ValueRef (buildURemNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildSRem",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildSRemNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildSRem _arg0 _LHS _RHS _Name =
            new ValueRef (buildSRemNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildFRem",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildFRemNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildFRem _arg0 _LHS _RHS _Name =
            new ValueRef (buildFRemNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildShl",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildShlNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildShl _arg0 _LHS _RHS _Name =
            new ValueRef (buildShlNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildLShr",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildLShrNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildLShr _arg0 _LHS _RHS _Name =
            new ValueRef (buildLShrNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildAShr",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildAShrNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildAShr _arg0 _LHS _RHS _Name =
            new ValueRef (buildAShrNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildAnd",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildAndNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildAnd _arg0 _LHS _RHS _Name =
            new ValueRef (buildAndNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildOr",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildOrNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildOr _arg0 _LHS _RHS _Name =
            new ValueRef (buildOrNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildXor",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildXorNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildXor _arg0 _LHS _RHS _Name =
            new ValueRef (buildXorNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildBinOp",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildBinOpNative(
            void* (* LLVMBuilderRef *) B,
            int (* LLVMOpcode *) Op,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildBinOp _B _Op _LHS _RHS _Name =
            new ValueRef (buildBinOpNative ((_B : BuilderRef).Ptr, (int (_Op : Opcode)), (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildNeg",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildNegNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) V,
            string Name)
        let buildNeg _arg0 _V _Name =
            new ValueRef (buildNegNative ((_arg0 : BuilderRef).Ptr, (_V : ValueRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildNSWNeg",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildNSWNegNative(
            void* (* LLVMBuilderRef *) B,
            void* (* LLVMValueRef *) V,
            string Name)
        let buildNSWNeg _B _V _Name =
            new ValueRef (buildNSWNegNative ((_B : BuilderRef).Ptr, (_V : ValueRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildNUWNeg",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildNUWNegNative(
            void* (* LLVMBuilderRef *) B,
            void* (* LLVMValueRef *) V,
            string Name)
        let buildNUWNeg _B _V _Name =
            new ValueRef (buildNUWNegNative ((_B : BuilderRef).Ptr, (_V : ValueRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildFNeg",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildFNegNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) V,
            string Name)
        let buildFNeg _arg0 _V _Name =
            new ValueRef (buildFNegNative ((_arg0 : BuilderRef).Ptr, (_V : ValueRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildNot",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildNotNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) V,
            string Name)
        let buildNot _arg0 _V _Name =
            new ValueRef (buildNotNative ((_arg0 : BuilderRef).Ptr, (_V : ValueRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildMalloc",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildMallocNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMTypeRef *) Ty,
            string Name)
        let buildMalloc _arg0 _Ty _Name =
            new ValueRef (buildMallocNative ((_arg0 : BuilderRef).Ptr, (_Ty : TypeRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildArrayMalloc",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildArrayMallocNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMTypeRef *) Ty,
            void* (* LLVMValueRef *) Val,
            string Name)
        let buildArrayMalloc _arg0 _Ty _Val _Name =
            new ValueRef (buildArrayMallocNative ((_arg0 : BuilderRef).Ptr, (_Ty : TypeRef).Ptr, (_Val : ValueRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildAlloca",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildAllocaNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMTypeRef *) Ty,
            string Name)
        let buildAlloca _arg0 _Ty _Name =
            new ValueRef (buildAllocaNative ((_arg0 : BuilderRef).Ptr, (_Ty : TypeRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildArrayAlloca",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildArrayAllocaNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMTypeRef *) Ty,
            void* (* LLVMValueRef *) Val,
            string Name)
        let buildArrayAlloca _arg0 _Ty _Val _Name =
            new ValueRef (buildArrayAllocaNative ((_arg0 : BuilderRef).Ptr, (_Ty : TypeRef).Ptr, (_Val : ValueRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildFree",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildFreeNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) PointerVal)
        let buildFree _arg0 _PointerVal =
            new ValueRef (buildFreeNative ((_arg0 : BuilderRef).Ptr, (_PointerVal : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildLoad",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildLoadNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) PointerVal,
            string Name)
        let buildLoad _arg0 _PointerVal _Name =
            new ValueRef (buildLoadNative ((_arg0 : BuilderRef).Ptr, (_PointerVal : ValueRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildStore",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildStoreNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMValueRef *) Ptr)
        let buildStore _arg0 _Val _Ptr =
            new ValueRef (buildStoreNative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, (_Ptr : ValueRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildGEP",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildGEPNative(
            void* (* LLVMBuilderRef *) B,
            void* (* LLVMValueRef *) Pointer,
            void* (* LLVMValueRef* *) Indices,
            uint32 NumIndices,
            string Name)
        // I don't know how to generate an "F# friendly" version of LLVMBuildGEP

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildInBoundsGEP",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildInBoundsGEPNative(
            void* (* LLVMBuilderRef *) B,
            void* (* LLVMValueRef *) Pointer,
            void* (* LLVMValueRef* *) Indices,
            uint32 NumIndices,
            string Name)
        // I don't know how to generate an "F# friendly" version of LLVMBuildInBoundsGEP

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildStructGEP",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildStructGEPNative(
            void* (* LLVMBuilderRef *) B,
            void* (* LLVMValueRef *) Pointer,
            uint32 Idx,
            string Name)
        let buildStructGEP _B _Pointer _Idx _Name =
            new ValueRef (buildStructGEPNative ((_B : BuilderRef).Ptr, (_Pointer : ValueRef).Ptr, _Idx, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildGlobalString",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildGlobalStringNative(
            void* (* LLVMBuilderRef *) B,
            string Str,
            string Name)
        let buildGlobalString _B _Str _Name =
            new ValueRef (buildGlobalStringNative ((_B : BuilderRef).Ptr, _Str, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildGlobalStringPtr",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildGlobalStringPtrNative(
            void* (* LLVMBuilderRef *) B,
            string Str,
            string Name)
        let buildGlobalStringPtr _B _Str _Name =
            new ValueRef (buildGlobalStringPtrNative ((_B : BuilderRef).Ptr, _Str, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetVolatile",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool getVolatileNative(
            void* (* LLVMValueRef *) MemoryAccessInst)
        let getVolatile _MemoryAccessInst =
            getVolatileNative ((_MemoryAccessInst : ValueRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMSetVolatile",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void setVolatileNative(
            void* (* LLVMValueRef *) MemoryAccessInst,
            bool IsVolatile)
        let setVolatile _MemoryAccessInst _IsVolatile =
            setVolatileNative ((_MemoryAccessInst : ValueRef).Ptr, _IsVolatile)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildTrunc",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildTruncNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMTypeRef *) DestTy,
            string Name)
        let buildTrunc _arg0 _Val _DestTy _Name =
            new ValueRef (buildTruncNative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, (_DestTy : TypeRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildZExt",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildZExtNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMTypeRef *) DestTy,
            string Name)
        let buildZExt _arg0 _Val _DestTy _Name =
            new ValueRef (buildZExtNative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, (_DestTy : TypeRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildSExt",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildSExtNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMTypeRef *) DestTy,
            string Name)
        let buildSExt _arg0 _Val _DestTy _Name =
            new ValueRef (buildSExtNative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, (_DestTy : TypeRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildFPToUI",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildFPToUINative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMTypeRef *) DestTy,
            string Name)
        let buildFPToUI _arg0 _Val _DestTy _Name =
            new ValueRef (buildFPToUINative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, (_DestTy : TypeRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildFPToSI",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildFPToSINative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMTypeRef *) DestTy,
            string Name)
        let buildFPToSI _arg0 _Val _DestTy _Name =
            new ValueRef (buildFPToSINative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, (_DestTy : TypeRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildUIToFP",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildUIToFPNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMTypeRef *) DestTy,
            string Name)
        let buildUIToFP _arg0 _Val _DestTy _Name =
            new ValueRef (buildUIToFPNative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, (_DestTy : TypeRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildSIToFP",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildSIToFPNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMTypeRef *) DestTy,
            string Name)
        let buildSIToFP _arg0 _Val _DestTy _Name =
            new ValueRef (buildSIToFPNative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, (_DestTy : TypeRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildFPTrunc",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildFPTruncNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMTypeRef *) DestTy,
            string Name)
        let buildFPTrunc _arg0 _Val _DestTy _Name =
            new ValueRef (buildFPTruncNative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, (_DestTy : TypeRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildFPExt",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildFPExtNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMTypeRef *) DestTy,
            string Name)
        let buildFPExt _arg0 _Val _DestTy _Name =
            new ValueRef (buildFPExtNative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, (_DestTy : TypeRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildPtrToInt",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildPtrToIntNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMTypeRef *) DestTy,
            string Name)
        let buildPtrToInt _arg0 _Val _DestTy _Name =
            new ValueRef (buildPtrToIntNative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, (_DestTy : TypeRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildIntToPtr",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildIntToPtrNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMTypeRef *) DestTy,
            string Name)
        let buildIntToPtr _arg0 _Val _DestTy _Name =
            new ValueRef (buildIntToPtrNative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, (_DestTy : TypeRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildBitCast",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildBitCastNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMTypeRef *) DestTy,
            string Name)
        let buildBitCast _arg0 _Val _DestTy _Name =
            new ValueRef (buildBitCastNative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, (_DestTy : TypeRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildAddrSpaceCast",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildAddrSpaceCastNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMTypeRef *) DestTy,
            string Name)
        let buildAddrSpaceCast _arg0 _Val _DestTy _Name =
            new ValueRef (buildAddrSpaceCastNative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, (_DestTy : TypeRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildZExtOrBitCast",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildZExtOrBitCastNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMTypeRef *) DestTy,
            string Name)
        let buildZExtOrBitCast _arg0 _Val _DestTy _Name =
            new ValueRef (buildZExtOrBitCastNative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, (_DestTy : TypeRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildSExtOrBitCast",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildSExtOrBitCastNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMTypeRef *) DestTy,
            string Name)
        let buildSExtOrBitCast _arg0 _Val _DestTy _Name =
            new ValueRef (buildSExtOrBitCastNative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, (_DestTy : TypeRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildTruncOrBitCast",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildTruncOrBitCastNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMTypeRef *) DestTy,
            string Name)
        let buildTruncOrBitCast _arg0 _Val _DestTy _Name =
            new ValueRef (buildTruncOrBitCastNative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, (_DestTy : TypeRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildCast",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildCastNative(
            void* (* LLVMBuilderRef *) B,
            int (* LLVMOpcode *) Op,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMTypeRef *) DestTy,
            string Name)
        let buildCast _B _Op _Val _DestTy _Name =
            new ValueRef (buildCastNative ((_B : BuilderRef).Ptr, (int (_Op : Opcode)), (_Val : ValueRef).Ptr, (_DestTy : TypeRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildPointerCast",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildPointerCastNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMTypeRef *) DestTy,
            string Name)
        let buildPointerCast _arg0 _Val _DestTy _Name =
            new ValueRef (buildPointerCastNative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, (_DestTy : TypeRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildIntCast",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildIntCastNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMTypeRef *) DestTy,
            string Name)
        let buildIntCast _arg0 _Val _DestTy _Name =
            new ValueRef (buildIntCastNative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, (_DestTy : TypeRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildFPCast",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildFPCastNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMTypeRef *) DestTy,
            string Name)
        let buildFPCast _arg0 _Val _DestTy _Name =
            new ValueRef (buildFPCastNative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, (_DestTy : TypeRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildICmp",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildICmpNative(
            void* (* LLVMBuilderRef *) arg0,
            int (* LLVMIntPredicate *) Op,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildICmp _arg0 _Op _LHS _RHS _Name =
            new ValueRef (buildICmpNative ((_arg0 : BuilderRef).Ptr, (int (_Op : IntPredicate)), (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildFCmp",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildFCmpNative(
            void* (* LLVMBuilderRef *) arg0,
            int (* LLVMRealPredicate *) Op,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildFCmp _arg0 _Op _LHS _RHS _Name =
            new ValueRef (buildFCmpNative ((_arg0 : BuilderRef).Ptr, (int (_Op : RealPredicate)), (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildPhi",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildPhiNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMTypeRef *) Ty,
            string Name)
        let buildPhi _arg0 _Ty _Name =
            new ValueRef (buildPhiNative ((_arg0 : BuilderRef).Ptr, (_Ty : TypeRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildCall",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildCallNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Fn,
            void* (* LLVMValueRef* *) Args,
            uint32 NumArgs,
            string Name)
        // I don't know how to generate an "F# friendly" version of LLVMBuildCall

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildSelect",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildSelectNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) If,
            void* (* LLVMValueRef *) Then,
            void* (* LLVMValueRef *) Else,
            string Name)
        let buildSelect _arg0 _If _Then _Else _Name =
            new ValueRef (buildSelectNative ((_arg0 : BuilderRef).Ptr, (_If : ValueRef).Ptr, (_Then : ValueRef).Ptr, (_Else : ValueRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildVAArg",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildVAArgNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) List,
            void* (* LLVMTypeRef *) Ty,
            string Name)
        let buildVAArg _arg0 _List _Ty _Name =
            new ValueRef (buildVAArgNative ((_arg0 : BuilderRef).Ptr, (_List : ValueRef).Ptr, (_Ty : TypeRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildExtractElement",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildExtractElementNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) VecVal,
            void* (* LLVMValueRef *) Index,
            string Name)
        let buildExtractElement _arg0 _VecVal _Index _Name =
            new ValueRef (buildExtractElementNative ((_arg0 : BuilderRef).Ptr, (_VecVal : ValueRef).Ptr, (_Index : ValueRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildInsertElement",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildInsertElementNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) VecVal,
            void* (* LLVMValueRef *) EltVal,
            void* (* LLVMValueRef *) Index,
            string Name)
        let buildInsertElement _arg0 _VecVal _EltVal _Index _Name =
            new ValueRef (buildInsertElementNative ((_arg0 : BuilderRef).Ptr, (_VecVal : ValueRef).Ptr, (_EltVal : ValueRef).Ptr, (_Index : ValueRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildShuffleVector",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildShuffleVectorNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) V1,
            void* (* LLVMValueRef *) V2,
            void* (* LLVMValueRef *) Mask,
            string Name)
        let buildShuffleVector _arg0 _V1 _V2 _Mask _Name =
            new ValueRef (buildShuffleVectorNative ((_arg0 : BuilderRef).Ptr, (_V1 : ValueRef).Ptr, (_V2 : ValueRef).Ptr, (_Mask : ValueRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildExtractValue",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildExtractValueNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) AggVal,
            uint32 Index,
            string Name)
        let buildExtractValue _arg0 _AggVal _Index _Name =
            new ValueRef (buildExtractValueNative ((_arg0 : BuilderRef).Ptr, (_AggVal : ValueRef).Ptr, _Index, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildInsertValue",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildInsertValueNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) AggVal,
            void* (* LLVMValueRef *) EltVal,
            uint32 Index,
            string Name)
        let buildInsertValue _arg0 _AggVal _EltVal _Index _Name =
            new ValueRef (buildInsertValueNative ((_arg0 : BuilderRef).Ptr, (_AggVal : ValueRef).Ptr, (_EltVal : ValueRef).Ptr, _Index, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildIsNull",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildIsNullNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            string Name)
        let buildIsNull _arg0 _Val _Name =
            new ValueRef (buildIsNullNative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildIsNotNull",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildIsNotNullNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            string Name)
        let buildIsNotNull _arg0 _Val _Name =
            new ValueRef (buildIsNotNullNative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildPtrDiff",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildPtrDiffNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildPtrDiff _arg0 _LHS _RHS _Name =
            new ValueRef (buildPtrDiffNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildFence",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildFenceNative(
            void* (* LLVMBuilderRef *) B,
            int (* LLVMAtomicOrdering *) ordering,
            bool singleThread,
            string Name)
        let buildFence _B _ordering _singleThread _Name =
            new ValueRef (buildFenceNative ((_B : BuilderRef).Ptr, (int (_ordering : AtomicOrdering)), _singleThread, _Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMBuildAtomicRMW",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildAtomicRMWNative(
            void* (* LLVMBuilderRef *) B,
            int (* LLVMAtomicRMWBinOp *) op,
            void* (* LLVMValueRef *) PTR,
            void* (* LLVMValueRef *) Val,
            int (* LLVMAtomicOrdering *) ordering,
            bool singleThread)
        let buildAtomicRMW _B _op _PTR _Val _ordering _singleThread =
            new ValueRef (buildAtomicRMWNative ((_B : BuilderRef).Ptr, (int (_op : AtomicRMWBinOp)), (_PTR : ValueRef).Ptr, (_Val : ValueRef).Ptr, (int (_ordering : AtomicOrdering)), _singleThread))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMCreateModuleProviderForExistingModule",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMModuleProviderRef *) createModuleProviderForExistingModuleNative(
            void* (* LLVMModuleRef *) M)
        let createModuleProviderForExistingModule _M =
            new ModuleProviderRef (createModuleProviderForExistingModuleNative ((_M : ModuleRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMDisposeModuleProvider",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void disposeModuleProviderNative(
            void* (* LLVMModuleProviderRef *) M)
        let disposeModuleProvider _M =
            disposeModuleProviderNative ((_M : ModuleProviderRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMCreateMemoryBufferWithContentsOfFile",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool createMemoryBufferWithContentsOfFileNative(
            string Path,
            void* (* LLVMMemoryBufferRef* *) OutMemBuf,
            void* (* char** *) OutMessage)
        // I don't know how to generate an "F# friendly" version of LLVMCreateMemoryBufferWithContentsOfFile

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMCreateMemoryBufferWithSTDIN",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool createMemoryBufferWithSTDINNative(
            void* (* LLVMMemoryBufferRef* *) OutMemBuf,
            void* (* char** *) OutMessage)
        // I don't know how to generate an "F# friendly" version of LLVMCreateMemoryBufferWithSTDIN

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMCreateMemoryBufferWithMemoryRange",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMMemoryBufferRef *) createMemoryBufferWithMemoryRangeNative(
            string InputData,
            nativeint (* size_t *) InputDataLength,
            string BufferName,
            bool RequiresNullTerminator)
        let createMemoryBufferWithMemoryRange _InputData _InputDataLength _BufferName _RequiresNullTerminator =
            new MemoryBufferRef (createMemoryBufferWithMemoryRangeNative (_InputData, _InputDataLength, _BufferName, _RequiresNullTerminator))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMCreateMemoryBufferWithMemoryRangeCopy",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMMemoryBufferRef *) createMemoryBufferWithMemoryRangeCopyNative(
            string InputData,
            nativeint (* size_t *) InputDataLength,
            string BufferName)
        let createMemoryBufferWithMemoryRangeCopy _InputData _InputDataLength _BufferName =
            new MemoryBufferRef (createMemoryBufferWithMemoryRangeCopyNative (_InputData, _InputDataLength, _BufferName))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetBufferStart",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* const char* *) getBufferStartNative(
            void* (* LLVMMemoryBufferRef *) MemBuf)
        let getBufferStart _MemBuf =
            Marshal.PtrToStringAuto (getBufferStartNative ((_MemBuf : MemoryBufferRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetBufferSize",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern nativeint (* size_t *) getBufferSizeNative(
            void* (* LLVMMemoryBufferRef *) MemBuf)
        let getBufferSize _MemBuf =
            getBufferSizeNative ((_MemBuf : MemoryBufferRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMDisposeMemoryBuffer",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void disposeMemoryBufferNative(
            void* (* LLVMMemoryBufferRef *) MemBuf)
        let disposeMemoryBuffer _MemBuf =
            disposeMemoryBufferNative ((_MemBuf : MemoryBufferRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetGlobalPassRegistry",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMPassRegistryRef *) getGlobalPassRegistryNative()
        let getGlobalPassRegistry () =
            new PassRegistryRef (getGlobalPassRegistryNative ())

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMCreatePassManager",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMPassManagerRef *) createPassManagerNative()
        let createPassManager () =
            new PassManagerRef (createPassManagerNative ())

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMCreateFunctionPassManagerForModule",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMPassManagerRef *) createFunctionPassManagerForModuleNative(
            void* (* LLVMModuleRef *) M)
        let createFunctionPassManagerForModule _M =
            new PassManagerRef (createFunctionPassManagerForModuleNative ((_M : ModuleRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMCreateFunctionPassManager",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMPassManagerRef *) createFunctionPassManagerNative(
            void* (* LLVMModuleProviderRef *) MP)
        let createFunctionPassManager _MP =
            new PassManagerRef (createFunctionPassManagerNative ((_MP : ModuleProviderRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMRunPassManager",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool runPassManagerNative(
            void* (* LLVMPassManagerRef *) PM,
            void* (* LLVMModuleRef *) M)
        let runPassManager _PM _M =
            runPassManagerNative ((_PM : PassManagerRef).Ptr, (_M : ModuleRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMInitializeFunctionPassManager",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool initializeFunctionPassManagerNative(
            void* (* LLVMPassManagerRef *) FPM)
        let initializeFunctionPassManager _FPM =
            initializeFunctionPassManagerNative ((_FPM : PassManagerRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMRunFunctionPassManager",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool runFunctionPassManagerNative(
            void* (* LLVMPassManagerRef *) FPM,
            void* (* LLVMValueRef *) F)
        let runFunctionPassManager _FPM _F =
            runFunctionPassManagerNative ((_FPM : PassManagerRef).Ptr, (_F : ValueRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMFinalizeFunctionPassManager",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool finalizeFunctionPassManagerNative(
            void* (* LLVMPassManagerRef *) FPM)
        let finalizeFunctionPassManager _FPM =
            finalizeFunctionPassManagerNative ((_FPM : PassManagerRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMDisposePassManager",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void disposePassManagerNative(
            void* (* LLVMPassManagerRef *) PM)
        let disposePassManager _PM =
            disposePassManagerNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMStartMultithreaded",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool startMultithreadedNative()
        let startMultithreaded () =
            startMultithreadedNative ()

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMStopMultithreaded",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void stopMultithreadedNative()
        let stopMultithreaded () =
            stopMultithreadedNative ()

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMIsMultithreaded",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool isMultithreadedNative()
        let isMultithreaded () =
            isMultithreadedNative ()

// This file should not be edited. It is automatically generated from a C header file
namespace LLVM.Generated

    open LLVM.FFIUtil
    open System.Runtime.InteropServices
    open LLVM.Generated.Core

    module Initialization =

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMInitializeCore",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void initializeCoreNative(
            void* (* LLVMPassRegistryRef *) R)
        let initializeCore _R =
            initializeCoreNative ((_R : PassRegistryRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMInitializeTransformUtils",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void initializeTransformUtilsNative(
            void* (* LLVMPassRegistryRef *) R)
        let initializeTransformUtils _R =
            initializeTransformUtilsNative ((_R : PassRegistryRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMInitializeScalarOpts",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void initializeScalarOptsNative(
            void* (* LLVMPassRegistryRef *) R)
        let initializeScalarOpts _R =
            initializeScalarOptsNative ((_R : PassRegistryRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMInitializeObjCARCOpts",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void initializeObjCARCOptsNative(
            void* (* LLVMPassRegistryRef *) R)
        let initializeObjCARCOpts _R =
            initializeObjCARCOptsNative ((_R : PassRegistryRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMInitializeVectorization",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void initializeVectorizationNative(
            void* (* LLVMPassRegistryRef *) R)
        let initializeVectorization _R =
            initializeVectorizationNative ((_R : PassRegistryRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMInitializeInstCombine",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void initializeInstCombineNative(
            void* (* LLVMPassRegistryRef *) R)
        let initializeInstCombine _R =
            initializeInstCombineNative ((_R : PassRegistryRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMInitializeIPO",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void initializeIPONative(
            void* (* LLVMPassRegistryRef *) R)
        let initializeIPO _R =
            initializeIPONative ((_R : PassRegistryRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMInitializeInstrumentation",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void initializeInstrumentationNative(
            void* (* LLVMPassRegistryRef *) R)
        let initializeInstrumentation _R =
            initializeInstrumentationNative ((_R : PassRegistryRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMInitializeAnalysis",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void initializeAnalysisNative(
            void* (* LLVMPassRegistryRef *) R)
        let initializeAnalysis _R =
            initializeAnalysisNative ((_R : PassRegistryRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMInitializeIPA",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void initializeIPANative(
            void* (* LLVMPassRegistryRef *) R)
        let initializeIPA _R =
            initializeIPANative ((_R : PassRegistryRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMInitializeCodeGen",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void initializeCodeGenNative(
            void* (* LLVMPassRegistryRef *) R)
        let initializeCodeGen _R =
            initializeCodeGenNative ((_R : PassRegistryRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMInitializeTarget",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void initializeTargetNative(
            void* (* LLVMPassRegistryRef *) R)
        let initializeTarget _R =
            initializeTargetNative ((_R : PassRegistryRef).Ptr)

// This file should not be edited. It is automatically generated from a C header file
namespace LLVM.Generated

    open LLVM.FFIUtil
    open System.Runtime.InteropServices
    open LLVM.Generated.Support
    open LLVM.Generated.Core

    module BitReader =

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMParseBitcode",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool parseBitcodeNative(
            void* (* LLVMMemoryBufferRef *) MemBuf,
            void* (* LLVMModuleRef* *) OutModule,
            void* (* char** *) OutMessage)
        // I don't know how to generate an "F# friendly" version of LLVMParseBitcode

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMParseBitcodeInContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool parseBitcodeInContextNative(
            void* (* LLVMContextRef *) ContextRef,
            void* (* LLVMMemoryBufferRef *) MemBuf,
            void* (* LLVMModuleRef* *) OutModule,
            void* (* char** *) OutMessage)
        // I don't know how to generate an "F# friendly" version of LLVMParseBitcodeInContext

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetBitcodeModuleInContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool getBitcodeModuleInContextNative(
            void* (* LLVMContextRef *) ContextRef,
            void* (* LLVMMemoryBufferRef *) MemBuf,
            void* (* LLVMModuleRef* *) OutM,
            void* (* char** *) OutMessage)
        // I don't know how to generate an "F# friendly" version of LLVMGetBitcodeModuleInContext

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetBitcodeModule",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool getBitcodeModuleNative(
            void* (* LLVMMemoryBufferRef *) MemBuf,
            void* (* LLVMModuleRef* *) OutM,
            void* (* char** *) OutMessage)
        // I don't know how to generate an "F# friendly" version of LLVMGetBitcodeModule

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetBitcodeModuleProviderInContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool getBitcodeModuleProviderInContextNative(
            void* (* LLVMContextRef *) ContextRef,
            void* (* LLVMMemoryBufferRef *) MemBuf,
            void* (* LLVMModuleProviderRef* *) OutMP,
            void* (* char** *) OutMessage)
        // I don't know how to generate an "F# friendly" version of LLVMGetBitcodeModuleProviderInContext

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetBitcodeModuleProvider",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool getBitcodeModuleProviderNative(
            void* (* LLVMMemoryBufferRef *) MemBuf,
            void* (* LLVMModuleProviderRef* *) OutMP,
            void* (* char** *) OutMessage)
        // I don't know how to generate an "F# friendly" version of LLVMGetBitcodeModuleProvider

// This file should not be edited. It is automatically generated from a C header file
namespace LLVM.Generated

    open LLVM.FFIUtil
    open System.Runtime.InteropServices
    open LLVM.Generated.Support
    open LLVM.Generated.Core

    module BitWriter =

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMWriteBitcodeToFile",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int writeBitcodeToFileNative(
            void* (* LLVMModuleRef *) M,
            string Path)
        let writeBitcodeToFile _M _Path =
            writeBitcodeToFileNative ((_M : ModuleRef).Ptr, _Path)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMWriteBitcodeToFD",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int writeBitcodeToFDNative(
            void* (* LLVMModuleRef *) M,
            int FD,
            int ShouldClose,
            int Unbuffered)
        let writeBitcodeToFD _M _FD _ShouldClose _Unbuffered =
            writeBitcodeToFDNative ((_M : ModuleRef).Ptr, _FD, _ShouldClose, _Unbuffered)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMWriteBitcodeToFileHandle",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int writeBitcodeToFileHandleNative(
            void* (* LLVMModuleRef *) M,
            int Handle)
        let writeBitcodeToFileHandle _M _Handle =
            writeBitcodeToFileHandleNative ((_M : ModuleRef).Ptr, _Handle)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMWriteBitcodeToMemoryBuffer",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMMemoryBufferRef *) writeBitcodeToMemoryBufferNative(
            void* (* LLVMModuleRef *) M)
        let writeBitcodeToMemoryBuffer _M =
            new MemoryBufferRef (writeBitcodeToMemoryBufferNative ((_M : ModuleRef).Ptr))

// This file should not be edited. It is automatically generated from a C header file
namespace LLVM.Generated

    open LLVM.FFIUtil
    open System.Runtime.InteropServices
    open LLVM.Generated.Core

    module Target =

        type ByteOrdering =
            | BigEndian = 0
            | LittleEndian = 1

        type TargetDataRef (thePtr : nativeint) =
            member x.Ptr = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr = thePtr

        type TargetLibraryInfoRef (thePtr : nativeint) =
            member x.Ptr = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr = thePtr

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMCreateTargetData",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTargetDataRef *) createTargetDataNative(
            string StringRep)
        let createTargetData _StringRep =
            new TargetDataRef (createTargetDataNative (_StringRep))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddTargetData",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addTargetDataNative(
            void* (* LLVMTargetDataRef *) TD,
            void* (* LLVMPassManagerRef *) PM)
        let addTargetData _TD _PM =
            addTargetDataNative ((_TD : TargetDataRef).Ptr, (_PM : PassManagerRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddTargetLibraryInfo",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addTargetLibraryInfoNative(
            void* (* LLVMTargetLibraryInfoRef *) TLI,
            void* (* LLVMPassManagerRef *) PM)
        let addTargetLibraryInfo _TLI _PM =
            addTargetLibraryInfoNative ((_TLI : TargetLibraryInfoRef).Ptr, (_PM : PassManagerRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMCopyStringRepOfTargetData",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* char* *) copyStringRepOfTargetDataNative(
            void* (* LLVMTargetDataRef *) TD)
        let copyStringRepOfTargetData _TD =
            Marshal.PtrToStringAuto (copyStringRepOfTargetDataNative ((_TD : TargetDataRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMByteOrder",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int (* LLVMByteOrdering *) byteOrderNative(
            void* (* LLVMTargetDataRef *) TD)
        let byteOrder _TD =
            enum<ByteOrdering> (byteOrderNative ((_TD : TargetDataRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMPointerSize",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 pointerSizeNative(
            void* (* LLVMTargetDataRef *) TD)
        let pointerSize _TD =
            pointerSizeNative ((_TD : TargetDataRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMPointerSizeForAS",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 pointerSizeForASNative(
            void* (* LLVMTargetDataRef *) TD,
            uint32 AS)
        let pointerSizeForAS _TD _AS =
            pointerSizeForASNative ((_TD : TargetDataRef).Ptr, _AS)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMIntPtrType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) intPtrTypeNative(
            void* (* LLVMTargetDataRef *) TD)
        let intPtrType _TD =
            new TypeRef (intPtrTypeNative ((_TD : TargetDataRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMIntPtrTypeForAS",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) intPtrTypeForASNative(
            void* (* LLVMTargetDataRef *) TD,
            uint32 AS)
        let intPtrTypeForAS _TD _AS =
            new TypeRef (intPtrTypeForASNative ((_TD : TargetDataRef).Ptr, _AS))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMIntPtrTypeInContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) intPtrTypeInContextNative(
            void* (* LLVMContextRef *) C,
            void* (* LLVMTargetDataRef *) TD)
        let intPtrTypeInContext _C _TD =
            new TypeRef (intPtrTypeInContextNative ((_C : ContextRef).Ptr, (_TD : TargetDataRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMIntPtrTypeForASInContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) intPtrTypeForASInContextNative(
            void* (* LLVMContextRef *) C,
            void* (* LLVMTargetDataRef *) TD,
            uint32 AS)
        let intPtrTypeForASInContext _C _TD _AS =
            new TypeRef (intPtrTypeForASInContextNative ((_C : ContextRef).Ptr, (_TD : TargetDataRef).Ptr, _AS))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMSizeOfTypeInBits",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint64 sizeOfTypeInBitsNative(
            void* (* LLVMTargetDataRef *) TD,
            void* (* LLVMTypeRef *) Ty)
        let sizeOfTypeInBits _TD _Ty =
            sizeOfTypeInBitsNative ((_TD : TargetDataRef).Ptr, (_Ty : TypeRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMStoreSizeOfType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint64 storeSizeOfTypeNative(
            void* (* LLVMTargetDataRef *) TD,
            void* (* LLVMTypeRef *) Ty)
        let storeSizeOfType _TD _Ty =
            storeSizeOfTypeNative ((_TD : TargetDataRef).Ptr, (_Ty : TypeRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMABISizeOfType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint64 aBISizeOfTypeNative(
            void* (* LLVMTargetDataRef *) TD,
            void* (* LLVMTypeRef *) Ty)
        let aBISizeOfType _TD _Ty =
            aBISizeOfTypeNative ((_TD : TargetDataRef).Ptr, (_Ty : TypeRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMABIAlignmentOfType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 aBIAlignmentOfTypeNative(
            void* (* LLVMTargetDataRef *) TD,
            void* (* LLVMTypeRef *) Ty)
        let aBIAlignmentOfType _TD _Ty =
            aBIAlignmentOfTypeNative ((_TD : TargetDataRef).Ptr, (_Ty : TypeRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMCallFrameAlignmentOfType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 callFrameAlignmentOfTypeNative(
            void* (* LLVMTargetDataRef *) TD,
            void* (* LLVMTypeRef *) Ty)
        let callFrameAlignmentOfType _TD _Ty =
            callFrameAlignmentOfTypeNative ((_TD : TargetDataRef).Ptr, (_Ty : TypeRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMPreferredAlignmentOfType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 preferredAlignmentOfTypeNative(
            void* (* LLVMTargetDataRef *) TD,
            void* (* LLVMTypeRef *) Ty)
        let preferredAlignmentOfType _TD _Ty =
            preferredAlignmentOfTypeNative ((_TD : TargetDataRef).Ptr, (_Ty : TypeRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMPreferredAlignmentOfGlobal",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 preferredAlignmentOfGlobalNative(
            void* (* LLVMTargetDataRef *) TD,
            void* (* LLVMValueRef *) GlobalVar)
        let preferredAlignmentOfGlobal _TD _GlobalVar =
            preferredAlignmentOfGlobalNative ((_TD : TargetDataRef).Ptr, (_GlobalVar : ValueRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMElementAtOffset",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 elementAtOffsetNative(
            void* (* LLVMTargetDataRef *) TD,
            void* (* LLVMTypeRef *) StructTy,
            uint64 Offset)
        let elementAtOffset _TD _StructTy _Offset =
            elementAtOffsetNative ((_TD : TargetDataRef).Ptr, (_StructTy : TypeRef).Ptr, _Offset)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMOffsetOfElement",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint64 offsetOfElementNative(
            void* (* LLVMTargetDataRef *) TD,
            void* (* LLVMTypeRef *) StructTy,
            uint32 Element)
        let offsetOfElement _TD _StructTy _Element =
            offsetOfElementNative ((_TD : TargetDataRef).Ptr, (_StructTy : TypeRef).Ptr, _Element)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMDisposeTargetData",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void disposeTargetDataNative(
            void* (* LLVMTargetDataRef *) TD)
        let disposeTargetData _TD =
            disposeTargetDataNative ((_TD : TargetDataRef).Ptr)

// This file should not be edited. It is automatically generated from a C header file
namespace LLVM.Generated

    open LLVM.FFIUtil
    open System.Runtime.InteropServices
    open LLVM.Generated.Support
    open LLVM.Generated.Core
    open LLVM.Generated.Target

    module TargetMachine =

        type TargetMachineRef (thePtr : nativeint) =
            member x.Ptr = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr = thePtr

        type TargetRef (thePtr : nativeint) =
            member x.Ptr = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr = thePtr

        type CodeGenOptLevel =
            | CodeGenLevelNone = 0
            | CodeGenLevelLess = 1
            | CodeGenLevelDefault = 2
            | CodeGenLevelAggressive = 3

        type RelocMode =
            | RelocDefault = 0
            | RelocStatic = 1
            | RelocPIC = 2
            | RelocDynamicNoPic = 3

        type CodeModel =
            | CodeModelDefault = 0
            | CodeModelJITDefault = 1
            | CodeModelSmall = 2
            | CodeModelKernel = 3
            | CodeModelMedium = 4
            | CodeModelLarge = 5

        type CodeGenFileType =
            | AssemblyFile = 0
            | ObjectFile = 1

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetFirstTarget",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTargetRef *) getFirstTargetNative()
        let getFirstTarget () =
            new TargetRef (getFirstTargetNative ())

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetNextTarget",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTargetRef *) getNextTargetNative(
            void* (* LLVMTargetRef *) T)
        let getNextTarget _T =
            new TargetRef (getNextTargetNative ((_T : TargetRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetTargetFromName",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTargetRef *) getTargetFromNameNative(
            string Name)
        let getTargetFromName _Name =
            new TargetRef (getTargetFromNameNative (_Name))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetTargetFromTriple",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool getTargetFromTripleNative(
            string Triple,
            void* (* LLVMTargetRef* *) T,
            void* (* char** *) ErrorMessage)
        // I don't know how to generate an "F# friendly" version of LLVMGetTargetFromTriple

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetTargetName",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* const char* *) getTargetNameNative(
            void* (* LLVMTargetRef *) T)
        let getTargetName _T =
            Marshal.PtrToStringAuto (getTargetNameNative ((_T : TargetRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetTargetDescription",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* const char* *) getTargetDescriptionNative(
            void* (* LLVMTargetRef *) T)
        let getTargetDescription _T =
            Marshal.PtrToStringAuto (getTargetDescriptionNative ((_T : TargetRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMTargetHasJIT",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool targetHasJITNative(
            void* (* LLVMTargetRef *) T)
        let targetHasJIT _T =
            targetHasJITNative ((_T : TargetRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMTargetHasTargetMachine",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool targetHasTargetMachineNative(
            void* (* LLVMTargetRef *) T)
        let targetHasTargetMachine _T =
            targetHasTargetMachineNative ((_T : TargetRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMTargetHasAsmBackend",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool targetHasAsmBackendNative(
            void* (* LLVMTargetRef *) T)
        let targetHasAsmBackend _T =
            targetHasAsmBackendNative ((_T : TargetRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMCreateTargetMachine",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTargetMachineRef *) createTargetMachineNative(
            void* (* LLVMTargetRef *) T,
            string Triple,
            string CPU,
            string Features,
            int (* LLVMCodeGenOptLevel *) Level,
            int (* LLVMRelocMode *) Reloc,
            int (* LLVMCodeModel *) CodeModel)
        let createTargetMachine _T _Triple _CPU _Features _Level _Reloc _CodeModel =
            new TargetMachineRef (createTargetMachineNative ((_T : TargetRef).Ptr, _Triple, _CPU, _Features, (int (_Level : CodeGenOptLevel)), (int (_Reloc : RelocMode)), (int (_CodeModel : CodeModel))))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMDisposeTargetMachine",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void disposeTargetMachineNative(
            void* (* LLVMTargetMachineRef *) T)
        let disposeTargetMachine _T =
            disposeTargetMachineNative ((_T : TargetMachineRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetTargetMachineTarget",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTargetRef *) getTargetMachineTargetNative(
            void* (* LLVMTargetMachineRef *) T)
        let getTargetMachineTarget _T =
            new TargetRef (getTargetMachineTargetNative ((_T : TargetMachineRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetTargetMachineTriple",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* char* *) getTargetMachineTripleNative(
            void* (* LLVMTargetMachineRef *) T)
        let getTargetMachineTriple _T =
            Marshal.PtrToStringAuto (getTargetMachineTripleNative ((_T : TargetMachineRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetTargetMachineCPU",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* char* *) getTargetMachineCPUNative(
            void* (* LLVMTargetMachineRef *) T)
        let getTargetMachineCPU _T =
            Marshal.PtrToStringAuto (getTargetMachineCPUNative ((_T : TargetMachineRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetTargetMachineFeatureString",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* char* *) getTargetMachineFeatureStringNative(
            void* (* LLVMTargetMachineRef *) T)
        let getTargetMachineFeatureString _T =
            Marshal.PtrToStringAuto (getTargetMachineFeatureStringNative ((_T : TargetMachineRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetTargetMachineData",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTargetDataRef *) getTargetMachineDataNative(
            void* (* LLVMTargetMachineRef *) T)
        let getTargetMachineData _T =
            new TargetDataRef (getTargetMachineDataNative ((_T : TargetMachineRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMSetTargetMachineAsmVerbosity",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void setTargetMachineAsmVerbosityNative(
            void* (* LLVMTargetMachineRef *) T,
            bool VerboseAsm)
        let setTargetMachineAsmVerbosity _T _VerboseAsm =
            setTargetMachineAsmVerbosityNative ((_T : TargetMachineRef).Ptr, _VerboseAsm)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMTargetMachineEmitToFile",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool targetMachineEmitToFileNative(
            void* (* LLVMTargetMachineRef *) T,
            void* (* LLVMModuleRef *) M,
            string Filename,
            int (* LLVMCodeGenFileType *) codegen,
            void* (* char** *) ErrorMessage)
        // I don't know how to generate an "F# friendly" version of LLVMTargetMachineEmitToFile

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMTargetMachineEmitToMemoryBuffer",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool targetMachineEmitToMemoryBufferNative(
            void* (* LLVMTargetMachineRef *) T,
            void* (* LLVMModuleRef *) M,
            int (* LLVMCodeGenFileType *) codegen,
            void* (* char** *) ErrorMessage,
            void* (* LLVMMemoryBufferRef* *) OutMemBuf)
        // I don't know how to generate an "F# friendly" version of LLVMTargetMachineEmitToMemoryBuffer

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetDefaultTargetTriple",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* char* *) getDefaultTargetTripleNative()
        let getDefaultTargetTriple () =
            Marshal.PtrToStringAuto (getDefaultTargetTripleNative ())

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddAnalysisPasses",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addAnalysisPassesNative(
            void* (* LLVMTargetMachineRef *) T,
            void* (* LLVMPassManagerRef *) PM)
        let addAnalysisPasses _T _PM =
            addAnalysisPassesNative ((_T : TargetMachineRef).Ptr, (_PM : PassManagerRef).Ptr)

// This file should not be edited. It is automatically generated from a C header file
namespace LLVM.Generated

    open LLVM.FFIUtil
    open System.Runtime.InteropServices
    open LLVM.Generated.Core
    open LLVM.Generated.Target
    open LLVM.Generated.TargetMachine

    module ExecutionEngine =

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMLinkInMCJIT",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void linkInMCJITNative()
        let linkInMCJIT () =
            linkInMCJITNative ()

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMLinkInInterpreter",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void linkInInterpreterNative()
        let linkInInterpreter () =
            linkInInterpreterNative ()

        type GenericValueRef (thePtr : nativeint) =
            member x.Ptr = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr = thePtr

        type ExecutionEngineRef (thePtr : nativeint) =
            member x.Ptr = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr = thePtr

        type MCJITMemoryManagerRef (thePtr : nativeint) =
            member x.Ptr = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr = thePtr

        [<Struct>]
        type MCJITCompilerOptions =
            val mutable OptLevel : uint32
            val mutable CodeModel : CodeModel (* LLVMCodeModel *)
            val mutable NoFramePointerElim : bool
            val mutable EnableFastISel : bool
            val mutable MCJMM : nativeint (* LLVMMCJITMemoryManagerRef *)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMCreateGenericValueOfInt",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMGenericValueRef *) createGenericValueOfIntNative(
            void* (* LLVMTypeRef *) Ty,
            uint64 N,
            bool IsSigned)
        let createGenericValueOfInt _Ty _N _IsSigned =
            new GenericValueRef (createGenericValueOfIntNative ((_Ty : TypeRef).Ptr, _N, _IsSigned))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMCreateGenericValueOfPointer",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMGenericValueRef *) createGenericValueOfPointerNative(
            void* P)
        let createGenericValueOfPointer _P =
            new GenericValueRef (createGenericValueOfPointerNative ((_P : nativeint)))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMCreateGenericValueOfFloat",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMGenericValueRef *) createGenericValueOfFloatNative(
            void* (* LLVMTypeRef *) Ty,
            double N)
        let createGenericValueOfFloat _Ty _N =
            new GenericValueRef (createGenericValueOfFloatNative ((_Ty : TypeRef).Ptr, _N))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGenericValueIntWidth",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 genericValueIntWidthNative(
            void* (* LLVMGenericValueRef *) GenValRef)
        let genericValueIntWidth _GenValRef =
            genericValueIntWidthNative ((_GenValRef : GenericValueRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGenericValueToInt",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint64 genericValueToIntNative(
            void* (* LLVMGenericValueRef *) GenVal,
            bool IsSigned)
        let genericValueToInt _GenVal _IsSigned =
            genericValueToIntNative ((_GenVal : GenericValueRef).Ptr, _IsSigned)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGenericValueToPointer",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* genericValueToPointerNative(
            void* (* LLVMGenericValueRef *) GenVal)
        let genericValueToPointer _GenVal =
            genericValueToPointerNative ((_GenVal : GenericValueRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGenericValueToFloat",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern double genericValueToFloatNative(
            void* (* LLVMTypeRef *) TyRef,
            void* (* LLVMGenericValueRef *) GenVal)
        let genericValueToFloat _TyRef _GenVal =
            genericValueToFloatNative ((_TyRef : TypeRef).Ptr, (_GenVal : GenericValueRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMDisposeGenericValue",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void disposeGenericValueNative(
            void* (* LLVMGenericValueRef *) GenVal)
        let disposeGenericValue _GenVal =
            disposeGenericValueNative ((_GenVal : GenericValueRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMCreateExecutionEngineForModule",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool createExecutionEngineForModuleNative(
            void* (* LLVMExecutionEngineRef* *) OutEE,
            void* (* LLVMModuleRef *) M,
            void* (* char** *) OutError)
        // I don't know how to generate an "F# friendly" version of LLVMCreateExecutionEngineForModule

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMCreateInterpreterForModule",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool createInterpreterForModuleNative(
            void* (* LLVMExecutionEngineRef* *) OutInterp,
            void* (* LLVMModuleRef *) M,
            void* (* char** *) OutError)
        // I don't know how to generate an "F# friendly" version of LLVMCreateInterpreterForModule

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMCreateJITCompilerForModule",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool createJITCompilerForModuleNative(
            void* (* LLVMExecutionEngineRef* *) OutJIT,
            void* (* LLVMModuleRef *) M,
            uint32 OptLevel,
            void* (* char** *) OutError)
        // I don't know how to generate an "F# friendly" version of LLVMCreateJITCompilerForModule

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMInitializeMCJITCompilerOptions",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void initializeMCJITCompilerOptionsNative(
            MCJITCompilerOptions* Options,
            nativeint (* size_t *) SizeOfOptions)
        // I don't know how to generate an "F# friendly" version of LLVMInitializeMCJITCompilerOptions

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMCreateMCJITCompilerForModule",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool createMCJITCompilerForModuleNative(
            void* (* LLVMExecutionEngineRef* *) OutJIT,
            void* (* LLVMModuleRef *) M,
            MCJITCompilerOptions* Options,
            nativeint (* size_t *) SizeOfOptions,
            void* (* char** *) OutError)
        // I don't know how to generate an "F# friendly" version of LLVMCreateMCJITCompilerForModule

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMCreateExecutionEngine",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool createExecutionEngineNative(
            void* (* LLVMExecutionEngineRef* *) OutEE,
            void* (* LLVMModuleProviderRef *) MP,
            void* (* char** *) OutError)
        // I don't know how to generate an "F# friendly" version of LLVMCreateExecutionEngine

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMCreateInterpreter",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool createInterpreterNative(
            void* (* LLVMExecutionEngineRef* *) OutInterp,
            void* (* LLVMModuleProviderRef *) MP,
            void* (* char** *) OutError)
        // I don't know how to generate an "F# friendly" version of LLVMCreateInterpreter

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMCreateJITCompiler",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool createJITCompilerNative(
            void* (* LLVMExecutionEngineRef* *) OutJIT,
            void* (* LLVMModuleProviderRef *) MP,
            uint32 OptLevel,
            void* (* char** *) OutError)
        // I don't know how to generate an "F# friendly" version of LLVMCreateJITCompiler

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMDisposeExecutionEngine",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void disposeExecutionEngineNative(
            void* (* LLVMExecutionEngineRef *) EE)
        let disposeExecutionEngine _EE =
            disposeExecutionEngineNative ((_EE : ExecutionEngineRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMRunStaticConstructors",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void runStaticConstructorsNative(
            void* (* LLVMExecutionEngineRef *) EE)
        let runStaticConstructors _EE =
            runStaticConstructorsNative ((_EE : ExecutionEngineRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMRunStaticDestructors",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void runStaticDestructorsNative(
            void* (* LLVMExecutionEngineRef *) EE)
        let runStaticDestructors _EE =
            runStaticDestructorsNative ((_EE : ExecutionEngineRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMRunFunctionAsMain",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int runFunctionAsMainNative(
            void* (* LLVMExecutionEngineRef *) EE,
            void* (* LLVMValueRef *) F,
            uint32 ArgC,
            void* (* const char** *) ArgV,
            void* (* const char** *) EnvP)
        // I don't know how to generate an "F# friendly" version of LLVMRunFunctionAsMain

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMRunFunction",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMGenericValueRef *) runFunctionNative(
            void* (* LLVMExecutionEngineRef *) EE,
            void* (* LLVMValueRef *) F,
            uint32 NumArgs,
            void* (* LLVMGenericValueRef* *) Args)
        // I don't know how to generate an "F# friendly" version of LLVMRunFunction

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMFreeMachineCodeForFunction",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void freeMachineCodeForFunctionNative(
            void* (* LLVMExecutionEngineRef *) EE,
            void* (* LLVMValueRef *) F)
        let freeMachineCodeForFunction _EE _F =
            freeMachineCodeForFunctionNative ((_EE : ExecutionEngineRef).Ptr, (_F : ValueRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddModule",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addModuleNative(
            void* (* LLVMExecutionEngineRef *) EE,
            void* (* LLVMModuleRef *) M)
        let addModule _EE _M =
            addModuleNative ((_EE : ExecutionEngineRef).Ptr, (_M : ModuleRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddModuleProvider",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addModuleProviderNative(
            void* (* LLVMExecutionEngineRef *) EE,
            void* (* LLVMModuleProviderRef *) MP)
        let addModuleProvider _EE _MP =
            addModuleProviderNative ((_EE : ExecutionEngineRef).Ptr, (_MP : ModuleProviderRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMRemoveModule",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool removeModuleNative(
            void* (* LLVMExecutionEngineRef *) EE,
            void* (* LLVMModuleRef *) M,
            void* (* LLVMModuleRef* *) OutMod,
            void* (* char** *) OutError)
        // I don't know how to generate an "F# friendly" version of LLVMRemoveModule

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMRemoveModuleProvider",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool removeModuleProviderNative(
            void* (* LLVMExecutionEngineRef *) EE,
            void* (* LLVMModuleProviderRef *) MP,
            void* (* LLVMModuleRef* *) OutMod,
            void* (* char** *) OutError)
        // I don't know how to generate an "F# friendly" version of LLVMRemoveModuleProvider

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMFindFunction",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool findFunctionNative(
            void* (* LLVMExecutionEngineRef *) EE,
            string Name,
            void* (* LLVMValueRef* *) OutFn)
        // I don't know how to generate an "F# friendly" version of LLVMFindFunction

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMRecompileAndRelinkFunction",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* recompileAndRelinkFunctionNative(
            void* (* LLVMExecutionEngineRef *) EE,
            void* (* LLVMValueRef *) Fn)
        let recompileAndRelinkFunction _EE _Fn =
            recompileAndRelinkFunctionNative ((_EE : ExecutionEngineRef).Ptr, (_Fn : ValueRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetExecutionEngineTargetData",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTargetDataRef *) getExecutionEngineTargetDataNative(
            void* (* LLVMExecutionEngineRef *) EE)
        let getExecutionEngineTargetData _EE =
            new TargetDataRef (getExecutionEngineTargetDataNative ((_EE : ExecutionEngineRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetExecutionEngineTargetMachine",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTargetMachineRef *) getExecutionEngineTargetMachineNative(
            void* (* LLVMExecutionEngineRef *) EE)
        let getExecutionEngineTargetMachine _EE =
            new TargetMachineRef (getExecutionEngineTargetMachineNative ((_EE : ExecutionEngineRef).Ptr))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddGlobalMapping",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addGlobalMappingNative(
            void* (* LLVMExecutionEngineRef *) EE,
            void* (* LLVMValueRef *) Global,
            void* Addr)
        let addGlobalMapping _EE _Global _Addr =
            addGlobalMappingNative ((_EE : ExecutionEngineRef).Ptr, (_Global : ValueRef).Ptr, (_Addr : nativeint))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetPointerToGlobal",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* getPointerToGlobalNative(
            void* (* LLVMExecutionEngineRef *) EE,
            void* (* LLVMValueRef *) Global)
        let getPointerToGlobal _EE _Global =
            getPointerToGlobalNative ((_EE : ExecutionEngineRef).Ptr, (_Global : ValueRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetGlobalValueAddress",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint64 getGlobalValueAddressNative(
            void* (* LLVMExecutionEngineRef *) EE,
            string Name)
        let getGlobalValueAddress _EE _Name =
            getGlobalValueAddressNative ((_EE : ExecutionEngineRef).Ptr, _Name)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMGetFunctionAddress",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint64 getFunctionAddressNative(
            void* (* LLVMExecutionEngineRef *) EE,
            string Name)
        let getFunctionAddress _EE _Name =
            getFunctionAddressNative ((_EE : ExecutionEngineRef).Ptr, _Name)

        type MemoryManagerAllocateCodeSectionCallback = delegate of nativeint (* nativeptr<void> *) * unativeint (* uintptr_t *) * uint32 * uint32 * string -> nativeptr<uint8>

        type MemoryManagerAllocateDataSectionCallback = delegate of nativeint (* nativeptr<void> *) * unativeint (* uintptr_t *) * uint32 * uint32 * string * bool -> nativeptr<uint8>

        type MemoryManagerFinalizeMemoryCallback = delegate of nativeint (* nativeptr<void> *) * nativeint (* char** *) -> bool

        type MemoryManagerDestroyCallback = delegate of nativeint (* nativeptr<void> *) -> Unit

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMCreateSimpleMCJITMemoryManager",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMMCJITMemoryManagerRef *) createSimpleMCJITMemoryManagerNative(
            void* Opaque,
            MemoryManagerAllocateCodeSectionCallback (* function pointer *) AllocateCodeSection,
            MemoryManagerAllocateDataSectionCallback (* function pointer *) AllocateDataSection,
            MemoryManagerFinalizeMemoryCallback (* function pointer *) FinalizeMemory,
            MemoryManagerDestroyCallback (* function pointer *) Destroy)
        let createSimpleMCJITMemoryManager _Opaque _AllocateCodeSection _AllocateDataSection _FinalizeMemory _Destroy =
            new MCJITMemoryManagerRef (createSimpleMCJITMemoryManagerNative ((_Opaque : nativeint), _AllocateCodeSection, _AllocateDataSection, _FinalizeMemory, _Destroy))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMDisposeMCJITMemoryManager",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void disposeMCJITMemoryManagerNative(
            void* (* LLVMMCJITMemoryManagerRef *) MM)
        let disposeMCJITMemoryManager _MM =
            disposeMCJITMemoryManagerNative ((_MM : MCJITMemoryManagerRef).Ptr)

// This file should not be edited. It is automatically generated from a C header file
namespace LLVM.Generated

    open LLVM.FFIUtil
    open System.Runtime.InteropServices
    open LLVM.Generated.Core

    module Analysis =

        type VerifierFailureAction =
            | AbortProcessAction = 0
            | PrintMessageAction = 1
            | ReturnStatusAction = 2

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMVerifyModule",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool verifyModuleNative(
            void* (* LLVMModuleRef *) M,
            int (* LLVMVerifierFailureAction *) Action,
            void* (* char** *) OutMessage)
        // I don't know how to generate an "F# friendly" version of LLVMVerifyModule

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMVerifyFunction",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool verifyFunctionNative(
            void* (* LLVMValueRef *) Fn,
            int (* LLVMVerifierFailureAction *) Action)
        let verifyFunction _Fn _Action =
            verifyFunctionNative ((_Fn : ValueRef).Ptr, (int (_Action : VerifierFailureAction)))

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMViewFunctionCFG",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void viewFunctionCFGNative(
            void* (* LLVMValueRef *) Fn)
        let viewFunctionCFG _Fn =
            viewFunctionCFGNative ((_Fn : ValueRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMViewFunctionCFGOnly",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void viewFunctionCFGOnlyNative(
            void* (* LLVMValueRef *) Fn)
        let viewFunctionCFGOnly _Fn =
            viewFunctionCFGOnlyNative ((_Fn : ValueRef).Ptr)

// This file should not be edited. It is automatically generated from a C header file
namespace LLVM.Generated.Transforms

    open LLVM.FFIUtil
    open System.Runtime.InteropServices
    open LLVM.Generated.Core

    module Scalar =

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddAggressiveDCEPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addAggressiveDCEPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addAggressiveDCEPass _PM =
            addAggressiveDCEPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddAlignmentFromAssumptionsPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addAlignmentFromAssumptionsPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addAlignmentFromAssumptionsPass _PM =
            addAlignmentFromAssumptionsPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddCFGSimplificationPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addCFGSimplificationPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addCFGSimplificationPass _PM =
            addCFGSimplificationPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddDeadStoreEliminationPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addDeadStoreEliminationPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addDeadStoreEliminationPass _PM =
            addDeadStoreEliminationPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddScalarizerPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addScalarizerPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addScalarizerPass _PM =
            addScalarizerPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddMergedLoadStoreMotionPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addMergedLoadStoreMotionPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addMergedLoadStoreMotionPass _PM =
            addMergedLoadStoreMotionPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddGVNPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addGVNPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addGVNPass _PM =
            addGVNPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddIndVarSimplifyPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addIndVarSimplifyPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addIndVarSimplifyPass _PM =
            addIndVarSimplifyPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddInstructionCombiningPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addInstructionCombiningPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addInstructionCombiningPass _PM =
            addInstructionCombiningPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddJumpThreadingPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addJumpThreadingPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addJumpThreadingPass _PM =
            addJumpThreadingPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddLICMPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addLICMPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addLICMPass _PM =
            addLICMPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddLoopDeletionPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addLoopDeletionPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addLoopDeletionPass _PM =
            addLoopDeletionPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddLoopIdiomPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addLoopIdiomPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addLoopIdiomPass _PM =
            addLoopIdiomPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddLoopRotatePass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addLoopRotatePassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addLoopRotatePass _PM =
            addLoopRotatePassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddLoopRerollPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addLoopRerollPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addLoopRerollPass _PM =
            addLoopRerollPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddLoopUnrollPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addLoopUnrollPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addLoopUnrollPass _PM =
            addLoopUnrollPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddLoopUnswitchPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addLoopUnswitchPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addLoopUnswitchPass _PM =
            addLoopUnswitchPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddMemCpyOptPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addMemCpyOptPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addMemCpyOptPass _PM =
            addMemCpyOptPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddPartiallyInlineLibCallsPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addPartiallyInlineLibCallsPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addPartiallyInlineLibCallsPass _PM =
            addPartiallyInlineLibCallsPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddLowerSwitchPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addLowerSwitchPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addLowerSwitchPass _PM =
            addLowerSwitchPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddPromoteMemoryToRegisterPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addPromoteMemoryToRegisterPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addPromoteMemoryToRegisterPass _PM =
            addPromoteMemoryToRegisterPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddReassociatePass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addReassociatePassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addReassociatePass _PM =
            addReassociatePassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddSCCPPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addSCCPPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addSCCPPass _PM =
            addSCCPPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddScalarReplAggregatesPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addScalarReplAggregatesPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addScalarReplAggregatesPass _PM =
            addScalarReplAggregatesPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddScalarReplAggregatesPassSSA",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addScalarReplAggregatesPassSSANative(
            void* (* LLVMPassManagerRef *) PM)
        let addScalarReplAggregatesPassSSA _PM =
            addScalarReplAggregatesPassSSANative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddScalarReplAggregatesPassWithThreshold",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addScalarReplAggregatesPassWithThresholdNative(
            void* (* LLVMPassManagerRef *) PM,
            int Threshold)
        let addScalarReplAggregatesPassWithThreshold _PM _Threshold =
            addScalarReplAggregatesPassWithThresholdNative ((_PM : PassManagerRef).Ptr, _Threshold)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddSimplifyLibCallsPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addSimplifyLibCallsPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addSimplifyLibCallsPass _PM =
            addSimplifyLibCallsPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddTailCallEliminationPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addTailCallEliminationPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addTailCallEliminationPass _PM =
            addTailCallEliminationPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddConstantPropagationPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addConstantPropagationPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addConstantPropagationPass _PM =
            addConstantPropagationPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddDemoteMemoryToRegisterPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addDemoteMemoryToRegisterPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addDemoteMemoryToRegisterPass _PM =
            addDemoteMemoryToRegisterPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddVerifierPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addVerifierPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addVerifierPass _PM =
            addVerifierPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddCorrelatedValuePropagationPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addCorrelatedValuePropagationPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addCorrelatedValuePropagationPass _PM =
            addCorrelatedValuePropagationPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddEarlyCSEPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addEarlyCSEPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addEarlyCSEPass _PM =
            addEarlyCSEPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddLowerExpectIntrinsicPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addLowerExpectIntrinsicPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addLowerExpectIntrinsicPass _PM =
            addLowerExpectIntrinsicPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddTypeBasedAliasAnalysisPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addTypeBasedAliasAnalysisPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addTypeBasedAliasAnalysisPass _PM =
            addTypeBasedAliasAnalysisPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddScopedNoAliasAAPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addScopedNoAliasAAPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addScopedNoAliasAAPass _PM =
            addScopedNoAliasAAPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddBasicAliasAnalysisPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addBasicAliasAnalysisPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addBasicAliasAnalysisPass _PM =
            addBasicAliasAnalysisPassNative ((_PM : PassManagerRef).Ptr)

// This file should not be edited. It is automatically generated from a C header file
namespace LLVM.Generated.Transforms

    open LLVM.FFIUtil
    open System.Runtime.InteropServices
    open LLVM.Generated.Core

    module IPO =

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddArgumentPromotionPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addArgumentPromotionPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addArgumentPromotionPass _PM =
            addArgumentPromotionPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddConstantMergePass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addConstantMergePassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addConstantMergePass _PM =
            addConstantMergePassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddDeadArgEliminationPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addDeadArgEliminationPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addDeadArgEliminationPass _PM =
            addDeadArgEliminationPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddFunctionAttrsPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addFunctionAttrsPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addFunctionAttrsPass _PM =
            addFunctionAttrsPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddFunctionInliningPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addFunctionInliningPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addFunctionInliningPass _PM =
            addFunctionInliningPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddAlwaysInlinerPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addAlwaysInlinerPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addAlwaysInlinerPass _PM =
            addAlwaysInlinerPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddGlobalDCEPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addGlobalDCEPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addGlobalDCEPass _PM =
            addGlobalDCEPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddGlobalOptimizerPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addGlobalOptimizerPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addGlobalOptimizerPass _PM =
            addGlobalOptimizerPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddIPConstantPropagationPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addIPConstantPropagationPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addIPConstantPropagationPass _PM =
            addIPConstantPropagationPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddPruneEHPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addPruneEHPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addPruneEHPass _PM =
            addPruneEHPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddIPSCCPPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addIPSCCPPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addIPSCCPPass _PM =
            addIPSCCPPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddInternalizePass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addInternalizePassNative(
            void* (* LLVMPassManagerRef *) arg0,
            uint32 AllButMain)
        let addInternalizePass _arg0 _AllButMain =
            addInternalizePassNative ((_arg0 : PassManagerRef).Ptr, _AllButMain)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddStripDeadPrototypesPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addStripDeadPrototypesPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addStripDeadPrototypesPass _PM =
            addStripDeadPrototypesPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            llvmAssemblyName,
            EntryPoint="LLVMAddStripSymbolsPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addStripSymbolsPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addStripSymbolsPass _PM =
            addStripSymbolsPassNative ((_PM : PassManagerRef).Ptr)

// This file should not be edited. It is automatically generated from a C header file
namespace Clang.Generated

    open LLVM.FFIUtil
    open System.Runtime.InteropServices

    module CXString =

        [<Struct>]
        type CXString =
            val mutable data : nativeint (* nativeptr<void> *)
            val mutable private_flags : uint32

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getCString",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* getCStringNative(
            CXString _string)
        let getCString _string =
            Marshal.PtrToStringAuto (getCStringNative ((_string : CXString)))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_disposeString",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void disposeStringNative(
            CXString _string)
        let disposeString _string =
            disposeStringNative ((_string : CXString))

// This file should not be edited. It is automatically generated from a C header file
namespace Clang.Generated

    open LLVM.FFIUtil
    open System.Runtime.InteropServices

    module CXErrorCode =

        type CXErrorCode =
            | CXError_Success = 0
            | CXError_Failure = 1
            | CXError_Crashed = 2
            | CXError_InvalidArguments = 3
            | CXError_ASTReadError = 4

// This file should not be edited. It is automatically generated from a C header file
namespace Clang.Generated

    open LLVM.FFIUtil
    open System.Runtime.InteropServices
    open Clang.Generated.CXString

    module CXCompilationDatabase =

        type CXCompilationDatabase (thePtr : nativeint) =
            member x.Ptr = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr = thePtr

        type CXCompileCommands (thePtr : nativeint) =
            member x.Ptr = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr = thePtr

        type CXCompileCommand (thePtr : nativeint) =
            member x.Ptr = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr = thePtr

        type CXCompilationDatabase_Error =
            | CXCompilationDatabase_NoError = 0
            | CXCompilationDatabase_CanNotLoadDatabase = 1

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_CompilationDatabase_fromDirectory",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* CXCompilationDatabase *) compilationDatabase_fromDirectoryNative(
            string BuildDir,
            int (* CXCompilationDatabase_Error* *)* ErrorCode)
        // I don't know how to generate an "F# friendly" version of clang_CompilationDatabase_fromDirectory

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_CompilationDatabase_dispose",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void compilationDatabase_disposeNative(
            void* (* CXCompilationDatabase *) arg0)
        let compilationDatabase_dispose _arg0 =
            compilationDatabase_disposeNative ((_arg0 : CXCompilationDatabase).Ptr)

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_CompilationDatabase_getCompileCommands",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* CXCompileCommands *) compilationDatabase_getCompileCommandsNative(
            void* (* CXCompilationDatabase *) arg0,
            string CompleteFileName)
        let compilationDatabase_getCompileCommands _arg0 _CompleteFileName =
            new CXCompileCommands (compilationDatabase_getCompileCommandsNative ((_arg0 : CXCompilationDatabase).Ptr, _CompleteFileName))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_CompilationDatabase_getAllCompileCommands",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* CXCompileCommands *) compilationDatabase_getAllCompileCommandsNative(
            void* (* CXCompilationDatabase *) arg0)
        let compilationDatabase_getAllCompileCommands _arg0 =
            new CXCompileCommands (compilationDatabase_getAllCompileCommandsNative ((_arg0 : CXCompilationDatabase).Ptr))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_CompileCommands_dispose",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void compileCommands_disposeNative(
            void* (* CXCompileCommands *) arg0)
        let compileCommands_dispose _arg0 =
            compileCommands_disposeNative ((_arg0 : CXCompileCommands).Ptr)

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_CompileCommands_getSize",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 compileCommands_getSizeNative(
            void* (* CXCompileCommands *) arg0)
        let compileCommands_getSize _arg0 =
            compileCommands_getSizeNative ((_arg0 : CXCompileCommands).Ptr)

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_CompileCommands_getCommand",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* CXCompileCommand *) compileCommands_getCommandNative(
            void* (* CXCompileCommands *) arg0,
            uint32 I)
        let compileCommands_getCommand _arg0 _I =
            new CXCompileCommand (compileCommands_getCommandNative ((_arg0 : CXCompileCommands).Ptr, _I))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_CompileCommand_getDirectory",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXString compileCommand_getDirectoryNative(
            void* (* CXCompileCommand *) arg0)
        let compileCommand_getDirectory _arg0 =
            compileCommand_getDirectoryNative ((_arg0 : CXCompileCommand).Ptr)

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_CompileCommand_getNumArgs",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 compileCommand_getNumArgsNative(
            void* (* CXCompileCommand *) arg0)
        let compileCommand_getNumArgs _arg0 =
            compileCommand_getNumArgsNative ((_arg0 : CXCompileCommand).Ptr)

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_CompileCommand_getArg",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXString compileCommand_getArgNative(
            void* (* CXCompileCommand *) arg0,
            uint32 I)
        let compileCommand_getArg _arg0 _I =
            compileCommand_getArgNative ((_arg0 : CXCompileCommand).Ptr, _I)

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_CompileCommand_getNumMappedSources",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 compileCommand_getNumMappedSourcesNative(
            void* (* CXCompileCommand *) arg0)
        let compileCommand_getNumMappedSources _arg0 =
            compileCommand_getNumMappedSourcesNative ((_arg0 : CXCompileCommand).Ptr)

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_CompileCommand_getMappedSourcePath",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXString compileCommand_getMappedSourcePathNative(
            void* (* CXCompileCommand *) arg0,
            uint32 I)
        let compileCommand_getMappedSourcePath _arg0 _I =
            compileCommand_getMappedSourcePathNative ((_arg0 : CXCompileCommand).Ptr, _I)

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_CompileCommand_getMappedSourceContent",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXString compileCommand_getMappedSourceContentNative(
            void* (* CXCompileCommand *) arg0,
            uint32 I)
        let compileCommand_getMappedSourceContent _arg0 _I =
            compileCommand_getMappedSourceContentNative ((_arg0 : CXCompileCommand).Ptr, _I)

// This file should not be edited. It is automatically generated from a C header file
namespace Clang.Generated

    open LLVM.FFIUtil
    open System.Runtime.InteropServices
    open Clang.Generated.CXString
    open Clang.Generated.CXErrorCode

    module BuildSystem =

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getBuildSessionTimestamp",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint64 getBuildSessionTimestampNative()
        let getBuildSessionTimestamp () =
            getBuildSessionTimestampNative ()

        type CXVirtualFileOverlay (thePtr : nativeint) =
            member x.Ptr = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr = thePtr

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_VirtualFileOverlay_create",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* CXVirtualFileOverlay *) virtualFileOverlay_createNative(
            uint32 options)
        let virtualFileOverlay_create _options =
            new CXVirtualFileOverlay (virtualFileOverlay_createNative (_options))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_VirtualFileOverlay_addFileMapping",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int (* CXErrorCode *) virtualFileOverlay_addFileMappingNative(
            void* (* CXVirtualFileOverlay *) arg0,
            string virtualPath,
            string realPath)
        let virtualFileOverlay_addFileMapping _arg0 _virtualPath _realPath =
            enum<CXErrorCode> (virtualFileOverlay_addFileMappingNative ((_arg0 : CXVirtualFileOverlay).Ptr, _virtualPath, _realPath))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_VirtualFileOverlay_setCaseSensitivity",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int (* CXErrorCode *) virtualFileOverlay_setCaseSensitivityNative(
            void* (* CXVirtualFileOverlay *) arg0,
            int caseSensitive)
        let virtualFileOverlay_setCaseSensitivity _arg0 _caseSensitive =
            enum<CXErrorCode> (virtualFileOverlay_setCaseSensitivityNative ((_arg0 : CXVirtualFileOverlay).Ptr, _caseSensitive))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_VirtualFileOverlay_writeToBuffer",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int (* CXErrorCode *) virtualFileOverlay_writeToBufferNative(
            void* (* CXVirtualFileOverlay *) arg0,
            uint32 options,
            void* out_buffer_ptr,
            uint32* out_buffer_size)
        // I don't know how to generate an "F# friendly" version of clang_VirtualFileOverlay_writeToBuffer

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_VirtualFileOverlay_dispose",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void virtualFileOverlay_disposeNative(
            void* (* CXVirtualFileOverlay *) arg0)
        let virtualFileOverlay_dispose _arg0 =
            virtualFileOverlay_disposeNative ((_arg0 : CXVirtualFileOverlay).Ptr)

        type CXModuleMapDescriptor (thePtr : nativeint) =
            member x.Ptr = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr = thePtr

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_ModuleMapDescriptor_create",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* CXModuleMapDescriptor *) moduleMapDescriptor_createNative(
            uint32 options)
        let moduleMapDescriptor_create _options =
            new CXModuleMapDescriptor (moduleMapDescriptor_createNative (_options))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_ModuleMapDescriptor_setFrameworkModuleName",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int (* CXErrorCode *) moduleMapDescriptor_setFrameworkModuleNameNative(
            void* (* CXModuleMapDescriptor *) arg0,
            string name)
        let moduleMapDescriptor_setFrameworkModuleName _arg0 _name =
            enum<CXErrorCode> (moduleMapDescriptor_setFrameworkModuleNameNative ((_arg0 : CXModuleMapDescriptor).Ptr, _name))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_ModuleMapDescriptor_setUmbrellaHeader",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int (* CXErrorCode *) moduleMapDescriptor_setUmbrellaHeaderNative(
            void* (* CXModuleMapDescriptor *) arg0,
            string name)
        let moduleMapDescriptor_setUmbrellaHeader _arg0 _name =
            enum<CXErrorCode> (moduleMapDescriptor_setUmbrellaHeaderNative ((_arg0 : CXModuleMapDescriptor).Ptr, _name))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_ModuleMapDescriptor_writeToBuffer",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int (* CXErrorCode *) moduleMapDescriptor_writeToBufferNative(
            void* (* CXModuleMapDescriptor *) arg0,
            uint32 options,
            void* out_buffer_ptr,
            uint32* out_buffer_size)
        // I don't know how to generate an "F# friendly" version of clang_ModuleMapDescriptor_writeToBuffer

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_ModuleMapDescriptor_dispose",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void moduleMapDescriptor_disposeNative(
            void* (* CXModuleMapDescriptor *) arg0)
        let moduleMapDescriptor_dispose _arg0 =
            moduleMapDescriptor_disposeNative ((_arg0 : CXModuleMapDescriptor).Ptr)

// This file should not be edited. It is automatically generated from a C header file
namespace Clang.Generated

    open LLVM.FFIUtil
    open System.Runtime.InteropServices
    open Clang.Generated.CXString
    open Clang.Generated.CXErrorCode
    open Clang.Generated.BuildSystem

    module Index =

        type CXIndex (thePtr : nativeint) =
            member x.Ptr = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr = thePtr

        type CXTranslationUnit (thePtr : nativeint) =
            member x.Ptr = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr = thePtr

        type CXClientData (thePtr : nativeint) =
            member x.Ptr = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr = thePtr

        [<Struct>]
        type CXUnsavedFile =
            val mutable Filename : nativeint
            val mutable Contents : nativeint
            val mutable Length : uint64

        type CXAvailabilityKind =
            | CXAvailability_Available = 0
            | CXAvailability_Deprecated = 1
            | CXAvailability_NotAvailable = 2
            | CXAvailability_NotAccessible = 3

        [<Struct>]
        type CXVersion =
            val mutable Major : int
            val mutable Minor : int
            val mutable Subminor : int

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_createIndex",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* CXIndex *) createIndexNative(
            int excludeDeclarationsFromPCH,
            int displayDiagnostics)
        let createIndex _excludeDeclarationsFromPCH _displayDiagnostics =
            new CXIndex (createIndexNative (_excludeDeclarationsFromPCH, _displayDiagnostics))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_disposeIndex",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void disposeIndexNative(
            void* (* CXIndex *) index)
        let disposeIndex _index =
            disposeIndexNative ((_index : CXIndex).Ptr)

        type CXGlobalOptFlags =
            | CXGlobalOpt_None = 0
            | CXGlobalOpt_ThreadBackgroundPriorityForIndexing = 1
            | CXGlobalOpt_ThreadBackgroundPriorityForEditing = 2
            | CXGlobalOpt_ThreadBackgroundPriorityForAll = 3

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_CXIndex_setGlobalOptions",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void cXIndex_setGlobalOptionsNative(
            void* (* CXIndex *) arg0,
            uint32 options)
        let cXIndex_setGlobalOptions _arg0 _options =
            cXIndex_setGlobalOptionsNative ((_arg0 : CXIndex).Ptr, _options)

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_CXIndex_getGlobalOptions",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 cXIndex_getGlobalOptionsNative(
            void* (* CXIndex *) arg0)
        let cXIndex_getGlobalOptions _arg0 =
            cXIndex_getGlobalOptionsNative ((_arg0 : CXIndex).Ptr)

        type CXFile (thePtr : nativeint) =
            member x.Ptr = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr = thePtr

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getFileName",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXString getFileNameNative(
            void* (* CXFile *) SFile)
        let getFileName _SFile =
            getFileNameNative ((_SFile : CXFile).Ptr)

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getFileTime",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint64 (* time_t *) getFileTimeNative(
            void* (* CXFile *) SFile)
        let getFileTime _SFile =
            getFileTimeNative ((_SFile : CXFile).Ptr)

        [<Struct>]
        type CXFileUniqueID =
            val mutable data0 : uint64
            val mutable data1 : uint64
            val mutable data2 : uint64

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getFileUniqueID",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int getFileUniqueIDNative(
            void* (* CXFile *) file,
            CXFileUniqueID outID)
        // I don't know how to generate an "F# friendly" version of clang_getFileUniqueID

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_isFileMultipleIncludeGuarded",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 isFileMultipleIncludeGuardedNative(
            void* (* CXTranslationUnit *) tu,
            void* (* CXFile *) file)
        let isFileMultipleIncludeGuarded _tu _file =
            isFileMultipleIncludeGuardedNative ((_tu : CXTranslationUnit).Ptr, (_file : CXFile).Ptr)

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getFile",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* CXFile *) getFileNative(
            void* (* CXTranslationUnit *) tu,
            string file_name)
        let getFile _tu _file_name =
            new CXFile (getFileNative ((_tu : CXTranslationUnit).Ptr, _file_name))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_File_isEqual",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int file_isEqualNative(
            void* (* CXFile *) file1,
            void* (* CXFile *) file2)
        let file_isEqual _file1 _file2 =
            file_isEqualNative ((_file1 : CXFile).Ptr, (_file2 : CXFile).Ptr)

        [<Struct>]
        type CXSourceLocation =
            val mutable ptr_data0 : nativeint (* nativeptr<void> *)
            val mutable ptr_data1 : nativeint (* nativeptr<void> *)
            val mutable int_data : uint32

        [<Struct>]
        type CXSourceRange =
            val mutable ptr_data0 : nativeint (* nativeptr<void> *)
            val mutable ptr_data1 : nativeint (* nativeptr<void> *)
            val mutable begin_int_data : uint32
            val mutable end_int_data : uint32

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getNullLocation",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXSourceLocation getNullLocationNative()
        let getNullLocation () =
            getNullLocationNative ()

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_equalLocations",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 equalLocationsNative(
            CXSourceLocation loc1,
            CXSourceLocation loc2)
        let equalLocations _loc1 _loc2 =
            equalLocationsNative ((_loc1 : CXSourceLocation), (_loc2 : CXSourceLocation))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getLocation",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXSourceLocation getLocationNative(
            void* (* CXTranslationUnit *) tu,
            void* (* CXFile *) file,
            uint32 line,
            uint32 column)
        let getLocation _tu _file _line _column =
            getLocationNative ((_tu : CXTranslationUnit).Ptr, (_file : CXFile).Ptr, _line, _column)

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getLocationForOffset",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXSourceLocation getLocationForOffsetNative(
            void* (* CXTranslationUnit *) tu,
            void* (* CXFile *) file,
            uint32 offset)
        let getLocationForOffset _tu _file _offset =
            getLocationForOffsetNative ((_tu : CXTranslationUnit).Ptr, (_file : CXFile).Ptr, _offset)

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_Location_isInSystemHeader",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int location_isInSystemHeaderNative(
            CXSourceLocation location)
        let location_isInSystemHeader _location =
            location_isInSystemHeaderNative ((_location : CXSourceLocation))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_Location_isFromMainFile",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int location_isFromMainFileNative(
            CXSourceLocation location)
        let location_isFromMainFile _location =
            location_isFromMainFileNative ((_location : CXSourceLocation))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getNullRange",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXSourceRange getNullRangeNative()
        let getNullRange () =
            getNullRangeNative ()

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getRange",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXSourceRange getRangeNative(
            CXSourceLocation _begin,
            CXSourceLocation _end)
        let getRange _begin _end =
            getRangeNative ((_begin : CXSourceLocation), (_end : CXSourceLocation))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_equalRanges",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 equalRangesNative(
            CXSourceRange range1,
            CXSourceRange range2)
        let equalRanges _range1 _range2 =
            equalRangesNative ((_range1 : CXSourceRange), (_range2 : CXSourceRange))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_Range_isNull",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int range_isNullNative(
            CXSourceRange range)
        let range_isNull _range =
            range_isNullNative ((_range : CXSourceRange))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getExpansionLocation",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void getExpansionLocationNative(
            CXSourceLocation location,
            void* (* CXFile* *) file,
            uint32* line,
            uint32* column,
            uint32* offset)
        // I don't know how to generate an "F# friendly" version of clang_getExpansionLocation

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getPresumedLocation",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void getPresumedLocationNative(
            CXSourceLocation location,
            CXString filename,
            uint32* line,
            uint32* column)
        // I don't know how to generate an "F# friendly" version of clang_getPresumedLocation

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getInstantiationLocation",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void getInstantiationLocationNative(
            CXSourceLocation location,
            void* (* CXFile* *) file,
            uint32* line,
            uint32* column,
            uint32* offset)
        // I don't know how to generate an "F# friendly" version of clang_getInstantiationLocation

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getSpellingLocation",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void getSpellingLocationNative(
            CXSourceLocation location,
            void* (* CXFile* *) file,
            uint32* line,
            uint32* column,
            uint32* offset)
        // I don't know how to generate an "F# friendly" version of clang_getSpellingLocation

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getFileLocation",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void getFileLocationNative(
            CXSourceLocation location,
            void* (* CXFile* *) file,
            uint32* line,
            uint32* column,
            uint32* offset)
        // I don't know how to generate an "F# friendly" version of clang_getFileLocation

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getRangeStart",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXSourceLocation getRangeStartNative(
            CXSourceRange range)
        let getRangeStart _range =
            getRangeStartNative ((_range : CXSourceRange))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getRangeEnd",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXSourceLocation getRangeEndNative(
            CXSourceRange range)
        let getRangeEnd _range =
            getRangeEndNative ((_range : CXSourceRange))

        [<Struct>]
        type CXSourceRangeList =
            val mutable count : uint32
            val mutable ranges : CXSourceRange

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getSkippedRanges",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXSourceRangeList getSkippedRangesNative(
            void* (* CXTranslationUnit *) tu,
            void* (* CXFile *) file)
        // I don't know how to generate an "F# friendly" version of clang_getSkippedRanges

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_disposeSourceRangeList",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void disposeSourceRangeListNative(
            CXSourceRangeList ranges)
        // I don't know how to generate an "F# friendly" version of clang_disposeSourceRangeList

        type CXDiagnosticSeverity =
            | CXDiagnostic_Ignored = 0
            | CXDiagnostic_Note = 1
            | CXDiagnostic_Warning = 2
            | CXDiagnostic_Error = 3
            | CXDiagnostic_Fatal = 4

        type CXDiagnostic (thePtr : nativeint) =
            member x.Ptr = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr = thePtr

        type CXDiagnosticSet (thePtr : nativeint) =
            member x.Ptr = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr = thePtr

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getNumDiagnosticsInSet",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 getNumDiagnosticsInSetNative(
            void* (* CXDiagnosticSet *) Diags)
        let getNumDiagnosticsInSet _Diags =
            getNumDiagnosticsInSetNative ((_Diags : CXDiagnosticSet).Ptr)

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getDiagnosticInSet",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* CXDiagnostic *) getDiagnosticInSetNative(
            void* (* CXDiagnosticSet *) Diags,
            uint32 Index)
        let getDiagnosticInSet _Diags _Index =
            new CXDiagnostic (getDiagnosticInSetNative ((_Diags : CXDiagnosticSet).Ptr, _Index))

        type CXLoadDiag_Error =
            | CXLoadDiag_None = 0
            | CXLoadDiag_Unknown = 1
            | CXLoadDiag_CannotLoad = 2
            | CXLoadDiag_InvalidFile = 3

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_loadDiagnostics",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* CXDiagnosticSet *) loadDiagnosticsNative(
            string file,
            int (* CXLoadDiag_Error* *)* error,
            CXString errorString)
        // I don't know how to generate an "F# friendly" version of clang_loadDiagnostics

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_disposeDiagnosticSet",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void disposeDiagnosticSetNative(
            void* (* CXDiagnosticSet *) Diags)
        let disposeDiagnosticSet _Diags =
            disposeDiagnosticSetNative ((_Diags : CXDiagnosticSet).Ptr)

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getChildDiagnostics",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* CXDiagnosticSet *) getChildDiagnosticsNative(
            void* (* CXDiagnostic *) D)
        let getChildDiagnostics _D =
            new CXDiagnosticSet (getChildDiagnosticsNative ((_D : CXDiagnostic).Ptr))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getNumDiagnostics",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 getNumDiagnosticsNative(
            void* (* CXTranslationUnit *) Unit)
        let getNumDiagnostics _Unit =
            getNumDiagnosticsNative ((_Unit : CXTranslationUnit).Ptr)

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getDiagnostic",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* CXDiagnostic *) getDiagnosticNative(
            void* (* CXTranslationUnit *) Unit,
            uint32 Index)
        let getDiagnostic _Unit _Index =
            new CXDiagnostic (getDiagnosticNative ((_Unit : CXTranslationUnit).Ptr, _Index))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getDiagnosticSetFromTU",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* CXDiagnosticSet *) getDiagnosticSetFromTUNative(
            void* (* CXTranslationUnit *) Unit)
        let getDiagnosticSetFromTU _Unit =
            new CXDiagnosticSet (getDiagnosticSetFromTUNative ((_Unit : CXTranslationUnit).Ptr))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_disposeDiagnostic",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void disposeDiagnosticNative(
            void* (* CXDiagnostic *) Diagnostic)
        let disposeDiagnostic _Diagnostic =
            disposeDiagnosticNative ((_Diagnostic : CXDiagnostic).Ptr)

        type CXDiagnosticDisplayOptions =
            | CXDiagnostic_DisplaySourceLocation = 1
            | CXDiagnostic_DisplayColumn = 2
            | CXDiagnostic_DisplaySourceRanges = 4
            | CXDiagnostic_DisplayOption = 8
            | CXDiagnostic_DisplayCategoryId = 16
            | CXDiagnostic_DisplayCategoryName = 32

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_formatDiagnostic",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXString formatDiagnosticNative(
            void* (* CXDiagnostic *) Diagnostic,
            uint32 Options)
        let formatDiagnostic _Diagnostic _Options =
            formatDiagnosticNative ((_Diagnostic : CXDiagnostic).Ptr, _Options)

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_defaultDiagnosticDisplayOptions",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 defaultDiagnosticDisplayOptionsNative()
        let defaultDiagnosticDisplayOptions () =
            defaultDiagnosticDisplayOptionsNative ()

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getDiagnosticSeverity",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int (* CXDiagnosticSeverity *) getDiagnosticSeverityNative(
            void* (* CXDiagnostic *) arg0)
        let getDiagnosticSeverity _arg0 =
            enum<CXDiagnosticSeverity> (getDiagnosticSeverityNative ((_arg0 : CXDiagnostic).Ptr))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getDiagnosticLocation",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXSourceLocation getDiagnosticLocationNative(
            void* (* CXDiagnostic *) arg0)
        let getDiagnosticLocation _arg0 =
            getDiagnosticLocationNative ((_arg0 : CXDiagnostic).Ptr)

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getDiagnosticSpelling",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXString getDiagnosticSpellingNative(
            void* (* CXDiagnostic *) arg0)
        let getDiagnosticSpelling _arg0 =
            getDiagnosticSpellingNative ((_arg0 : CXDiagnostic).Ptr)

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getDiagnosticOption",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXString getDiagnosticOptionNative(
            void* (* CXDiagnostic *) Diag,
            CXString Disable)
        // I don't know how to generate an "F# friendly" version of clang_getDiagnosticOption

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getDiagnosticCategory",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 getDiagnosticCategoryNative(
            void* (* CXDiagnostic *) arg0)
        let getDiagnosticCategory _arg0 =
            getDiagnosticCategoryNative ((_arg0 : CXDiagnostic).Ptr)

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getDiagnosticCategoryName",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXString getDiagnosticCategoryNameNative(
            uint32 Category)
        let getDiagnosticCategoryName _Category =
            getDiagnosticCategoryNameNative (_Category)

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getDiagnosticCategoryText",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXString getDiagnosticCategoryTextNative(
            void* (* CXDiagnostic *) arg0)
        let getDiagnosticCategoryText _arg0 =
            getDiagnosticCategoryTextNative ((_arg0 : CXDiagnostic).Ptr)

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getDiagnosticNumRanges",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 getDiagnosticNumRangesNative(
            void* (* CXDiagnostic *) arg0)
        let getDiagnosticNumRanges _arg0 =
            getDiagnosticNumRangesNative ((_arg0 : CXDiagnostic).Ptr)

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getDiagnosticRange",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXSourceRange getDiagnosticRangeNative(
            void* (* CXDiagnostic *) Diagnostic,
            uint32 Range)
        let getDiagnosticRange _Diagnostic _Range =
            getDiagnosticRangeNative ((_Diagnostic : CXDiagnostic).Ptr, _Range)

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getDiagnosticNumFixIts",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 getDiagnosticNumFixItsNative(
            void* (* CXDiagnostic *) Diagnostic)
        let getDiagnosticNumFixIts _Diagnostic =
            getDiagnosticNumFixItsNative ((_Diagnostic : CXDiagnostic).Ptr)

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getDiagnosticFixIt",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXString getDiagnosticFixItNative(
            void* (* CXDiagnostic *) Diagnostic,
            uint32 FixIt,
            CXSourceRange ReplacementRange)
        // I don't know how to generate an "F# friendly" version of clang_getDiagnosticFixIt

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getTranslationUnitSpelling",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXString getTranslationUnitSpellingNative(
            void* (* CXTranslationUnit *) CTUnit)
        let getTranslationUnitSpelling _CTUnit =
            getTranslationUnitSpellingNative ((_CTUnit : CXTranslationUnit).Ptr)

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_createTranslationUnitFromSourceFile",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* CXTranslationUnit *) createTranslationUnitFromSourceFileNative(
            void* (* CXIndex *) CIdx,
            string source_filename,
            int num_clang_command_line_args,
            void* clang_command_line_args,
            uint32 num_unsaved_files,
            CXUnsavedFile* unsaved_files)
        // I don't know how to generate an "F# friendly" version of clang_createTranslationUnitFromSourceFile

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_createTranslationUnit",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* CXTranslationUnit *) createTranslationUnitNative(
            void* (* CXIndex *) CIdx,
            string ast_filename)
        let createTranslationUnit _CIdx _ast_filename =
            new CXTranslationUnit (createTranslationUnitNative ((_CIdx : CXIndex).Ptr, _ast_filename))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_createTranslationUnit2",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int (* CXErrorCode *) createTranslationUnit2Native(
            void* (* CXIndex *) CIdx,
            string ast_filename,
            void* (* CXTranslationUnit* *) out_TU)
        // I don't know how to generate an "F# friendly" version of clang_createTranslationUnit2

        type CXTranslationUnit_Flags =
            | CXTranslationUnit_None = 0
            | CXTranslationUnit_DetailedPreprocessingRecord = 1
            | CXTranslationUnit_Incomplete = 2
            | CXTranslationUnit_PrecompiledPreamble = 4
            | CXTranslationUnit_CacheCompletionResults = 8
            | CXTranslationUnit_ForSerialization = 16
            | CXTranslationUnit_CXXChainedPCH = 32
            | CXTranslationUnit_SkipFunctionBodies = 64
            | CXTranslationUnit_IncludeBriefCommentsInCodeCompletion = 128

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_defaultEditingTranslationUnitOptions",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 defaultEditingTranslationUnitOptionsNative()
        let defaultEditingTranslationUnitOptions () =
            defaultEditingTranslationUnitOptionsNative ()

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_parseTranslationUnit",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* CXTranslationUnit *) parseTranslationUnitNative(
            void* (* CXIndex *) CIdx,
            string source_filename,
            void* command_line_args,
            int num_command_line_args,
            CXUnsavedFile* unsaved_files,
            uint32 num_unsaved_files,
            uint32 options)
        // I don't know how to generate an "F# friendly" version of clang_parseTranslationUnit

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_parseTranslationUnit2",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int (* CXErrorCode *) parseTranslationUnit2Native(
            void* (* CXIndex *) CIdx,
            string source_filename,
            void* command_line_args,
            int num_command_line_args,
            CXUnsavedFile* unsaved_files,
            uint32 num_unsaved_files,
            uint32 options,
            void* (* CXTranslationUnit* *) out_TU)
        // I don't know how to generate an "F# friendly" version of clang_parseTranslationUnit2

        type CXSaveTranslationUnit_Flags =
            | CXSaveTranslationUnit_None = 0

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_defaultSaveOptions",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 defaultSaveOptionsNative(
            void* (* CXTranslationUnit *) TU)
        let defaultSaveOptions _TU =
            defaultSaveOptionsNative ((_TU : CXTranslationUnit).Ptr)

        type CXSaveError =
            | CXSaveError_None = 0
            | CXSaveError_Unknown = 1
            | CXSaveError_TranslationErrors = 2
            | CXSaveError_InvalidTU = 3

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_saveTranslationUnit",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int saveTranslationUnitNative(
            void* (* CXTranslationUnit *) TU,
            string FileName,
            uint32 options)
        let saveTranslationUnit _TU _FileName _options =
            saveTranslationUnitNative ((_TU : CXTranslationUnit).Ptr, _FileName, _options)

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_disposeTranslationUnit",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void disposeTranslationUnitNative(
            void* (* CXTranslationUnit *) arg0)
        let disposeTranslationUnit _arg0 =
            disposeTranslationUnitNative ((_arg0 : CXTranslationUnit).Ptr)

        type CXReparse_Flags =
            | CXReparse_None = 0

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_defaultReparseOptions",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 defaultReparseOptionsNative(
            void* (* CXTranslationUnit *) TU)
        let defaultReparseOptions _TU =
            defaultReparseOptionsNative ((_TU : CXTranslationUnit).Ptr)

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_reparseTranslationUnit",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int reparseTranslationUnitNative(
            void* (* CXTranslationUnit *) TU,
            uint32 num_unsaved_files,
            CXUnsavedFile* unsaved_files,
            uint32 options)
        // I don't know how to generate an "F# friendly" version of clang_reparseTranslationUnit

        type CXTUResourceUsageKind =
            | CXTUResourceUsage_AST = 1
            | CXTUResourceUsage_Identifiers = 2
            | CXTUResourceUsage_Selectors = 3
            | CXTUResourceUsage_GlobalCompletionResults = 4
            | CXTUResourceUsage_SourceManagerContentCache = 5
            | CXTUResourceUsage_AST_SideTables = 6
            | CXTUResourceUsage_SourceManager_Membuffer_Malloc = 7
            | CXTUResourceUsage_SourceManager_Membuffer_MMap = 8
            | CXTUResourceUsage_ExternalASTSource_Membuffer_Malloc = 9
            | CXTUResourceUsage_ExternalASTSource_Membuffer_MMap = 10
            | CXTUResourceUsage_Preprocessor = 11
            | CXTUResourceUsage_PreprocessingRecord = 12
            | CXTUResourceUsage_SourceManager_DataStructures = 13
            | CXTUResourceUsage_Preprocessor_HeaderSearch = 14
            | CXTUResourceUsage_MEMORY_IN_BYTES_BEGIN = 1
            | CXTUResourceUsage_MEMORY_IN_BYTES_END = 14
            | CXTUResourceUsage_First = 1
            | CXTUResourceUsage_Last = 14

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getTUResourceUsageName",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* getTUResourceUsageNameNative(
            int (* CXTUResourceUsageKind *) kind)
        let getTUResourceUsageName _kind =
            Marshal.PtrToStringAuto (getTUResourceUsageNameNative ((int (_kind : CXTUResourceUsageKind))))

        [<Struct>]
        type CXTUResourceUsageEntry =
            val mutable kind : CXTUResourceUsageKind (* CXTUResourceUsageKind *)
            val mutable amount : uint64

        [<Struct>]
        type CXTUResourceUsage =
            val mutable data : nativeint (* nativeptr<void> *)
            val mutable numEntries : uint32
            val mutable entries : CXTUResourceUsageEntry

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getCXTUResourceUsage",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXTUResourceUsage getCXTUResourceUsageNative(
            void* (* CXTranslationUnit *) TU)
        let getCXTUResourceUsage _TU =
            getCXTUResourceUsageNative ((_TU : CXTranslationUnit).Ptr)

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_disposeCXTUResourceUsage",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void disposeCXTUResourceUsageNative(
            CXTUResourceUsage usage)
        let disposeCXTUResourceUsage _usage =
            disposeCXTUResourceUsageNative ((_usage : CXTUResourceUsage))

        type CXCursorKind =
            | CXCursor_UnexposedDecl = 1
            | CXCursor_StructDecl = 2
            | CXCursor_UnionDecl = 3
            | CXCursor_ClassDecl = 4
            | CXCursor_EnumDecl = 5
            | CXCursor_FieldDecl = 6
            | CXCursor_EnumConstantDecl = 7
            | CXCursor_FunctionDecl = 8
            | CXCursor_VarDecl = 9
            | CXCursor_ParmDecl = 10
            | CXCursor_ObjCInterfaceDecl = 11
            | CXCursor_ObjCCategoryDecl = 12
            | CXCursor_ObjCProtocolDecl = 13
            | CXCursor_ObjCPropertyDecl = 14
            | CXCursor_ObjCIvarDecl = 15
            | CXCursor_ObjCInstanceMethodDecl = 16
            | CXCursor_ObjCClassMethodDecl = 17
            | CXCursor_ObjCImplementationDecl = 18
            | CXCursor_ObjCCategoryImplDecl = 19
            | CXCursor_TypedefDecl = 20
            | CXCursor_CXXMethod = 21
            | CXCursor_Namespace = 22
            | CXCursor_LinkageSpec = 23
            | CXCursor_Constructor = 24
            | CXCursor_Destructor = 25
            | CXCursor_ConversionFunction = 26
            | CXCursor_TemplateTypeParameter = 27
            | CXCursor_NonTypeTemplateParameter = 28
            | CXCursor_TemplateTemplateParameter = 29
            | CXCursor_FunctionTemplate = 30
            | CXCursor_ClassTemplate = 31
            | CXCursor_ClassTemplatePartialSpecialization = 32
            | CXCursor_NamespaceAlias = 33
            | CXCursor_UsingDirective = 34
            | CXCursor_UsingDeclaration = 35
            | CXCursor_TypeAliasDecl = 36
            | CXCursor_ObjCSynthesizeDecl = 37
            | CXCursor_ObjCDynamicDecl = 38
            | CXCursor_CXXAccessSpecifier = 39
            | CXCursor_FirstDecl = 1
            | CXCursor_LastDecl = 39
            | CXCursor_FirstRef = 40
            | CXCursor_ObjCSuperClassRef = 40
            | CXCursor_ObjCProtocolRef = 41
            | CXCursor_ObjCClassRef = 42
            | CXCursor_TypeRef = 43
            | CXCursor_CXXBaseSpecifier = 44
            | CXCursor_TemplateRef = 45
            | CXCursor_NamespaceRef = 46
            | CXCursor_MemberRef = 47
            | CXCursor_LabelRef = 48
            | CXCursor_OverloadedDeclRef = 49
            | CXCursor_VariableRef = 50
            | CXCursor_LastRef = 50
            | CXCursor_FirstInvalid = 70
            | CXCursor_InvalidFile = 70
            | CXCursor_NoDeclFound = 71
            | CXCursor_NotImplemented = 72
            | CXCursor_InvalidCode = 73
            | CXCursor_LastInvalid = 73
            | CXCursor_FirstExpr = 100
            | CXCursor_UnexposedExpr = 100
            | CXCursor_DeclRefExpr = 101
            | CXCursor_MemberRefExpr = 102
            | CXCursor_CallExpr = 103
            | CXCursor_ObjCMessageExpr = 104
            | CXCursor_BlockExpr = 105
            | CXCursor_IntegerLiteral = 106
            | CXCursor_FloatingLiteral = 107
            | CXCursor_ImaginaryLiteral = 108
            | CXCursor_StringLiteral = 109
            | CXCursor_CharacterLiteral = 110
            | CXCursor_ParenExpr = 111
            | CXCursor_UnaryOperator = 112
            | CXCursor_ArraySubscriptExpr = 113
            | CXCursor_BinaryOperator = 114
            | CXCursor_CompoundAssignOperator = 115
            | CXCursor_ConditionalOperator = 116
            | CXCursor_CStyleCastExpr = 117
            | CXCursor_CompoundLiteralExpr = 118
            | CXCursor_InitListExpr = 119
            | CXCursor_AddrLabelExpr = 120
            | CXCursor_StmtExpr = 121
            | CXCursor_GenericSelectionExpr = 122
            | CXCursor_GNUNullExpr = 123
            | CXCursor_CXXStaticCastExpr = 124
            | CXCursor_CXXDynamicCastExpr = 125
            | CXCursor_CXXReinterpretCastExpr = 126
            | CXCursor_CXXConstCastExpr = 127
            | CXCursor_CXXFunctionalCastExpr = 128
            | CXCursor_CXXTypeidExpr = 129
            | CXCursor_CXXBoolLiteralExpr = 130
            | CXCursor_CXXNullPtrLiteralExpr = 131
            | CXCursor_CXXThisExpr = 132
            | CXCursor_CXXThrowExpr = 133
            | CXCursor_CXXNewExpr = 134
            | CXCursor_CXXDeleteExpr = 135
            | CXCursor_UnaryExpr = 136
            | CXCursor_ObjCStringLiteral = 137
            | CXCursor_ObjCEncodeExpr = 138
            | CXCursor_ObjCSelectorExpr = 139
            | CXCursor_ObjCProtocolExpr = 140
            | CXCursor_ObjCBridgedCastExpr = 141
            | CXCursor_PackExpansionExpr = 142
            | CXCursor_SizeOfPackExpr = 143
            | CXCursor_LambdaExpr = 144
            | CXCursor_ObjCBoolLiteralExpr = 145
            | CXCursor_ObjCSelfExpr = 146
            | CXCursor_LastExpr = 146
            | CXCursor_FirstStmt = 200
            | CXCursor_UnexposedStmt = 200
            | CXCursor_LabelStmt = 201
            | CXCursor_CompoundStmt = 202
            | CXCursor_CaseStmt = 203
            | CXCursor_DefaultStmt = 204
            | CXCursor_IfStmt = 205
            | CXCursor_SwitchStmt = 206
            | CXCursor_WhileStmt = 207
            | CXCursor_DoStmt = 208
            | CXCursor_ForStmt = 209
            | CXCursor_GotoStmt = 210
            | CXCursor_IndirectGotoStmt = 211
            | CXCursor_ContinueStmt = 212
            | CXCursor_BreakStmt = 213
            | CXCursor_ReturnStmt = 214
            | CXCursor_GCCAsmStmt = 215
            | CXCursor_AsmStmt = 215
            | CXCursor_ObjCAtTryStmt = 216
            | CXCursor_ObjCAtCatchStmt = 217
            | CXCursor_ObjCAtFinallyStmt = 218
            | CXCursor_ObjCAtThrowStmt = 219
            | CXCursor_ObjCAtSynchronizedStmt = 220
            | CXCursor_ObjCAutoreleasePoolStmt = 221
            | CXCursor_ObjCForCollectionStmt = 222
            | CXCursor_CXXCatchStmt = 223
            | CXCursor_CXXTryStmt = 224
            | CXCursor_CXXForRangeStmt = 225
            | CXCursor_SEHTryStmt = 226
            | CXCursor_SEHExceptStmt = 227
            | CXCursor_SEHFinallyStmt = 228
            | CXCursor_MSAsmStmt = 229
            | CXCursor_NullStmt = 230
            | CXCursor_DeclStmt = 231
            | CXCursor_OMPParallelDirective = 232
            | CXCursor_OMPSimdDirective = 233
            | CXCursor_OMPForDirective = 234
            | CXCursor_OMPSectionsDirective = 235
            | CXCursor_OMPSectionDirective = 236
            | CXCursor_OMPSingleDirective = 237
            | CXCursor_OMPParallelForDirective = 238
            | CXCursor_OMPParallelSectionsDirective = 239
            | CXCursor_OMPTaskDirective = 240
            | CXCursor_OMPMasterDirective = 241
            | CXCursor_OMPCriticalDirective = 242
            | CXCursor_OMPTaskyieldDirective = 243
            | CXCursor_OMPBarrierDirective = 244
            | CXCursor_OMPTaskwaitDirective = 245
            | CXCursor_OMPFlushDirective = 246
            | CXCursor_SEHLeaveStmt = 247
            | CXCursor_OMPOrderedDirective = 248
            | CXCursor_OMPAtomicDirective = 249
            | CXCursor_OMPForSimdDirective = 250
            | CXCursor_OMPParallelForSimdDirective = 251
            | CXCursor_OMPTargetDirective = 252
            | CXCursor_OMPTeamsDirective = 253
            | CXCursor_LastStmt = 253
            | CXCursor_TranslationUnit = 300
            | CXCursor_FirstAttr = 400
            | CXCursor_UnexposedAttr = 400
            | CXCursor_IBActionAttr = 401
            | CXCursor_IBOutletAttr = 402
            | CXCursor_IBOutletCollectionAttr = 403
            | CXCursor_CXXFinalAttr = 404
            | CXCursor_CXXOverrideAttr = 405
            | CXCursor_AnnotateAttr = 406
            | CXCursor_AsmLabelAttr = 407
            | CXCursor_PackedAttr = 408
            | CXCursor_PureAttr = 409
            | CXCursor_ConstAttr = 410
            | CXCursor_NoDuplicateAttr = 411
            | CXCursor_CUDAConstantAttr = 412
            | CXCursor_CUDADeviceAttr = 413
            | CXCursor_CUDAGlobalAttr = 414
            | CXCursor_CUDAHostAttr = 415
            | CXCursor_CUDASharedAttr = 416
            | CXCursor_LastAttr = 416
            | CXCursor_PreprocessingDirective = 500
            | CXCursor_MacroDefinition = 501
            | CXCursor_MacroExpansion = 502
            | CXCursor_MacroInstantiation = 502
            | CXCursor_InclusionDirective = 503
            | CXCursor_FirstPreprocessing = 500
            | CXCursor_LastPreprocessing = 503
            | CXCursor_ModuleImportDecl = 600
            | CXCursor_FirstExtraDecl = 600
            | CXCursor_LastExtraDecl = 600

        [<Struct>]
        type CXCursor =
            val mutable kind : CXCursorKind (* CXCursorKind *)
            val mutable xdata : int
            val mutable data0 : nativeint (* nativeptr<void> *)
            val mutable data1 : nativeint (* nativeptr<void> *)
            val mutable data2 : nativeint (* nativeptr<void> *)

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getNullCursor",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXCursor getNullCursorNative()
        let getNullCursor () =
            getNullCursorNative ()

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getTranslationUnitCursor",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXCursor getTranslationUnitCursorNative(
            void* (* CXTranslationUnit *) arg0)
        let getTranslationUnitCursor _arg0 =
            getTranslationUnitCursorNative ((_arg0 : CXTranslationUnit).Ptr)

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_equalCursors",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 equalCursorsNative(
            CXCursor arg0,
            CXCursor arg1)
        let equalCursors _arg0 _arg1 =
            equalCursorsNative ((_arg0 : CXCursor), (_arg1 : CXCursor))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_Cursor_isNull",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int cursor_isNullNative(
            CXCursor cursor)
        let cursor_isNull _cursor =
            cursor_isNullNative ((_cursor : CXCursor))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_hashCursor",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 hashCursorNative(
            CXCursor arg0)
        let hashCursor _arg0 =
            hashCursorNative ((_arg0 : CXCursor))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getCursorKind",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int (* CXCursorKind *) getCursorKindNative(
            CXCursor arg0)
        let getCursorKind _arg0 =
            enum<CXCursorKind> (getCursorKindNative ((_arg0 : CXCursor)))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_isDeclaration",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 isDeclarationNative(
            int (* CXCursorKind *) arg0)
        let isDeclaration _arg0 =
            isDeclarationNative ((int (_arg0 : CXCursorKind)))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_isReference",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 isReferenceNative(
            int (* CXCursorKind *) arg0)
        let isReference _arg0 =
            isReferenceNative ((int (_arg0 : CXCursorKind)))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_isExpression",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 isExpressionNative(
            int (* CXCursorKind *) arg0)
        let isExpression _arg0 =
            isExpressionNative ((int (_arg0 : CXCursorKind)))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_isStatement",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 isStatementNative(
            int (* CXCursorKind *) arg0)
        let isStatement _arg0 =
            isStatementNative ((int (_arg0 : CXCursorKind)))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_isAttribute",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 isAttributeNative(
            int (* CXCursorKind *) arg0)
        let isAttribute _arg0 =
            isAttributeNative ((int (_arg0 : CXCursorKind)))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_isInvalid",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 isInvalidNative(
            int (* CXCursorKind *) arg0)
        let isInvalid _arg0 =
            isInvalidNative ((int (_arg0 : CXCursorKind)))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_isTranslationUnit",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 isTranslationUnitNative(
            int (* CXCursorKind *) arg0)
        let isTranslationUnit _arg0 =
            isTranslationUnitNative ((int (_arg0 : CXCursorKind)))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_isPreprocessing",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 isPreprocessingNative(
            int (* CXCursorKind *) arg0)
        let isPreprocessing _arg0 =
            isPreprocessingNative ((int (_arg0 : CXCursorKind)))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_isUnexposed",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 isUnexposedNative(
            int (* CXCursorKind *) arg0)
        let isUnexposed _arg0 =
            isUnexposedNative ((int (_arg0 : CXCursorKind)))

        type CXLinkageKind =
            | CXLinkage_Invalid = 0
            | CXLinkage_NoLinkage = 1
            | CXLinkage_Internal = 2
            | CXLinkage_UniqueExternal = 3
            | CXLinkage_External = 4

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getCursorLinkage",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int (* CXLinkageKind *) getCursorLinkageNative(
            CXCursor cursor)
        let getCursorLinkage _cursor =
            enum<CXLinkageKind> (getCursorLinkageNative ((_cursor : CXCursor)))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getCursorAvailability",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int (* CXAvailabilityKind *) getCursorAvailabilityNative(
            CXCursor cursor)
        let getCursorAvailability _cursor =
            enum<CXAvailabilityKind> (getCursorAvailabilityNative ((_cursor : CXCursor)))

        [<Struct>]
        type CXPlatformAvailability =
            val mutable Platform : CXString
            val mutable Introduced : CXVersion
            val mutable Deprecated : CXVersion
            val mutable Obsoleted : CXVersion
            val mutable Unavailable : int
            val mutable Message : CXString

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getCursorPlatformAvailability",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int getCursorPlatformAvailabilityNative(
            CXCursor cursor,
            int* always_deprecated,
            CXString deprecated_message,
            int* always_unavailable,
            CXString unavailable_message,
            CXPlatformAvailability availability,
            int availability_size)
        // I don't know how to generate an "F# friendly" version of clang_getCursorPlatformAvailability

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_disposeCXPlatformAvailability",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void disposeCXPlatformAvailabilityNative(
            CXPlatformAvailability availability)
        // I don't know how to generate an "F# friendly" version of clang_disposeCXPlatformAvailability

        type CXLanguageKind =
            | CXLanguage_Invalid = 0
            | CXLanguage_C = 1
            | CXLanguage_ObjC = 2
            | CXLanguage_CPlusPlus = 3

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getCursorLanguage",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int (* CXLanguageKind *) getCursorLanguageNative(
            CXCursor cursor)
        let getCursorLanguage _cursor =
            enum<CXLanguageKind> (getCursorLanguageNative ((_cursor : CXCursor)))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_Cursor_getTranslationUnit",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* CXTranslationUnit *) cursor_getTranslationUnitNative(
            CXCursor arg0)
        let cursor_getTranslationUnit _arg0 =
            new CXTranslationUnit (cursor_getTranslationUnitNative ((_arg0 : CXCursor)))

        type CXCursorSet (thePtr : nativeint) =
            member x.Ptr = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr = thePtr

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_createCXCursorSet",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* CXCursorSet *) createCXCursorSetNative()
        let createCXCursorSet () =
            new CXCursorSet (createCXCursorSetNative ())

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_disposeCXCursorSet",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void disposeCXCursorSetNative(
            void* (* CXCursorSet *) cset)
        let disposeCXCursorSet _cset =
            disposeCXCursorSetNative ((_cset : CXCursorSet).Ptr)

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_CXCursorSet_contains",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 cXCursorSet_containsNative(
            void* (* CXCursorSet *) cset,
            CXCursor cursor)
        let cXCursorSet_contains _cset _cursor =
            cXCursorSet_containsNative ((_cset : CXCursorSet).Ptr, (_cursor : CXCursor))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_CXCursorSet_insert",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 cXCursorSet_insertNative(
            void* (* CXCursorSet *) cset,
            CXCursor cursor)
        let cXCursorSet_insert _cset _cursor =
            cXCursorSet_insertNative ((_cset : CXCursorSet).Ptr, (_cursor : CXCursor))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getCursorSemanticParent",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXCursor getCursorSemanticParentNative(
            CXCursor cursor)
        let getCursorSemanticParent _cursor =
            getCursorSemanticParentNative ((_cursor : CXCursor))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getCursorLexicalParent",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXCursor getCursorLexicalParentNative(
            CXCursor cursor)
        let getCursorLexicalParent _cursor =
            getCursorLexicalParentNative ((_cursor : CXCursor))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getOverriddenCursors",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void getOverriddenCursorsNative(
            CXCursor cursor,
            CXCursor overridden,
            uint32* num_overridden)
        // I don't know how to generate an "F# friendly" version of clang_getOverriddenCursors

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_disposeOverriddenCursors",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void disposeOverriddenCursorsNative(
            CXCursor overridden)
        // I don't know how to generate an "F# friendly" version of clang_disposeOverriddenCursors

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getIncludedFile",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* CXFile *) getIncludedFileNative(
            CXCursor cursor)
        let getIncludedFile _cursor =
            new CXFile (getIncludedFileNative ((_cursor : CXCursor)))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getCursor",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXCursor getCursorNative(
            void* (* CXTranslationUnit *) arg0,
            CXSourceLocation arg1)
        let getCursor _arg0 _arg1 =
            getCursorNative ((_arg0 : CXTranslationUnit).Ptr, (_arg1 : CXSourceLocation))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getCursorLocation",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXSourceLocation getCursorLocationNative(
            CXCursor arg0)
        let getCursorLocation _arg0 =
            getCursorLocationNative ((_arg0 : CXCursor))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getCursorExtent",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXSourceRange getCursorExtentNative(
            CXCursor arg0)
        let getCursorExtent _arg0 =
            getCursorExtentNative ((_arg0 : CXCursor))

        type CXTypeKind =
            | CXType_Invalid = 0
            | CXType_Unexposed = 1
            | CXType_Void = 2
            | CXType_Bool = 3
            | CXType_Char_U = 4
            | CXType_UChar = 5
            | CXType_Char16 = 6
            | CXType_Char32 = 7
            | CXType_UShort = 8
            | CXType_UInt = 9
            | CXType_ULong = 10
            | CXType_ULongLong = 11
            | CXType_UInt128 = 12
            | CXType_Char_S = 13
            | CXType_SChar = 14
            | CXType_WChar = 15
            | CXType_Short = 16
            | CXType_Int = 17
            | CXType_Long = 18
            | CXType_LongLong = 19
            | CXType_Int128 = 20
            | CXType_Float = 21
            | CXType_Double = 22
            | CXType_LongDouble = 23
            | CXType_NullPtr = 24
            | CXType_Overload = 25
            | CXType_Dependent = 26
            | CXType_ObjCId = 27
            | CXType_ObjCClass = 28
            | CXType_ObjCSel = 29
            | CXType_FirstBuiltin = 2
            | CXType_LastBuiltin = 29
            | CXType_Complex = 100
            | CXType_Pointer = 101
            | CXType_BlockPointer = 102
            | CXType_LValueReference = 103
            | CXType_RValueReference = 104
            | CXType_Record = 105
            | CXType_Enum = 106
            | CXType_Typedef = 107
            | CXType_ObjCInterface = 108
            | CXType_ObjCObjectPointer = 109
            | CXType_FunctionNoProto = 110
            | CXType_FunctionProto = 111
            | CXType_ConstantArray = 112
            | CXType_Vector = 113
            | CXType_IncompleteArray = 114
            | CXType_VariableArray = 115
            | CXType_DependentSizedArray = 116
            | CXType_MemberPointer = 117

        type CXCallingConv =
            | CXCallingConv_Default = 0
            | CXCallingConv_C = 1
            | CXCallingConv_X86StdCall = 2
            | CXCallingConv_X86FastCall = 3
            | CXCallingConv_X86ThisCall = 4
            | CXCallingConv_X86Pascal = 5
            | CXCallingConv_AAPCS = 6
            | CXCallingConv_AAPCS_VFP = 7
            | CXCallingConv_PnaclCall = 8
            | CXCallingConv_IntelOclBicc = 9
            | CXCallingConv_X86_64Win64 = 10
            | CXCallingConv_X86_64SysV = 11
            | CXCallingConv_X86VectorCall = 12
            | CXCallingConv_Invalid = 100
            | CXCallingConv_Unexposed = 200

        [<Struct>]
        type CXType =
            val mutable kind : CXTypeKind (* CXTypeKind *)
            val mutable data0 : nativeint (* nativeptr<void> *)
            val mutable data1 : nativeint (* nativeptr<void> *)

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getCursorType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXType getCursorTypeNative(
            CXCursor C)
        let getCursorType _C =
            getCursorTypeNative ((_C : CXCursor))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getTypeSpelling",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXString getTypeSpellingNative(
            CXType CT)
        let getTypeSpelling _CT =
            getTypeSpellingNative ((_CT : CXType))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getTypedefDeclUnderlyingType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXType getTypedefDeclUnderlyingTypeNative(
            CXCursor C)
        let getTypedefDeclUnderlyingType _C =
            getTypedefDeclUnderlyingTypeNative ((_C : CXCursor))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getEnumDeclIntegerType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXType getEnumDeclIntegerTypeNative(
            CXCursor C)
        let getEnumDeclIntegerType _C =
            getEnumDeclIntegerTypeNative ((_C : CXCursor))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getEnumConstantDeclValue",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int64 getEnumConstantDeclValueNative(
            CXCursor C)
        let getEnumConstantDeclValue _C =
            getEnumConstantDeclValueNative ((_C : CXCursor))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getEnumConstantDeclUnsignedValue",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint64 getEnumConstantDeclUnsignedValueNative(
            CXCursor C)
        let getEnumConstantDeclUnsignedValue _C =
            getEnumConstantDeclUnsignedValueNative ((_C : CXCursor))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getFieldDeclBitWidth",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int getFieldDeclBitWidthNative(
            CXCursor C)
        let getFieldDeclBitWidth _C =
            getFieldDeclBitWidthNative ((_C : CXCursor))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_Cursor_getNumArguments",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int cursor_getNumArgumentsNative(
            CXCursor C)
        let cursor_getNumArguments _C =
            cursor_getNumArgumentsNative ((_C : CXCursor))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_Cursor_getArgument",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXCursor cursor_getArgumentNative(
            CXCursor C,
            uint32 i)
        let cursor_getArgument _C _i =
            cursor_getArgumentNative ((_C : CXCursor), _i)

        type CXTemplateArgumentKind =
            | CXTemplateArgumentKind_Null = 0
            | CXTemplateArgumentKind_Type = 1
            | CXTemplateArgumentKind_Declaration = 2
            | CXTemplateArgumentKind_NullPtr = 3
            | CXTemplateArgumentKind_Integral = 4
            | CXTemplateArgumentKind_Template = 5
            | CXTemplateArgumentKind_TemplateExpansion = 6
            | CXTemplateArgumentKind_Expression = 7
            | CXTemplateArgumentKind_Pack = 8
            | CXTemplateArgumentKind_Invalid = 9

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_Cursor_getNumTemplateArguments",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int cursor_getNumTemplateArgumentsNative(
            CXCursor C)
        let cursor_getNumTemplateArguments _C =
            cursor_getNumTemplateArgumentsNative ((_C : CXCursor))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_Cursor_getTemplateArgumentKind",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int (* CXTemplateArgumentKind *) cursor_getTemplateArgumentKindNative(
            CXCursor C,
            uint32 I)
        let cursor_getTemplateArgumentKind _C _I =
            enum<CXTemplateArgumentKind> (cursor_getTemplateArgumentKindNative ((_C : CXCursor), _I))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_Cursor_getTemplateArgumentType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXType cursor_getTemplateArgumentTypeNative(
            CXCursor C,
            uint32 I)
        let cursor_getTemplateArgumentType _C _I =
            cursor_getTemplateArgumentTypeNative ((_C : CXCursor), _I)

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_Cursor_getTemplateArgumentValue",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int64 cursor_getTemplateArgumentValueNative(
            CXCursor C,
            uint32 I)
        let cursor_getTemplateArgumentValue _C _I =
            cursor_getTemplateArgumentValueNative ((_C : CXCursor), _I)

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_Cursor_getTemplateArgumentUnsignedValue",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint64 cursor_getTemplateArgumentUnsignedValueNative(
            CXCursor C,
            uint32 I)
        let cursor_getTemplateArgumentUnsignedValue _C _I =
            cursor_getTemplateArgumentUnsignedValueNative ((_C : CXCursor), _I)

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_equalTypes",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 equalTypesNative(
            CXType A,
            CXType B)
        let equalTypes _A _B =
            equalTypesNative ((_A : CXType), (_B : CXType))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getCanonicalType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXType getCanonicalTypeNative(
            CXType T)
        let getCanonicalType _T =
            getCanonicalTypeNative ((_T : CXType))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_isConstQualifiedType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 isConstQualifiedTypeNative(
            CXType T)
        let isConstQualifiedType _T =
            isConstQualifiedTypeNative ((_T : CXType))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_isVolatileQualifiedType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 isVolatileQualifiedTypeNative(
            CXType T)
        let isVolatileQualifiedType _T =
            isVolatileQualifiedTypeNative ((_T : CXType))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_isRestrictQualifiedType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 isRestrictQualifiedTypeNative(
            CXType T)
        let isRestrictQualifiedType _T =
            isRestrictQualifiedTypeNative ((_T : CXType))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getPointeeType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXType getPointeeTypeNative(
            CXType T)
        let getPointeeType _T =
            getPointeeTypeNative ((_T : CXType))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getTypeDeclaration",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXCursor getTypeDeclarationNative(
            CXType T)
        let getTypeDeclaration _T =
            getTypeDeclarationNative ((_T : CXType))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getDeclObjCTypeEncoding",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXString getDeclObjCTypeEncodingNative(
            CXCursor C)
        let getDeclObjCTypeEncoding _C =
            getDeclObjCTypeEncodingNative ((_C : CXCursor))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getTypeKindSpelling",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXString getTypeKindSpellingNative(
            int (* CXTypeKind *) K)
        let getTypeKindSpelling _K =
            getTypeKindSpellingNative ((int (_K : CXTypeKind)))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getFunctionTypeCallingConv",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int (* CXCallingConv *) getFunctionTypeCallingConvNative(
            CXType T)
        let getFunctionTypeCallingConv _T =
            enum<CXCallingConv> (getFunctionTypeCallingConvNative ((_T : CXType)))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getResultType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXType getResultTypeNative(
            CXType T)
        let getResultType _T =
            getResultTypeNative ((_T : CXType))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getNumArgTypes",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int getNumArgTypesNative(
            CXType T)
        let getNumArgTypes _T =
            getNumArgTypesNative ((_T : CXType))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getArgType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXType getArgTypeNative(
            CXType T,
            uint32 i)
        let getArgType _T _i =
            getArgTypeNative ((_T : CXType), _i)

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_isFunctionTypeVariadic",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 isFunctionTypeVariadicNative(
            CXType T)
        let isFunctionTypeVariadic _T =
            isFunctionTypeVariadicNative ((_T : CXType))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getCursorResultType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXType getCursorResultTypeNative(
            CXCursor C)
        let getCursorResultType _C =
            getCursorResultTypeNative ((_C : CXCursor))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_isPODType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 isPODTypeNative(
            CXType T)
        let isPODType _T =
            isPODTypeNative ((_T : CXType))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getElementType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXType getElementTypeNative(
            CXType T)
        let getElementType _T =
            getElementTypeNative ((_T : CXType))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getNumElements",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int64 getNumElementsNative(
            CXType T)
        let getNumElements _T =
            getNumElementsNative ((_T : CXType))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getArrayElementType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXType getArrayElementTypeNative(
            CXType T)
        let getArrayElementType _T =
            getArrayElementTypeNative ((_T : CXType))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getArraySize",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int64 getArraySizeNative(
            CXType T)
        let getArraySize _T =
            getArraySizeNative ((_T : CXType))

        type CXTypeLayoutError =
            | CXTypeLayoutError_Invalid = -1
            | CXTypeLayoutError_Incomplete = -2
            | CXTypeLayoutError_Dependent = -3
            | CXTypeLayoutError_NotConstantSize = -4
            | CXTypeLayoutError_InvalidFieldName = -5

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_Type_getAlignOf",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int64 type_getAlignOfNative(
            CXType T)
        let type_getAlignOf _T =
            type_getAlignOfNative ((_T : CXType))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_Type_getClassType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXType type_getClassTypeNative(
            CXType T)
        let type_getClassType _T =
            type_getClassTypeNative ((_T : CXType))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_Type_getSizeOf",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int64 type_getSizeOfNative(
            CXType T)
        let type_getSizeOf _T =
            type_getSizeOfNative ((_T : CXType))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_Type_getOffsetOf",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int64 type_getOffsetOfNative(
            CXType T,
            string S)
        let type_getOffsetOf _T _S =
            type_getOffsetOfNative ((_T : CXType), _S)

        type CXRefQualifierKind =
            | CXRefQualifier_None = 0
            | CXRefQualifier_LValue = 1
            | CXRefQualifier_RValue = 2

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_Type_getNumTemplateArguments",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int type_getNumTemplateArgumentsNative(
            CXType T)
        let type_getNumTemplateArguments _T =
            type_getNumTemplateArgumentsNative ((_T : CXType))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_Type_getTemplateArgumentAsType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXType type_getTemplateArgumentAsTypeNative(
            CXType T,
            uint32 i)
        let type_getTemplateArgumentAsType _T _i =
            type_getTemplateArgumentAsTypeNative ((_T : CXType), _i)

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_Type_getCXXRefQualifier",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int (* CXRefQualifierKind *) type_getCXXRefQualifierNative(
            CXType T)
        let type_getCXXRefQualifier _T =
            enum<CXRefQualifierKind> (type_getCXXRefQualifierNative ((_T : CXType)))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_Cursor_isBitField",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 cursor_isBitFieldNative(
            CXCursor C)
        let cursor_isBitField _C =
            cursor_isBitFieldNative ((_C : CXCursor))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_isVirtualBase",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 isVirtualBaseNative(
            CXCursor arg0)
        let isVirtualBase _arg0 =
            isVirtualBaseNative ((_arg0 : CXCursor))

        type CX_CXXAccessSpecifier =
            | CX_CXXInvalidAccessSpecifier = 0
            | CX_CXXPublic = 1
            | CX_CXXProtected = 2
            | CX_CXXPrivate = 3

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getCXXAccessSpecifier",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int (* CX_CXXAccessSpecifier *) getCXXAccessSpecifierNative(
            CXCursor arg0)
        let getCXXAccessSpecifier _arg0 =
            enum<CX_CXXAccessSpecifier> (getCXXAccessSpecifierNative ((_arg0 : CXCursor)))

        type CX_StorageClass =
            | CX_SC_Invalid = 0
            | CX_SC_None = 1
            | CX_SC_Extern = 2
            | CX_SC_Static = 3
            | CX_SC_PrivateExtern = 4
            | CX_SC_OpenCLWorkGroupLocal = 5
            | CX_SC_Auto = 6
            | CX_SC_Register = 7

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_Cursor_getStorageClass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int (* CX_StorageClass *) cursor_getStorageClassNative(
            CXCursor arg0)
        let cursor_getStorageClass _arg0 =
            enum<CX_StorageClass> (cursor_getStorageClassNative ((_arg0 : CXCursor)))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getNumOverloadedDecls",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 getNumOverloadedDeclsNative(
            CXCursor cursor)
        let getNumOverloadedDecls _cursor =
            getNumOverloadedDeclsNative ((_cursor : CXCursor))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getOverloadedDecl",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXCursor getOverloadedDeclNative(
            CXCursor cursor,
            uint32 index)
        let getOverloadedDecl _cursor _index =
            getOverloadedDeclNative ((_cursor : CXCursor), _index)

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getIBOutletCollectionType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXType getIBOutletCollectionTypeNative(
            CXCursor arg0)
        let getIBOutletCollectionType _arg0 =
            getIBOutletCollectionTypeNative ((_arg0 : CXCursor))

        type CXChildVisitResult =
            | CXChildVisit_Break = 0
            | CXChildVisit_Continue = 1
            | CXChildVisit_Recurse = 2

        type CXCursorVisitor = delegate of CXCursor * CXCursor * nativeint (* CXClientData *) -> CXChildVisitResult (* CXChildVisitResult *)

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_visitChildren",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 visitChildrenNative(
            CXCursor parent,
            CXCursorVisitor (* function pointer *) visitor,
            void* (* CXClientData *) client_data)
        let visitChildren _parent _visitor _client_data =
            visitChildrenNative ((_parent : CXCursor), _visitor, (_client_data : CXClientData).Ptr)

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getCursorUSR",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXString getCursorUSRNative(
            CXCursor arg0)
        let getCursorUSR _arg0 =
            getCursorUSRNative ((_arg0 : CXCursor))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_constructUSR_ObjCClass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXString constructUSR_ObjCClassNative(
            string class_name)
        let constructUSR_ObjCClass _class_name =
            constructUSR_ObjCClassNative (_class_name)

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_constructUSR_ObjCCategory",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXString constructUSR_ObjCCategoryNative(
            string class_name,
            string category_name)
        let constructUSR_ObjCCategory _class_name _category_name =
            constructUSR_ObjCCategoryNative (_class_name, _category_name)

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_constructUSR_ObjCProtocol",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXString constructUSR_ObjCProtocolNative(
            string protocol_name)
        let constructUSR_ObjCProtocol _protocol_name =
            constructUSR_ObjCProtocolNative (_protocol_name)

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_constructUSR_ObjCIvar",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXString constructUSR_ObjCIvarNative(
            string name,
            CXString classUSR)
        let constructUSR_ObjCIvar _name _classUSR =
            constructUSR_ObjCIvarNative (_name, (_classUSR : CXString))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_constructUSR_ObjCMethod",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXString constructUSR_ObjCMethodNative(
            string name,
            uint32 isInstanceMethod,
            CXString classUSR)
        let constructUSR_ObjCMethod _name _isInstanceMethod _classUSR =
            constructUSR_ObjCMethodNative (_name, _isInstanceMethod, (_classUSR : CXString))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_constructUSR_ObjCProperty",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXString constructUSR_ObjCPropertyNative(
            string property,
            CXString classUSR)
        let constructUSR_ObjCProperty _property _classUSR =
            constructUSR_ObjCPropertyNative (_property, (_classUSR : CXString))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getCursorSpelling",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXString getCursorSpellingNative(
            CXCursor arg0)
        let getCursorSpelling _arg0 =
            getCursorSpellingNative ((_arg0 : CXCursor))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_Cursor_getSpellingNameRange",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXSourceRange cursor_getSpellingNameRangeNative(
            CXCursor arg0,
            uint32 pieceIndex,
            uint32 options)
        let cursor_getSpellingNameRange _arg0 _pieceIndex _options =
            cursor_getSpellingNameRangeNative ((_arg0 : CXCursor), _pieceIndex, _options)

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getCursorDisplayName",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXString getCursorDisplayNameNative(
            CXCursor arg0)
        let getCursorDisplayName _arg0 =
            getCursorDisplayNameNative ((_arg0 : CXCursor))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getCursorReferenced",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXCursor getCursorReferencedNative(
            CXCursor arg0)
        let getCursorReferenced _arg0 =
            getCursorReferencedNative ((_arg0 : CXCursor))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getCursorDefinition",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXCursor getCursorDefinitionNative(
            CXCursor arg0)
        let getCursorDefinition _arg0 =
            getCursorDefinitionNative ((_arg0 : CXCursor))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_isCursorDefinition",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 isCursorDefinitionNative(
            CXCursor arg0)
        let isCursorDefinition _arg0 =
            isCursorDefinitionNative ((_arg0 : CXCursor))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getCanonicalCursor",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXCursor getCanonicalCursorNative(
            CXCursor arg0)
        let getCanonicalCursor _arg0 =
            getCanonicalCursorNative ((_arg0 : CXCursor))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_Cursor_getObjCSelectorIndex",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int cursor_getObjCSelectorIndexNative(
            CXCursor arg0)
        let cursor_getObjCSelectorIndex _arg0 =
            cursor_getObjCSelectorIndexNative ((_arg0 : CXCursor))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_Cursor_isDynamicCall",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int cursor_isDynamicCallNative(
            CXCursor C)
        let cursor_isDynamicCall _C =
            cursor_isDynamicCallNative ((_C : CXCursor))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_Cursor_getReceiverType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXType cursor_getReceiverTypeNative(
            CXCursor C)
        let cursor_getReceiverType _C =
            cursor_getReceiverTypeNative ((_C : CXCursor))

        type CXObjCPropertyAttrKind =
            | CXObjCPropertyAttr_noattr = 0
            | CXObjCPropertyAttr_readonly = 1
            | CXObjCPropertyAttr_getter = 2
            | CXObjCPropertyAttr_assign = 4
            | CXObjCPropertyAttr_readwrite = 8
            | CXObjCPropertyAttr_retain = 16
            | CXObjCPropertyAttr_copy = 32
            | CXObjCPropertyAttr_nonatomic = 64
            | CXObjCPropertyAttr_setter = 128
            | CXObjCPropertyAttr_atomic = 256
            | CXObjCPropertyAttr_weak = 512
            | CXObjCPropertyAttr_strong = 1024
            | CXObjCPropertyAttr_unsafe_unretained = 2048

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_Cursor_getObjCPropertyAttributes",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 cursor_getObjCPropertyAttributesNative(
            CXCursor C,
            uint32 reserved)
        let cursor_getObjCPropertyAttributes _C _reserved =
            cursor_getObjCPropertyAttributesNative ((_C : CXCursor), _reserved)

        type CXObjCDeclQualifierKind =
            | CXObjCDeclQualifier_None = 0
            | CXObjCDeclQualifier_In = 1
            | CXObjCDeclQualifier_Inout = 2
            | CXObjCDeclQualifier_Out = 4
            | CXObjCDeclQualifier_Bycopy = 8
            | CXObjCDeclQualifier_Byref = 16
            | CXObjCDeclQualifier_Oneway = 32

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_Cursor_getObjCDeclQualifiers",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 cursor_getObjCDeclQualifiersNative(
            CXCursor C)
        let cursor_getObjCDeclQualifiers _C =
            cursor_getObjCDeclQualifiersNative ((_C : CXCursor))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_Cursor_isObjCOptional",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 cursor_isObjCOptionalNative(
            CXCursor C)
        let cursor_isObjCOptional _C =
            cursor_isObjCOptionalNative ((_C : CXCursor))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_Cursor_isVariadic",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 cursor_isVariadicNative(
            CXCursor C)
        let cursor_isVariadic _C =
            cursor_isVariadicNative ((_C : CXCursor))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_Cursor_getCommentRange",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXSourceRange cursor_getCommentRangeNative(
            CXCursor C)
        let cursor_getCommentRange _C =
            cursor_getCommentRangeNative ((_C : CXCursor))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_Cursor_getRawCommentText",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXString cursor_getRawCommentTextNative(
            CXCursor C)
        let cursor_getRawCommentText _C =
            cursor_getRawCommentTextNative ((_C : CXCursor))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_Cursor_getBriefCommentText",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXString cursor_getBriefCommentTextNative(
            CXCursor C)
        let cursor_getBriefCommentText _C =
            cursor_getBriefCommentTextNative ((_C : CXCursor))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_Cursor_getMangling",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXString cursor_getManglingNative(
            CXCursor arg0)
        let cursor_getMangling _arg0 =
            cursor_getManglingNative ((_arg0 : CXCursor))

        type CXModule (thePtr : nativeint) =
            member x.Ptr = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr = thePtr

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_Cursor_getModule",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* CXModule *) cursor_getModuleNative(
            CXCursor C)
        let cursor_getModule _C =
            new CXModule (cursor_getModuleNative ((_C : CXCursor)))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getModuleForFile",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* CXModule *) getModuleForFileNative(
            void* (* CXTranslationUnit *) arg0,
            void* (* CXFile *) arg1)
        let getModuleForFile _arg0 _arg1 =
            new CXModule (getModuleForFileNative ((_arg0 : CXTranslationUnit).Ptr, (_arg1 : CXFile).Ptr))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_Module_getASTFile",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* CXFile *) module_getASTFileNative(
            void* (* CXModule *) Module)
        let module_getASTFile _Module =
            new CXFile (module_getASTFileNative ((_Module : CXModule).Ptr))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_Module_getParent",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* CXModule *) module_getParentNative(
            void* (* CXModule *) Module)
        let module_getParent _Module =
            new CXModule (module_getParentNative ((_Module : CXModule).Ptr))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_Module_getName",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXString module_getNameNative(
            void* (* CXModule *) Module)
        let module_getName _Module =
            module_getNameNative ((_Module : CXModule).Ptr)

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_Module_getFullName",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXString module_getFullNameNative(
            void* (* CXModule *) Module)
        let module_getFullName _Module =
            module_getFullNameNative ((_Module : CXModule).Ptr)

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_Module_isSystem",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int module_isSystemNative(
            void* (* CXModule *) Module)
        let module_isSystem _Module =
            module_isSystemNative ((_Module : CXModule).Ptr)

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_Module_getNumTopLevelHeaders",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 module_getNumTopLevelHeadersNative(
            void* (* CXTranslationUnit *) arg0,
            void* (* CXModule *) Module)
        let module_getNumTopLevelHeaders _arg0 _Module =
            module_getNumTopLevelHeadersNative ((_arg0 : CXTranslationUnit).Ptr, (_Module : CXModule).Ptr)

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_Module_getTopLevelHeader",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* CXFile *) module_getTopLevelHeaderNative(
            void* (* CXTranslationUnit *) arg0,
            void* (* CXModule *) Module,
            uint32 Index)
        let module_getTopLevelHeader _arg0 _Module _Index =
            new CXFile (module_getTopLevelHeaderNative ((_arg0 : CXTranslationUnit).Ptr, (_Module : CXModule).Ptr, _Index))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_CXXMethod_isPureVirtual",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 cXXMethod_isPureVirtualNative(
            CXCursor C)
        let cXXMethod_isPureVirtual _C =
            cXXMethod_isPureVirtualNative ((_C : CXCursor))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_CXXMethod_isStatic",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 cXXMethod_isStaticNative(
            CXCursor C)
        let cXXMethod_isStatic _C =
            cXXMethod_isStaticNative ((_C : CXCursor))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_CXXMethod_isVirtual",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 cXXMethod_isVirtualNative(
            CXCursor C)
        let cXXMethod_isVirtual _C =
            cXXMethod_isVirtualNative ((_C : CXCursor))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_CXXMethod_isConst",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 cXXMethod_isConstNative(
            CXCursor C)
        let cXXMethod_isConst _C =
            cXXMethod_isConstNative ((_C : CXCursor))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getTemplateCursorKind",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int (* CXCursorKind *) getTemplateCursorKindNative(
            CXCursor C)
        let getTemplateCursorKind _C =
            enum<CXCursorKind> (getTemplateCursorKindNative ((_C : CXCursor)))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getSpecializedCursorTemplate",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXCursor getSpecializedCursorTemplateNative(
            CXCursor C)
        let getSpecializedCursorTemplate _C =
            getSpecializedCursorTemplateNative ((_C : CXCursor))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getCursorReferenceNameRange",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXSourceRange getCursorReferenceNameRangeNative(
            CXCursor C,
            uint32 NameFlags,
            uint32 PieceIndex)
        let getCursorReferenceNameRange _C _NameFlags _PieceIndex =
            getCursorReferenceNameRangeNative ((_C : CXCursor), _NameFlags, _PieceIndex)

        type CXNameRefFlags =
            | CXNameRange_WantQualifier = 1
            | CXNameRange_WantTemplateArgs = 2
            | CXNameRange_WantSinglePiece = 4

        type CXTokenKind =
            | CXToken_Punctuation = 0
            | CXToken_Keyword = 1
            | CXToken_Identifier = 2
            | CXToken_Literal = 3
            | CXToken_Comment = 4

        [<Struct>]
        type CXToken =
            val mutable int_data0 : uint32
            val mutable int_data1 : uint32
            val mutable int_data2 : uint32
            val mutable int_data3 : uint32
            val mutable ptr_data : nativeint (* nativeptr<void> *)

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getTokenKind",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int (* CXTokenKind *) getTokenKindNative(
            CXToken arg0)
        let getTokenKind _arg0 =
            enum<CXTokenKind> (getTokenKindNative ((_arg0 : CXToken)))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getTokenSpelling",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXString getTokenSpellingNative(
            void* (* CXTranslationUnit *) arg0,
            CXToken arg1)
        let getTokenSpelling _arg0 _arg1 =
            getTokenSpellingNative ((_arg0 : CXTranslationUnit).Ptr, (_arg1 : CXToken))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getTokenLocation",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXSourceLocation getTokenLocationNative(
            void* (* CXTranslationUnit *) arg0,
            CXToken arg1)
        let getTokenLocation _arg0 _arg1 =
            getTokenLocationNative ((_arg0 : CXTranslationUnit).Ptr, (_arg1 : CXToken))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getTokenExtent",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXSourceRange getTokenExtentNative(
            void* (* CXTranslationUnit *) arg0,
            CXToken arg1)
        let getTokenExtent _arg0 _arg1 =
            getTokenExtentNative ((_arg0 : CXTranslationUnit).Ptr, (_arg1 : CXToken))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_tokenize",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void tokenizeNative(
            void* (* CXTranslationUnit *) TU,
            CXSourceRange Range,
            CXToken Tokens,
            uint32* NumTokens)
        // I don't know how to generate an "F# friendly" version of clang_tokenize

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_annotateTokens",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void annotateTokensNative(
            void* (* CXTranslationUnit *) TU,
            CXToken Tokens,
            uint32 NumTokens,
            CXCursor Cursors)
        // I don't know how to generate an "F# friendly" version of clang_annotateTokens

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_disposeTokens",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void disposeTokensNative(
            void* (* CXTranslationUnit *) TU,
            CXToken Tokens,
            uint32 NumTokens)
        // I don't know how to generate an "F# friendly" version of clang_disposeTokens

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getCursorKindSpelling",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXString getCursorKindSpellingNative(
            int (* CXCursorKind *) Kind)
        let getCursorKindSpelling _Kind =
            getCursorKindSpellingNative ((int (_Kind : CXCursorKind)))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getDefinitionSpellingAndExtent",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void getDefinitionSpellingAndExtentNative(
            CXCursor arg0,
            void* startBuf,
            void* endBuf,
            uint32* startLine,
            uint32* startColumn,
            uint32* endLine,
            uint32* endColumn)
        // I don't know how to generate an "F# friendly" version of clang_getDefinitionSpellingAndExtent

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_enableStackTraces",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void enableStackTracesNative()
        let enableStackTraces () =
            enableStackTracesNative ()

        type Fn = delegate of nativeint (* nativeptr<void> *) -> Unit

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_executeOnThread",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void executeOnThreadNative(
            Fn (* void ( *fn )( void* ) *) fn,
            void* user_data,
            uint32 stack_size)
        // I don't know how to generate an "F# friendly" version of clang_executeOnThread

        type CXCompletionString (thePtr : nativeint) =
            member x.Ptr = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr = thePtr

        [<Struct>]
        type CXCompletionResult =
            val mutable CursorKind : CXCursorKind (* CXCursorKind *)
            val mutable CompletionString : nativeint (* CXCompletionString *)

        type CXCompletionChunkKind =
            | CXCompletionChunk_Optional = 0
            | CXCompletionChunk_TypedText = 1
            | CXCompletionChunk_Text = 2
            | CXCompletionChunk_Placeholder = 3
            | CXCompletionChunk_Informative = 4
            | CXCompletionChunk_CurrentParameter = 5
            | CXCompletionChunk_LeftParen = 6
            | CXCompletionChunk_RightParen = 7
            | CXCompletionChunk_LeftBracket = 8
            | CXCompletionChunk_RightBracket = 9
            | CXCompletionChunk_LeftBrace = 10
            | CXCompletionChunk_RightBrace = 11
            | CXCompletionChunk_LeftAngle = 12
            | CXCompletionChunk_RightAngle = 13
            | CXCompletionChunk_Comma = 14
            | CXCompletionChunk_ResultType = 15
            | CXCompletionChunk_Colon = 16
            | CXCompletionChunk_SemiColon = 17
            | CXCompletionChunk_Equal = 18
            | CXCompletionChunk_HorizontalSpace = 19
            | CXCompletionChunk_VerticalSpace = 20

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getCompletionChunkKind",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int (* CXCompletionChunkKind *) getCompletionChunkKindNative(
            void* (* CXCompletionString *) completion_string,
            uint32 chunk_number)
        let getCompletionChunkKind _completion_string _chunk_number =
            enum<CXCompletionChunkKind> (getCompletionChunkKindNative ((_completion_string : CXCompletionString).Ptr, _chunk_number))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getCompletionChunkText",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXString getCompletionChunkTextNative(
            void* (* CXCompletionString *) completion_string,
            uint32 chunk_number)
        let getCompletionChunkText _completion_string _chunk_number =
            getCompletionChunkTextNative ((_completion_string : CXCompletionString).Ptr, _chunk_number)

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getCompletionChunkCompletionString",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* CXCompletionString *) getCompletionChunkCompletionStringNative(
            void* (* CXCompletionString *) completion_string,
            uint32 chunk_number)
        let getCompletionChunkCompletionString _completion_string _chunk_number =
            new CXCompletionString (getCompletionChunkCompletionStringNative ((_completion_string : CXCompletionString).Ptr, _chunk_number))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getNumCompletionChunks",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 getNumCompletionChunksNative(
            void* (* CXCompletionString *) completion_string)
        let getNumCompletionChunks _completion_string =
            getNumCompletionChunksNative ((_completion_string : CXCompletionString).Ptr)

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getCompletionPriority",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 getCompletionPriorityNative(
            void* (* CXCompletionString *) completion_string)
        let getCompletionPriority _completion_string =
            getCompletionPriorityNative ((_completion_string : CXCompletionString).Ptr)

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getCompletionAvailability",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int (* CXAvailabilityKind *) getCompletionAvailabilityNative(
            void* (* CXCompletionString *) completion_string)
        let getCompletionAvailability _completion_string =
            enum<CXAvailabilityKind> (getCompletionAvailabilityNative ((_completion_string : CXCompletionString).Ptr))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getCompletionNumAnnotations",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 getCompletionNumAnnotationsNative(
            void* (* CXCompletionString *) completion_string)
        let getCompletionNumAnnotations _completion_string =
            getCompletionNumAnnotationsNative ((_completion_string : CXCompletionString).Ptr)

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getCompletionAnnotation",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXString getCompletionAnnotationNative(
            void* (* CXCompletionString *) completion_string,
            uint32 annotation_number)
        let getCompletionAnnotation _completion_string _annotation_number =
            getCompletionAnnotationNative ((_completion_string : CXCompletionString).Ptr, _annotation_number)

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getCompletionParent",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXString getCompletionParentNative(
            void* (* CXCompletionString *) completion_string,
            int (* CXCursorKind* *)* kind)
        // I don't know how to generate an "F# friendly" version of clang_getCompletionParent

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getCompletionBriefComment",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXString getCompletionBriefCommentNative(
            void* (* CXCompletionString *) completion_string)
        let getCompletionBriefComment _completion_string =
            getCompletionBriefCommentNative ((_completion_string : CXCompletionString).Ptr)

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getCursorCompletionString",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* CXCompletionString *) getCursorCompletionStringNative(
            CXCursor cursor)
        let getCursorCompletionString _cursor =
            new CXCompletionString (getCursorCompletionStringNative ((_cursor : CXCursor)))

        [<Struct>]
        type CXCodeCompleteResults =
            val mutable Results : CXCompletionResult
            val mutable NumResults : uint32

        type CXCodeComplete_Flags =
            | CXCodeComplete_IncludeMacros = 1
            | CXCodeComplete_IncludeCodePatterns = 2
            | CXCodeComplete_IncludeBriefComments = 4

        type CXCompletionContext =
            | CXCompletionContext_Unexposed = 0
            | CXCompletionContext_AnyType = 1
            | CXCompletionContext_AnyValue = 2
            | CXCompletionContext_ObjCObjectValue = 4
            | CXCompletionContext_ObjCSelectorValue = 8
            | CXCompletionContext_CXXClassTypeValue = 16
            | CXCompletionContext_DotMemberAccess = 32
            | CXCompletionContext_ArrowMemberAccess = 64
            | CXCompletionContext_ObjCPropertyAccess = 128
            | CXCompletionContext_EnumTag = 256
            | CXCompletionContext_UnionTag = 512
            | CXCompletionContext_StructTag = 1024
            | CXCompletionContext_ClassTag = 2048
            | CXCompletionContext_Namespace = 4096
            | CXCompletionContext_NestedNameSpecifier = 8192
            | CXCompletionContext_ObjCInterface = 16384
            | CXCompletionContext_ObjCProtocol = 32768
            | CXCompletionContext_ObjCCategory = 65536
            | CXCompletionContext_ObjCInstanceMessage = 131072
            | CXCompletionContext_ObjCClassMessage = 262144
            | CXCompletionContext_ObjCSelectorName = 524288
            | CXCompletionContext_MacroName = 1048576
            | CXCompletionContext_NaturalLanguage = 2097152
            | CXCompletionContext_Unknown = 4194303

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_defaultCodeCompleteOptions",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 defaultCodeCompleteOptionsNative()
        let defaultCodeCompleteOptions () =
            defaultCodeCompleteOptionsNative ()

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_codeCompleteAt",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXCodeCompleteResults codeCompleteAtNative(
            void* (* CXTranslationUnit *) TU,
            string complete_filename,
            uint32 complete_line,
            uint32 complete_column,
            CXUnsavedFile* unsaved_files,
            uint32 num_unsaved_files,
            uint32 options)
        // I don't know how to generate an "F# friendly" version of clang_codeCompleteAt

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_sortCodeCompletionResults",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void sortCodeCompletionResultsNative(
            CXCompletionResult Results,
            uint32 NumResults)
        // I don't know how to generate an "F# friendly" version of clang_sortCodeCompletionResults

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_disposeCodeCompleteResults",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void disposeCodeCompleteResultsNative(
            CXCodeCompleteResults Results)
        // I don't know how to generate an "F# friendly" version of clang_disposeCodeCompleteResults

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_codeCompleteGetNumDiagnostics",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 codeCompleteGetNumDiagnosticsNative(
            CXCodeCompleteResults Results)
        // I don't know how to generate an "F# friendly" version of clang_codeCompleteGetNumDiagnostics

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_codeCompleteGetDiagnostic",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* CXDiagnostic *) codeCompleteGetDiagnosticNative(
            CXCodeCompleteResults Results,
            uint32 Index)
        // I don't know how to generate an "F# friendly" version of clang_codeCompleteGetDiagnostic

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_codeCompleteGetContexts",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint64 codeCompleteGetContextsNative(
            CXCodeCompleteResults Results)
        // I don't know how to generate an "F# friendly" version of clang_codeCompleteGetContexts

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_codeCompleteGetContainerKind",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int (* CXCursorKind *) codeCompleteGetContainerKindNative(
            CXCodeCompleteResults Results,
            uint32* IsIncomplete)
        // I don't know how to generate an "F# friendly" version of clang_codeCompleteGetContainerKind

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_codeCompleteGetContainerUSR",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXString codeCompleteGetContainerUSRNative(
            CXCodeCompleteResults Results)
        // I don't know how to generate an "F# friendly" version of clang_codeCompleteGetContainerUSR

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_codeCompleteGetObjCSelector",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXString codeCompleteGetObjCSelectorNative(
            CXCodeCompleteResults Results)
        // I don't know how to generate an "F# friendly" version of clang_codeCompleteGetObjCSelector

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getClangVersion",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXString getClangVersionNative()
        let getClangVersion () =
            getClangVersionNative ()

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_toggleCrashRecovery",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void toggleCrashRecoveryNative(
            uint32 isEnabled)
        let toggleCrashRecovery _isEnabled =
            toggleCrashRecoveryNative (_isEnabled)

        type CXInclusionVisitor = delegate of nativeint (* CXFile *) * CXSourceLocation * uint32 * nativeint (* CXClientData *) -> Unit

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getInclusions",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void getInclusionsNative(
            void* (* CXTranslationUnit *) tu,
            CXInclusionVisitor (* function pointer *) visitor,
            void* (* CXClientData *) client_data)
        let getInclusions _tu _visitor _client_data =
            getInclusionsNative ((_tu : CXTranslationUnit).Ptr, _visitor, (_client_data : CXClientData).Ptr)

        type CXRemapping (thePtr : nativeint) =
            member x.Ptr = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr = thePtr

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getRemappings",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* CXRemapping *) getRemappingsNative(
            string path)
        let getRemappings _path =
            new CXRemapping (getRemappingsNative (_path))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_getRemappingsFromFileList",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* CXRemapping *) getRemappingsFromFileListNative(
            void* filePaths,
            uint32 numFiles)
        // I don't know how to generate an "F# friendly" version of clang_getRemappingsFromFileList

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_remap_getNumFiles",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 remap_getNumFilesNative(
            void* (* CXRemapping *) arg0)
        let remap_getNumFiles _arg0 =
            remap_getNumFilesNative ((_arg0 : CXRemapping).Ptr)

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_remap_getFilenames",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void remap_getFilenamesNative(
            void* (* CXRemapping *) arg0,
            uint32 index,
            CXString original,
            CXString transformed)
        // I don't know how to generate an "F# friendly" version of clang_remap_getFilenames

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_remap_dispose",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void remap_disposeNative(
            void* (* CXRemapping *) arg0)
        let remap_dispose _arg0 =
            remap_disposeNative ((_arg0 : CXRemapping).Ptr)

        type CXVisitorResult =
            | CXVisit_Break = 0
            | CXVisit_Continue = 1

        type Visit = delegate of nativeint (* nativeptr<void> *) * CXCursor * CXSourceRange -> CXVisitorResult (* CXVisitorResult *)

        [<Struct>]
        type CXCursorAndRangeVisitor =
            val mutable context : nativeint (* nativeptr<void> *)
            val mutable visit : Visit (* CXVisitorResult ( *visit )( void*, CXCursor, CXSourceRange ) *)

        type CXResult =
            | CXResult_Success = 0
            | CXResult_Invalid = 1
            | CXResult_VisitBreak = 2

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_findReferencesInFile",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int (* CXResult *) findReferencesInFileNative(
            CXCursor cursor,
            void* (* CXFile *) file,
            CXCursorAndRangeVisitor visitor)
        let findReferencesInFile _cursor _file _visitor =
            enum<CXResult> (findReferencesInFileNative ((_cursor : CXCursor), (_file : CXFile).Ptr, (_visitor : CXCursorAndRangeVisitor)))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_findIncludesInFile",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int (* CXResult *) findIncludesInFileNative(
            void* (* CXTranslationUnit *) TU,
            void* (* CXFile *) file,
            CXCursorAndRangeVisitor visitor)
        let findIncludesInFile _TU _file _visitor =
            enum<CXResult> (findIncludesInFileNative ((_TU : CXTranslationUnit).Ptr, (_file : CXFile).Ptr, (_visitor : CXCursorAndRangeVisitor)))

        type CXIdxClientFile (thePtr : nativeint) =
            member x.Ptr = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr = thePtr

        type CXIdxClientEntity (thePtr : nativeint) =
            member x.Ptr = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr = thePtr

        type CXIdxClientContainer (thePtr : nativeint) =
            member x.Ptr = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr = thePtr

        type CXIdxClientASTFile (thePtr : nativeint) =
            member x.Ptr = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr = thePtr

        [<Struct>]
        type CXIdxLoc =
            val mutable ptr_data0 : nativeint (* nativeptr<void> *)
            val mutable ptr_data1 : nativeint (* nativeptr<void> *)
            val mutable int_data : uint32

        [<Struct>]
        type CXIdxIncludedFileInfo =
            val mutable hashLoc : CXIdxLoc
            val mutable filename : nativeint
            val mutable file : nativeint (* CXFile *)
            val mutable isImport : int
            val mutable isAngled : int
            val mutable isModuleImport : int

        [<Struct>]
        type CXIdxImportedASTFileInfo =
            val mutable file : nativeint (* CXFile *)
            val mutable _module : nativeint (* CXModule *)
            val mutable loc : CXIdxLoc
            val mutable isImplicit : int

        type CXIdxEntityKind =
            | CXIdxEntity_Unexposed = 0
            | CXIdxEntity_Typedef = 1
            | CXIdxEntity_Function = 2
            | CXIdxEntity_Variable = 3
            | CXIdxEntity_Field = 4
            | CXIdxEntity_EnumConstant = 5
            | CXIdxEntity_ObjCClass = 6
            | CXIdxEntity_ObjCProtocol = 7
            | CXIdxEntity_ObjCCategory = 8
            | CXIdxEntity_ObjCInstanceMethod = 9
            | CXIdxEntity_ObjCClassMethod = 10
            | CXIdxEntity_ObjCProperty = 11
            | CXIdxEntity_ObjCIvar = 12
            | CXIdxEntity_Enum = 13
            | CXIdxEntity_Struct = 14
            | CXIdxEntity_Union = 15
            | CXIdxEntity_CXXClass = 16
            | CXIdxEntity_CXXNamespace = 17
            | CXIdxEntity_CXXNamespaceAlias = 18
            | CXIdxEntity_CXXStaticVariable = 19
            | CXIdxEntity_CXXStaticMethod = 20
            | CXIdxEntity_CXXInstanceMethod = 21
            | CXIdxEntity_CXXConstructor = 22
            | CXIdxEntity_CXXDestructor = 23
            | CXIdxEntity_CXXConversionFunction = 24
            | CXIdxEntity_CXXTypeAlias = 25
            | CXIdxEntity_CXXInterface = 26

        type CXIdxEntityLanguage =
            | CXIdxEntityLang_None = 0
            | CXIdxEntityLang_C = 1
            | CXIdxEntityLang_ObjC = 2
            | CXIdxEntityLang_CXX = 3

        type CXIdxEntityCXXTemplateKind =
            | CXIdxEntity_NonTemplate = 0
            | CXIdxEntity_Template = 1
            | CXIdxEntity_TemplatePartialSpecialization = 2
            | CXIdxEntity_TemplateSpecialization = 3

        type CXIdxAttrKind =
            | CXIdxAttr_Unexposed = 0
            | CXIdxAttr_IBAction = 1
            | CXIdxAttr_IBOutlet = 2
            | CXIdxAttr_IBOutletCollection = 3

        [<Struct>]
        type CXIdxAttrInfo =
            val mutable kind : CXIdxAttrKind (* CXIdxAttrKind *)
            val mutable cursor : CXCursor
            val mutable loc : CXIdxLoc

        [<Struct>]
        type CXIdxEntityInfo =
            val mutable kind : CXIdxEntityKind (* CXIdxEntityKind *)
            val mutable templateKind : CXIdxEntityCXXTemplateKind (* CXIdxEntityCXXTemplateKind *)
            val mutable lang : CXIdxEntityLanguage (* CXIdxEntityLanguage *)
            val mutable name : nativeint
            val mutable USR : nativeint
            val mutable cursor : CXCursor
            val mutable attributes : CXIdxAttrInfo
            val mutable numAttributes : uint32

        [<Struct>]
        type CXIdxContainerInfo =
            val mutable cursor : CXCursor

        [<Struct>]
        type CXIdxIBOutletCollectionAttrInfo =
            val mutable attrInfo : CXIdxAttrInfo
            val mutable objcClass : CXIdxEntityInfo
            val mutable classCursor : CXCursor
            val mutable classLoc : CXIdxLoc

        type CXIdxDeclInfoFlags =
            | CXIdxDeclFlag_Skipped = 1

        [<Struct>]
        type CXIdxDeclInfo =
            val mutable entityInfo : CXIdxEntityInfo
            val mutable cursor : CXCursor
            val mutable loc : CXIdxLoc
            val mutable semanticContainer : CXIdxContainerInfo
            val mutable lexicalContainer : CXIdxContainerInfo
            val mutable isRedeclaration : int
            val mutable isDefinition : int
            val mutable isContainer : int
            val mutable declAsContainer : CXIdxContainerInfo
            val mutable isImplicit : int
            val mutable attributes : CXIdxAttrInfo
            val mutable numAttributes : uint32
            val mutable flags : uint32

        type CXIdxObjCContainerKind =
            | CXIdxObjCContainer_ForwardRef = 0
            | CXIdxObjCContainer_Interface = 1
            | CXIdxObjCContainer_Implementation = 2

        [<Struct>]
        type CXIdxObjCContainerDeclInfo =
            val mutable declInfo : CXIdxDeclInfo
            val mutable kind : CXIdxObjCContainerKind (* CXIdxObjCContainerKind *)

        [<Struct>]
        type CXIdxBaseClassInfo =
            val mutable _base : CXIdxEntityInfo
            val mutable cursor : CXCursor
            val mutable loc : CXIdxLoc

        [<Struct>]
        type CXIdxObjCProtocolRefInfo =
            val mutable protocol : CXIdxEntityInfo
            val mutable cursor : CXCursor
            val mutable loc : CXIdxLoc

        [<Struct>]
        type CXIdxObjCProtocolRefListInfo =
            val mutable protocols : CXIdxObjCProtocolRefInfo
            val mutable numProtocols : uint32

        [<Struct>]
        type CXIdxObjCInterfaceDeclInfo =
            val mutable containerInfo : CXIdxObjCContainerDeclInfo
            val mutable superInfo : CXIdxBaseClassInfo
            val mutable protocols : CXIdxObjCProtocolRefListInfo

        [<Struct>]
        type CXIdxObjCCategoryDeclInfo =
            val mutable containerInfo : CXIdxObjCContainerDeclInfo
            val mutable objcClass : CXIdxEntityInfo
            val mutable classCursor : CXCursor
            val mutable classLoc : CXIdxLoc
            val mutable protocols : CXIdxObjCProtocolRefListInfo

        [<Struct>]
        type CXIdxObjCPropertyDeclInfo =
            val mutable declInfo : CXIdxDeclInfo
            val mutable getter : CXIdxEntityInfo
            val mutable setter : CXIdxEntityInfo

        [<Struct>]
        type CXIdxCXXClassDeclInfo =
            val mutable declInfo : CXIdxDeclInfo
            val mutable bases : CXIdxBaseClassInfo
            val mutable numBases : uint32

        type CXIdxEntityRefKind =
            | CXIdxEntityRef_Direct = 1
            | CXIdxEntityRef_Implicit = 2

        [<Struct>]
        type CXIdxEntityRefInfo =
            val mutable kind : CXIdxEntityRefKind (* CXIdxEntityRefKind *)
            val mutable cursor : CXCursor
            val mutable loc : CXIdxLoc
            val mutable referencedEntity : CXIdxEntityInfo
            val mutable parentEntity : CXIdxEntityInfo
            val mutable container : CXIdxContainerInfo

        type AbortQuery = delegate of nativeint (* CXClientData *) * nativeint (* nativeptr<void> *) -> int

        type Diagnostic = delegate of nativeint (* CXClientData *) * nativeint (* CXDiagnosticSet *) * nativeint (* nativeptr<void> *) -> Unit

        type EnteredMainFile = delegate of nativeint (* CXClientData *) * nativeint (* CXFile *) * nativeint (* nativeptr<void> *) -> nativeint (* CXIdxClientFile *)

        type PpIncludedFile = delegate of nativeint (* CXClientData *) * CXIdxIncludedFileInfo -> nativeint (* CXIdxClientFile *)

        type ImportedASTFile = delegate of nativeint (* CXClientData *) * CXIdxImportedASTFileInfo -> nativeint (* CXIdxClientASTFile *)

        type StartedTranslationUnit = delegate of nativeint (* CXClientData *) * nativeint (* nativeptr<void> *) -> nativeint (* CXIdxClientContainer *)

        type IndexDeclaration = delegate of nativeint (* CXClientData *) * CXIdxDeclInfo -> Unit

        type IndexEntityReference = delegate of nativeint (* CXClientData *) * CXIdxEntityRefInfo -> Unit

        [<Struct>]
        type IndexerCallbacks =
            val mutable abortQuery : AbortQuery (* int ( *abortQuery )( CXClientData, void* ) *)
            val mutable diagnostic : Diagnostic (* void ( *diagnostic )( CXClientData, CXDiagnosticSet, void* ) *)
            val mutable enteredMainFile : EnteredMainFile (* CXIdxClientFile ( *enteredMainFile )( CXClientData, CXFile, void* ) *)
            val mutable ppIncludedFile : PpIncludedFile (* CXIdxClientFile ( *ppIncludedFile )( CXClientData, const CXIdxIncludedFileInfo* ) *)
            val mutable importedASTFile : ImportedASTFile (* CXIdxClientASTFile ( *importedASTFile )( CXClientData, const CXIdxImportedASTFileInfo* ) *)
            val mutable startedTranslationUnit : StartedTranslationUnit (* CXIdxClientContainer ( *startedTranslationUnit )( CXClientData, void* ) *)
            val mutable indexDeclaration : IndexDeclaration (* void ( *indexDeclaration )( CXClientData, const CXIdxDeclInfo* ) *)
            val mutable indexEntityReference : IndexEntityReference (* void ( *indexEntityReference )( CXClientData, const CXIdxEntityRefInfo* ) *)

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_index_isEntityObjCContainerKind",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int index_isEntityObjCContainerKindNative(
            int (* CXIdxEntityKind *) arg0)
        let index_isEntityObjCContainerKind _arg0 =
            index_isEntityObjCContainerKindNative ((int (_arg0 : CXIdxEntityKind)))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_index_getObjCContainerDeclInfo",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXIdxObjCContainerDeclInfo index_getObjCContainerDeclInfoNative(
            CXIdxDeclInfo arg0)
        // I don't know how to generate an "F# friendly" version of clang_index_getObjCContainerDeclInfo

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_index_getObjCInterfaceDeclInfo",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXIdxObjCInterfaceDeclInfo index_getObjCInterfaceDeclInfoNative(
            CXIdxDeclInfo arg0)
        // I don't know how to generate an "F# friendly" version of clang_index_getObjCInterfaceDeclInfo

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_index_getObjCCategoryDeclInfo",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXIdxObjCCategoryDeclInfo index_getObjCCategoryDeclInfoNative(
            CXIdxDeclInfo arg0)
        // I don't know how to generate an "F# friendly" version of clang_index_getObjCCategoryDeclInfo

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_index_getObjCProtocolRefListInfo",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXIdxObjCProtocolRefListInfo index_getObjCProtocolRefListInfoNative(
            CXIdxDeclInfo arg0)
        // I don't know how to generate an "F# friendly" version of clang_index_getObjCProtocolRefListInfo

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_index_getObjCPropertyDeclInfo",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXIdxObjCPropertyDeclInfo index_getObjCPropertyDeclInfoNative(
            CXIdxDeclInfo arg0)
        // I don't know how to generate an "F# friendly" version of clang_index_getObjCPropertyDeclInfo

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_index_getIBOutletCollectionAttrInfo",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXIdxIBOutletCollectionAttrInfo index_getIBOutletCollectionAttrInfoNative(
            CXIdxAttrInfo arg0)
        // I don't know how to generate an "F# friendly" version of clang_index_getIBOutletCollectionAttrInfo

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_index_getCXXClassDeclInfo",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXIdxCXXClassDeclInfo index_getCXXClassDeclInfoNative(
            CXIdxDeclInfo arg0)
        // I don't know how to generate an "F# friendly" version of clang_index_getCXXClassDeclInfo

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_index_getClientContainer",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* CXIdxClientContainer *) index_getClientContainerNative(
            CXIdxContainerInfo arg0)
        // I don't know how to generate an "F# friendly" version of clang_index_getClientContainer

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_index_setClientContainer",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void index_setClientContainerNative(
            CXIdxContainerInfo arg0,
            void* (* CXIdxClientContainer *) arg1)
        // I don't know how to generate an "F# friendly" version of clang_index_setClientContainer

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_index_getClientEntity",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* CXIdxClientEntity *) index_getClientEntityNative(
            CXIdxEntityInfo arg0)
        // I don't know how to generate an "F# friendly" version of clang_index_getClientEntity

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_index_setClientEntity",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void index_setClientEntityNative(
            CXIdxEntityInfo arg0,
            void* (* CXIdxClientEntity *) arg1)
        // I don't know how to generate an "F# friendly" version of clang_index_setClientEntity

        type CXIndexAction (thePtr : nativeint) =
            member x.Ptr = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr = thePtr

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_IndexAction_create",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* CXIndexAction *) indexAction_createNative(
            void* (* CXIndex *) CIdx)
        let indexAction_create _CIdx =
            new CXIndexAction (indexAction_createNative ((_CIdx : CXIndex).Ptr))

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_IndexAction_dispose",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void indexAction_disposeNative(
            void* (* CXIndexAction *) arg0)
        let indexAction_dispose _arg0 =
            indexAction_disposeNative ((_arg0 : CXIndexAction).Ptr)

        type CXIndexOptFlags =
            | CXIndexOpt_None = 0
            | CXIndexOpt_SuppressRedundantRefs = 1
            | CXIndexOpt_IndexFunctionLocalSymbols = 2
            | CXIndexOpt_IndexImplicitTemplateInstantiations = 4
            | CXIndexOpt_SuppressWarnings = 8
            | CXIndexOpt_SkipParsedBodiesInSession = 16

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_indexSourceFile",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int indexSourceFileNative(
            void* (* CXIndexAction *) arg0,
            void* (* CXClientData *) client_data,
            IndexerCallbacks index_callbacks,
            uint32 index_callbacks_size,
            uint32 index_options,
            string source_filename,
            void* command_line_args,
            int num_command_line_args,
            CXUnsavedFile* unsaved_files,
            uint32 num_unsaved_files,
            void* (* CXTranslationUnit* *) out_TU,
            uint32 TU_options)
        // I don't know how to generate an "F# friendly" version of clang_indexSourceFile

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_indexTranslationUnit",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int indexTranslationUnitNative(
            void* (* CXIndexAction *) arg0,
            void* (* CXClientData *) client_data,
            IndexerCallbacks index_callbacks,
            uint32 index_callbacks_size,
            uint32 index_options,
            void* (* CXTranslationUnit *) arg5)
        // I don't know how to generate an "F# friendly" version of clang_indexTranslationUnit

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_indexLoc_getFileLocation",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void indexLoc_getFileLocationNative(
            CXIdxLoc loc,
            void* (* CXIdxClientFile* *) indexFile,
            void* (* CXFile* *) file,
            uint32* line,
            uint32* column,
            uint32* offset)
        // I don't know how to generate an "F# friendly" version of clang_indexLoc_getFileLocation

        [<DllImport(
            clangAssemblyName,
            EntryPoint="clang_indexLoc_getCXSourceLocation",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern CXSourceLocation indexLoc_getCXSourceLocationNative(
            CXIdxLoc loc)
        let indexLoc_getCXSourceLocation _loc =
            indexLoc_getCXSourceLocationNative ((_loc : CXIdxLoc))

