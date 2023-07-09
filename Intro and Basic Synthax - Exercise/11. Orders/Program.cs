internal class Program
{
    private static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        decimal totalPrice = 0;

        for (int i = 1; i <= N; i++)
        {
            decimal.TryParse(Console.ReadLine(), out decimal pricePerCapsule);
            int.TryParse(Console.ReadLine(), out int daysInMonth);
            int.TryParse(Console.ReadLine(), out int capsulesCount);

            decimal orderPrice = (daysInMonth * capsulesCount) * pricePerCapsule;
            totalPrice += orderPrice;
            Console.WriteLine($"The price for the coffee is: ${orderPrice:F2}");

        }

        Console.WriteLine($"Total: ${totalPrice:F2}");



    }
}