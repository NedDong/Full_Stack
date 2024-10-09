namespace _02UnderstandingTypes;

public class HW2Q4
{
    public static void Main(int[] arrayToRotate, int k)
    {
        int[] sum = new int[arrayToRotate.Length];
        for (int i = 0; i < arrayToRotate.Length; i++)
        {
            sum[i] = 0;
        }
        for (int i = 0; i < k; i++)
        {
            int temp = arrayToRotate[arrayToRotate.Length - 1];
            for (int j = arrayToRotate.Length-1; j > 0; j--)
            {
                arrayToRotate[j] = arrayToRotate[j-1];
            }
            arrayToRotate[0] = temp;
            Console.WriteLine("Rotated "+(i+1)+" Time: "+String.Join(", ",arrayToRotate));
            for (int j = 0; j < arrayToRotate.Length; j++)
            {
                sum[j] += arrayToRotate[j];
            }
        }
        Console.WriteLine("SUM: "+String.Join(", ",sum));
    }
}