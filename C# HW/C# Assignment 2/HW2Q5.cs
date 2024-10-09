namespace _02UnderstandingTypes;

public class HW2Q5
{
    public static void Main(int[] inputArray)
    {
        int left = 0, right = 0;
        int maxLength = 0;
        int letter =  -1;
        while (right < inputArray.Length)
        {
            if (inputArray[right] == inputArray[left])
            {
                
                if (maxLength < right - left + 1)
                {
                    maxLength = right - left + 1;
                    letter = inputArray[right];
                }
                right++;
            }
            else
            {
                left = right;
            }
            //Console.Write("Left: "+left+"Right: "+right+"Max: "+maxLength+"  :   "+ letter+"  end   \n");
        }
        int[] result = new int[maxLength];
        for (int i = 0; i < maxLength; i++)
        {
            result[i] = letter;
        }
        Console.WriteLine(string.Join(", ", result));
    }
}