// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices;
using ESD.Common;

var regA = new SixteenBitsRegister();

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

var flags = new FlagsRegister();
flags.Register = 0x00;
Console.WriteLine(flags.Register.ToString("X2"));

flags.C = true;
Console.WriteLine(flags.Register.ToString("X2"));