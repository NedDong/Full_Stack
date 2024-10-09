namespace _02UnderstandingTypes;

public class HW2Q3
{
    public static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;
        for (int i = 3; i * i <= number; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }
    static int[] FindPrimesInRange(int startNum, int endNum)
    {
        List<int> primes = new List<int>();
        for (int i = startNum; i <= endNum; i++)
        {
            if (IsPrime(i))
            {
                primes.Add(i);
            }
        }
        int[] result = primes.ToArray();
        return result;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine(String.Join(", ",FindPrimesInRange(100, 200)));
    }
}