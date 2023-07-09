internal class Program
{
    private static void Main(string[] args)
    {
        double britishPound = double.Parse(Console.ReadLine());
        double americanDollar = 1.31 * britishPound;
        Console.WriteLine($"{americanDollar:F3}");
    }
}