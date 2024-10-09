namespace _02UnderstandingTypes;

public class HW1Q2
{
    public static void Main(int century)
    {
        int centuryToYears = 100 * century;
        double yearsToDays = 365.24 * centuryToYears;
        double daysToHours = yearsToDays * 24;
        double hoursToMinutes = daysToHours * 60;
        double minutesToSeconds = hoursToMinutes * 60;
        double secondsToMileseconds = minutesToSeconds * 1000;
        double milesecondsToMicroseconds = secondsToMileseconds * 1000;
        double microsecondsToNanoseconds = milesecondsToMicroseconds * 1000;
        Console.WriteLine($"{century} centuries = {centuryToYears} years = {(long)yearsToDays} days = {(long)daysToHours} hours = {(long)hoursToMinutes} minutes = {(long)minutesToSeconds} seconds = {(long)secondsToMileseconds} milliseconds = {(long)milesecondsToMicroseconds} microseconds = {(long)microsecondsToNanoseconds} nanoseconds");
    }
}