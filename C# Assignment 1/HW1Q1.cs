namespace _02UnderstandingTypes;
public static class HW1Q1
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"SByte Size,MAX,MIN : {sizeof(sbyte)} , {SByte.MaxValue} , {SByte.MinValue}");
        Console.WriteLine($"SByte Size,MAX,MIN : {sizeof(byte)} , {byte.MaxValue} , {byte.MinValue}");
        Console.WriteLine($"SByte Size,MAX,MIN : {sizeof(short)} , {short.MaxValue} , {short.MinValue}");
        Console.WriteLine($"SByte Size,MAX,MIN : {sizeof(ushort)} , {ushort.MaxValue} , {ushort.MinValue}");
        Console.WriteLine($"SByte Size,MAX,MIN : {sizeof(int)} , {int.MaxValue} , {int.MinValue}");
        Console.WriteLine($"SByte Size,MAX,MIN : {sizeof(uint)} , {uint.MaxValue} , {uint.MinValue}");
        Console.WriteLine($"SByte Size,MAX,MIN : {sizeof(long)} , {long.MaxValue} , {long.MinValue}");
        Console.WriteLine($"SByte Size,MAX,MIN : {sizeof(ulong)} , {ulong.MaxValue} , {ulong.MinValue}");
        Console.WriteLine($"SByte Size,MAX,MIN : {sizeof(float)} , {float.MaxValue} , {float.MinValue}");
        Console.WriteLine($"SByte Size,MAX,MIN : {sizeof(double)} , {double.MaxValue} , {double.MinValue}");
        Console.WriteLine($"SByte Size,MAX,MIN : {sizeof(decimal)} , {decimal.MaxValue} , {decimal.MinValue}");
    }
    
}