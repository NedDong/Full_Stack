namespace _02UnderstandingTypes;

public class HW2Q9
{
    public static bool CheckIfSymbol(char symbol)
    {
        return (symbol == ',' || symbol == ':' ||
                symbol == ';' || symbol == '=' || symbol == '(' ||
                symbol == ')' || symbol == '&' || symbol == '[' ||
                symbol == ']' || symbol == '"' || symbol == '\'' ||
                symbol == '/' || symbol == '!' ||
                symbol == '?' || symbol == ' ');
    }
    public static void Main(string inputString)
    {
        Stack<String> stack = new Stack<String>();
        int left = 0;
        int right = 0;
        int wordCount = 0;
        Dictionary<char, int> symbolIndex = new Dictionary<char, int>();
        for (int i = 0; i < inputString.Length; i++)
        {
            if (CheckIfSymbol(inputString[i]))
            {
                //Console.WriteLine(inputString.Substring(left, i - left));
                stack.Push(inputString.Substring(left, i - left));
                wordCount++;
                while (CheckIfSymbol(inputString[i]))
                {
                    i++;
                }
                left = i;
                right = i;
            }
            else
            {
                right++;
            }
        }
        List<String> result = new List<String>();
        for (int i = 0; i < inputString.Length; i++)
        {
            if (CheckIfSymbol(inputString[i]))
            {
                result.Add(stack.Pop());
                //result.Add(inputString[i].ToString());
                wordCount++;
                while (CheckIfSymbol(inputString[i]))
                {
                    result.Add(inputString[i].ToString());
                    i++;
                }
                left = i;
                right = i;
            }
            else
            {
                right++;
            }
        }
        Console.WriteLine(String.Join("",result));
    }
}