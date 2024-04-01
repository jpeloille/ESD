using System.Runtime.InteropServices;

namespace ESD.Common;

//Cf page 52 de 1981_iAPX_86_88_Users_Manual.pdf
[StructLayout(LayoutKind.Explicit)]
public struct FlagsRegister
{
    [FieldOffset(0)] public bool C;
    //[FieldOffset(6)] public bool C;
    [FieldOffset(2)] public bool P;
    //[FieldOffset(4)] public bool C;
    [FieldOffset(4)] public bool A;
    //[FieldOffset(2)] public bool C;
    [FieldOffset(6)] public bool Z;
    [FieldOffset(7)] public bool S;

    [FieldOffset(0)]public UInt128 Register;
}