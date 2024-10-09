namespace _02UnderstandingTypes;

public class HW2Q7
{
    public static void Main(int[] array)
    {
        Dictionary<int, int> countFreq = new Dictionary<int, int>();
        for (int i = 0; i < array.Length; i++)
        {
            if (countFreq.ContainsKey(array[i]))
            {
                countFreq[array[i]]++;
            }
            else
            {
                countFreq.Add(array[i], 1);
            }
        }
        int maxFrequency = countFreq.Values.Max();
        int mostFrequent = array.First(x => countFreq[x] == maxFrequency);

        Console.WriteLine(mostFrequent);
    }
}