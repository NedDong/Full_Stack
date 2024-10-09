namespace _02UnderstandingTypes;

public class HW1Q5
{
    public static void Main(string[] args)
    {
        Console.Write("Enter birdthday: ");
        DateTime birthDate = DateTime.Parse(Console.ReadLine());
        DateTime today = DateTime.Today;
        int daysOld = (today - birthDate).Days;
        int daysToNextAnniversary = 10000 - (daysOld % 10000);
        DateTime nextAnniversary = today.AddDays(daysToNextAnniversary);
        Console.WriteLine($"Years Old: {daysOld}");
        Console.WriteLine($"Next 10,000-day anniversary: {nextAnniversary.ToString()}");
    }
}