namespace _02UnderstandingTypes;

public class HW1Q3
{
    public static void Main(string[] args)
    {
        int correctNumber = new Random().Next(3) + 1;
        Console.WriteLine("Input your Guess");
        int guessedNumber = int.Parse(Console.ReadLine());

        if (correctNumber == guessedNumber)
        {
            Console.WriteLine("Correct");
        } else if (correctNumber > guessedNumber)
        {
            Console.WriteLine("Low");
        } else if (correctNumber < guessedNumber)
        {
            Console.WriteLine("High");
        }
        else
        {
            Console.WriteLine("Our of Range");
        }
    }
}