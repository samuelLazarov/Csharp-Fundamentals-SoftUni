internal class Program
{
    private static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());
        string word = String.Empty;

        for (int i = 1; i <= input; i++)
        {
            string currentNum = Console.ReadLine();
            if (currentNum == "0")
            {
                word += " ";
                continue;
            }
            int lenght = currentNum.Length;
            int firstDigit = int.Parse(currentNum[0].ToString());
            if (firstDigit > 7)
            {
                word += (char)(97 + (firstDigit - 2) * 3 + lenght);
            }
            else
            {
                word += (char)(97 + (firstDigit - 2) * 3 + lenght - 1);
            }

        }
        Console.WriteLine(word);
    }
}