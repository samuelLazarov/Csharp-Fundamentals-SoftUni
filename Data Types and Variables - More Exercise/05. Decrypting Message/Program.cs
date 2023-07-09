internal class Program
{
    private static void Main(string[] args)
    {
        int key = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        string decryptedMessage = String.Empty;


        for (int i = 0; i < n; i++)
        {
            char input = char.Parse(Console.ReadLine());
            int outputInt = (int)(input) + key;
            char outputChar = (char)outputInt;
            decryptedMessage += outputChar.ToString();

        }
        Console.WriteLine(decryptedMessage);

    }
}