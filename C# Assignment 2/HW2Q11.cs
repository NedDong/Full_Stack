namespace _02UnderstandingTypes;

public class HW2Q11
{
    public static void Main(string inputAddress)
    {
        String[] splitedProtocol = inputAddress.Split("://");
        //Console.WriteLine(String.Join("\n", splitedProtocol));
        String address;
        if (splitedProtocol.Length > 1)
        {
            Console.WriteLine($"[protocol] = \"{splitedProtocol[0]}\"" );
            address = splitedProtocol[1];
        }else{ Console.WriteLine($"[protocol] = \"\"" );address = splitedProtocol[0]; }
        String[] splitedResources = address.Split("/");
        Console.WriteLine($"[server] = \"{splitedResources[0]}\"" );
        if (splitedResources.Length > 1)
        {
            Console.WriteLine($"[resource] = \"{splitedResources[1]}\"" );
        }else{Console.WriteLine($"[resource] = \"\"" );}
    }
}