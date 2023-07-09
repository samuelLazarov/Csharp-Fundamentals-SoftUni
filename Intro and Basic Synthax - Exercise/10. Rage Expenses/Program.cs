internal class Program
{
    private static void Main(string[] args)
    {
        int lostGamesCount = int.Parse(Console.ReadLine());

        decimal.TryParse(Console.ReadLine(), out decimal headsetPrice);
        decimal.TryParse(Console.ReadLine(), out decimal mousePrice);
        decimal.TryParse(Console.ReadLine(), out decimal keyboardPrice);
        decimal.TryParse(Console.ReadLine(), out decimal displayPrice);

        int headsetCount = 0;
        int mouseCount = 0;
        int keyboardCount = 0;
        int displayCount = 0;

        for (int i = 1; i <= lostGamesCount; i++)
        {
            if (i % 2 == 0)
            {
                headsetCount++;
            }
            if (i % 3 == 0)
            {
                mouseCount++;
            }
            if (i % 6 == 0)
            {
                keyboardCount++;
            }
            if (i % 12 == 0)
            {
                displayCount++;
            }

        }

        decimal expenses = headsetPrice*headsetCount + mousePrice*mouseCount+ keyboardPrice*keyboardCount + displayPrice*displayCount;
        Console.WriteLine($"Rage expenses: {expenses:F2} lv.");



    }
}