namespace C_HW03;

public class HW3Q1
{
    public static int[] GenerateNumbers(int n = 10)
    {
        int[] result = new int[n];
        for (int i = 1; i <= n; i++)
        {
            result[i-1] = i;
        }

        return result;
    }

    public static void Reverse(ref int[] numbers)
    {
        numbers = numbers.Reverse().ToArray();
    }

    public static void PrintNumbers(int[] numbers)
    {
        foreach (int number in numbers)
        {
            if (number != 1)
            {
                Console.Write(number + ", ");
            }else{Console.Write(number);}
            
        }
        Console.WriteLine("\n");
        Console.WriteLine(string.Join(", ", numbers));
    }
    
    public static void Main(string[] args)
    {
        int[] numbers = GenerateNumbers(10);
        Reverse(ref numbers);
        PrintNumbers(numbers);
    }
}