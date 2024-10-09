namespace _02UnderstandingTypes;

public class HW1Q6
{
    public static void Main(string[] args)
    {
        DateTime currentTime = DateTime.Now;
        int hour = currentTime.Hour;
        if (hour < 12)
        {
            Console.WriteLine("Good Morning");
        }
        if (hour >= 12 && hour < 18)
        {
            Console.WriteLine("Good Afternoon");
        }
        if (hour >= 18 && hour < 21)
        {
            Console.WriteLine("Good Evening");
        }
        if (hour >= 21)
        {
            Console.WriteLine("Good Night");
        }
    }
}