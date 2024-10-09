using System.Text;

namespace _02UnderstandingTypes;

public class HW2Q8
{
    public static void Main(string inputString)
    {
        Console.WriteLine(String.Concat(inputString.ToCharArray().Reverse()));
        StringBuilder result = new StringBuilder();
        for (int i = inputString.Length - 1; i >= 0; i--)
        {
            result.Append(inputString[i]);
        }
        Console.WriteLine(result.ToString());
    }
}