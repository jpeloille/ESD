// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices;

var regA = new Register_16Bits();

regA.LOW = 0xF0;
regA.HIGH = 0xFF;

Console.WriteLine("Hello, World!");
Console.WriteLine(regA.HIGH.ToString("X2"));
Console.WriteLine(regA.LOW.ToString("X2"));
Console.WriteLine(regA.XTEND.ToString("X2"));

Console.WriteLine("Offset added :");
UInt16 offset = 0x0200;

regA.XTEND += offset;
Console.WriteLine(regA.XTEND.ToString("X2"));



[StructLayout(LayoutKind.Explicit)]
public struct Register_16Bits 
{ 
    [FieldOffset(1)]public byte HIGH; 
    [FieldOffset(0)]public byte LOW;
    [FieldOffset(0)]public UInt16 XTEND; 
}


//bool ooo = foo.original_or_copy();