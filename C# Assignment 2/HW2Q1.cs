namespace _02UnderstandingTypes;

public class HW2Q1
{
    public static void Main(string[] args)
    {
        int[] firstArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        int[] secondArray = new int[firstArray.Length];

        for (int i = 0; i < firstArray.Length; i++)
        {
            secondArray[i] = firstArray[i];
        }
        Console.WriteLine("First Array: " + string.Join(", ", firstArray));
        Console.WriteLine("Second Array: " + string.Join(", ", secondArray));
    }
}