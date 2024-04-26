// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
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

BenchmarkRunner.Run<Test>();

[MemoryDiagnoser]
public class Test()
{
    private byte A = 0xC0;
    private byte M = 0x0;
    private bool C = true;
    private ushort result16;
    private byte result8;
    
    [Benchmark]
    public void NonBoxingAdc()
    {            ushort leftOperand = 0x0000;
        ushort rightOperand = 0x0000;

        leftOperand |= A;
        rightOperand |= M;
            
        result16 = leftOperand;
        result16 += rightOperand;
            
        if (C) result16 += 1;
        result8 = (byte)result16;
    }

    [Benchmark]
    public void BoxingAdc()
    {
        result16 = (ushort)(A + M + (C ? 1 :0));
        result8 = (byte)result16;
        
    }
}