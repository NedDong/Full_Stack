using System.Runtime.InteropServices.JavaScript;

namespace _02UnderstandingTypes;

public class HW2Q10
{
    public static void Main(string inputString)
    {
        List<String> tokens = new List<String>();
        int left = 0;
        int right = 0;
        List<String> result = new List<String>();
        for (var i = 0; i < inputString.Length; i++)
        {
            if(char.IsLetter(inputString[i]))
            {
            }
            else
            {
                tokens.Add(inputString.Substring(left, i - left));
                while(!char.IsLetter(inputString[i]))
                {
                    i++;
                }
                left = i;
            }
        }

        foreach (String token in tokens)
        {   
            
            if (String.Join("",token.Reverse()) == token)
            {
                //Console.WriteLine(token);
                result.Add(token);
            }
        }
        Console.WriteLine(String.Join(", ",result));
    }
}