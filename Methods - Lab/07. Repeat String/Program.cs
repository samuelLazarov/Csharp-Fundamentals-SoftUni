using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        string inputStr = Console.ReadLine();
        int count = int.Parse(Console.ReadLine());

        string result = RepeatString(inputStr, count);
        Console.WriteLine(result);
    }

    private static string RepeatString(string inputStr, int count)
    {
        string result = string.Empty;
        
        for (int i = 0; i < count; i++)
        {
            result += inputStr;
            
        }
        return result;
    }
}