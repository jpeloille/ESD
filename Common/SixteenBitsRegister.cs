using System.Runtime.InteropServices;

namespace ESD.Common;

[StructLayout(LayoutKind.Explicit)]
public struct SixteenBitsRegister
{
    [FieldOffset(1)]public byte HIGH; 
    [FieldOffset(0)]public byte LOW;
    [FieldOffset(0)]public UInt16 XTEND; 
}
