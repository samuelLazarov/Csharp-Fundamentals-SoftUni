internal class Program
{
    private static void Main(string[] args)
    {
       string country = Console.ReadLine();

        switch (country)
        {
            case "USA":
            case "England":
                Console.WriteLine("English");
                break;
            case "Spain":
            case "Argetina":
            case "Mexico":
                Console.WriteLine("Spanish");
                break ;
            default:
                Console.WriteLine("unknown");
                break;

        }
    }
}