using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        string product = Console.ReadLine();
        int count = int.Parse(Console.ReadLine());

        decimal totalPrice = TotalPrice(product, count);
        Console.WriteLine($"{totalPrice:f2}");
    }

    private static decimal TotalPrice(string product, int count)
    {
        decimal totalPrice = 0;
        switch (product)
        {
            case "coffee":
                totalPrice = count * 1.50m;
                break;
            case "water":
                totalPrice = count * 1.00m;
                break;
            case "coke":
                totalPrice = count * 1.40m;
                break;
            case "snacks":
                totalPrice = count * 2.00m;
                break;

        }
        return totalPrice;
    }
}