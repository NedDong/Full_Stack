namespace _02UnderstandingTypes;

public class Exercise03
{
    public static void Main(string[] args)
    {
        int max = 500;
        for (byte i = 0; i < max; i++)
        {
            Console.WriteLine(i);
            if (i == 255)
            {
                Console.WriteLine("Byte is 255");
                break;
            }
        }
    }
}