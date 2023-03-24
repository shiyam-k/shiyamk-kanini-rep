
//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.8.3928.0
//  Copyright (c) Microsoft Corporation.  All rights reserved.



// Metadata version: v4.0.30319
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly 'project_22-03-2023-cli'
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                             63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- The following custom attribute is added automatically, do not uncomment -------
  //  .custom instance void [mscorlib]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 07 01 00 00 00 00 ) 

  .custom instance void [mscorlib]System.Reflection.AssemblyTitleAttribute::.ctor(string) = ( 01 00 16 70 72 6F 6A 65 63 74 5F 32 32 2D 30 33   // ...project_22-03
                                                                                              2D 32 30 32 33 2D 63 6C 69 00 00 )                // -2023-cli..
  .custom instance void [mscorlib]System.Reflection.AssemblyDescriptionAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyConfigurationAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyCompanyAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyProductAttribute::.ctor(string) = ( 01 00 16 70 72 6F 6A 65 63 74 5F 32 32 2D 30 33   // ...project_22-03
                                                                                                2D 32 30 32 33 2D 63 6C 69 00 00 )                // -2023-cli..
  .custom instance void [mscorlib]System.Reflection.AssemblyCopyrightAttribute::.ctor(string) = ( 01 00 12 43 6F 70 79 72 69 67 68 74 20 C2 A9 20   // ...Copyright .. 
                                                                                                  20 32 30 32 33 00 00 )                            //  2023..
  .custom instance void [mscorlib]System.Reflection.AssemblyTrademarkAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.InteropServices.ComVisibleAttribute::.ctor(bool) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.InteropServices.GuidAttribute::.ctor(string) = ( 01 00 24 61 30 62 34 35 30 37 66 2D 31 62 32 65   // ..$a0b4507f-1b2e
                                                                                                  2D 34 30 65 38 2D 39 63 39 34 2D 63 33 35 38 37   // -40e8-9c94-c3587
                                                                                                  66 39 33 63 63 64 33 00 00 )                      // f93ccd3..
  .custom instance void [mscorlib]System.Reflection.AssemblyFileVersionAttribute::.ctor(string) = ( 01 00 07 31 2E 30 2E 30 2E 30 00 00 )             // ...1.0.0.0..
  .custom instance void [mscorlib]System.Runtime.Versioning.TargetFrameworkAttribute::.ctor(string) = ( 01 00 1A 2E 4E 45 54 46 72 61 6D 65 77 6F 72 6B   // ....NETFramework
                                                                                                        2C 56 65 72 73 69 6F 6E 3D 76 34 2E 38 01 00 54   // ,Version=v4.8..T
                                                                                                        0E 14 46 72 61 6D 65 77 6F 72 6B 44 69 73 70 6C   // ..FrameworkDispl
                                                                                                        61 79 4E 61 6D 65 12 2E 4E 45 54 20 46 72 61 6D   // ayName..NET Fram
                                                                                                        65 77 6F 72 6B 20 34 2E 38 )                      // ework 4.8
  .hash algorithm 0x00008004
  .ver 1:0:0:0
}
.module 'project_22-03-2023-cli.exe'
// MVID: {186D6068-12FA-4A04-B781-26725D2CB57C}
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00020003    //  ILONLY 32BITPREFERRED
// Image base: 0x0B770000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi beforefieldinit project_22_03_2023_cli.Program
       extends [mscorlib]System.Object
{
  .method private hidebysig static void  Main(string[] args) cil managed
  {
    .entrypoint
    // Code size       161 (0xa1)
    .maxstack  3
    .locals init ([0] bool con,
             [1] string s,
             [2] int32[] newArr,
             [3] int32 res,
             [4] int32 i,
             [5] bool V_5,
             [6] int32 V_6,
             [7] bool V_7,
             [8] bool V_8)
    IL_0000:  nop
    IL_0001:  ldc.i4.1
    IL_0002:  stloc.0
    IL_0003:  br         IL_0096

    IL_0008:  nop
    IL_0009:  ldstr      "Hello World"
    IL_000e:  call       void [mscorlib]System.Console::set_Title(string)
    IL_0013:  nop
    IL_0014:  ldstr      "Shiyam"
    IL_0019:  stloc.1
    IL_001a:  ldstr      "My name is ,"
    IL_001f:  ldloc.1
    IL_0020:  call       string [mscorlib]System.String::Concat(string,
                                                                string)
    IL_0025:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_002a:  nop
    IL_002b:  ldc.i4.2
    IL_002c:  newarr     [mscorlib]System.Int32
    IL_0031:  stloc.2
    IL_0032:  ldc.i4.0
    IL_0033:  stloc.s    i
    IL_0035:  br.s       IL_004d

    IL_0037:  nop
    IL_0038:  ldloc.2
    IL_0039:  ldloc.s    i
    IL_003b:  call       string [mscorlib]System.Console::ReadLine()
    IL_0040:  call       int32 [mscorlib]System.Int32::Parse(string)
    IL_0045:  stelem.i4
    IL_0046:  nop
    IL_0047:  ldloc.s    i
    IL_0049:  ldc.i4.1
    IL_004a:  add
    IL_004b:  stloc.s    i
    IL_004d:  ldloc.s    i
    IL_004f:  ldloc.2
    IL_0050:  ldlen
    IL_0051:  conv.i4
    IL_0052:  clt
    IL_0054:  stloc.s    V_5
    IL_0056:  ldloc.s    V_5
    IL_0058:  brtrue.s   IL_0037

    IL_005a:  ldc.i4.0
    IL_005b:  stloc.3
    IL_005c:  ldc.i4.0
    IL_005d:  stloc.s    V_6
    IL_005f:  br.s       IL_0070

    IL_0061:  nop
    IL_0062:  ldloc.3
    IL_0063:  ldloc.2
    IL_0064:  ldloc.s    V_6
    IL_0066:  ldelem.i4
    IL_0067:  add
    IL_0068:  stloc.3
    IL_0069:  nop
    IL_006a:  ldloc.s    V_6
    IL_006c:  ldc.i4.1
    IL_006d:  add
    IL_006e:  stloc.s    V_6
    IL_0070:  ldloc.s    V_6
    IL_0072:  ldloc.2
    IL_0073:  ldlen
    IL_0074:  conv.i4
    IL_0075:  clt
    IL_0077:  stloc.s    V_7
    IL_0079:  ldloc.s    V_7
    IL_007b:  brtrue.s   IL_0061

    IL_007d:  ldstr      "array sum ,{0}"
    IL_0082:  ldloc.3
    IL_0083:  box        [mscorlib]System.Int32
    IL_0088:  call       string [mscorlib]System.String::Format(string,
                                                                object)
    IL_008d:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_0092:  nop
    IL_0093:  ldc.i4.0
    IL_0094:  stloc.0
    IL_0095:  nop
    IL_0096:  ldloc.0
    IL_0097:  stloc.s    V_8
    IL_0099:  ldloc.s    V_8
    IL_009b:  brtrue     IL_0008

    IL_00a0:  ret
  } // end of method Program::Main

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method Program::.ctor

} // end of class project_22_03_2023_cli.Program


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
// WARNING: Created Win32 resource file E:\KANINI\Lecture6-DotNet(c#)\project_22-03-2023-cli\bin\Debug\project_22-03-2023-cli-dump.res
