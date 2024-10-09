namespace _02UnderstandingTypes;

public class HW1Q4
{
    public static void Main(string[] args)
    {
        for (int i = 1; i < 6; i++)
        {
            for (int j = 5-i; j > 0   ; j--)
            {
                Console.Write(" ");
            }

            for (int x = 0; x < 2 * i - 1; x++)
            {
                Console.Write("*");
            }
            for (int j = 5-i; j > 0; j--)
            {
                Console.Write(" ");
            }
            Console.WriteLine("");
        }
    }
}