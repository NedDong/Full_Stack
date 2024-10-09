using System.Text;

namespace _02UnderstandingTypes;

public class HW2Q2
{
    public static void Main(string[] args)
    {
        String input;
        List<string> list = new List<string>();
        while (true)
        {
            Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
            input = Console.ReadLine();
            switch (input[0])
            {
                case '+':
                    list.Add(input.ToString().Substring(1, input.Length - 1));
                    break;
                case '-':
                    if (input[1] == '-')
                    {
                        list.Clear();
                    }
                    else
                    {
                        list.Remove(input.ToString().Substring(1, input.Length - 1));
                    }
                    break;
            }
            
            Console.WriteLine(String.Join("\n", list));
                    
        }
    }
}