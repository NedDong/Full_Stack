namespace C_HW03;

public class HW3Q2
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Fibonacci(8));
    }

    public static int Fibonacci(int n)
    {
        if (n == 0 || n == 1)
        {
            return n;
        }
        return Fibonacci(n - 1) + Fibonacci(n - 2);
        
    }
    
}