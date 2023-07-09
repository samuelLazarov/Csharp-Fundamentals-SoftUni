internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        decimal totalSum = 0;

        for (int i = 0; i < n; i++)
        {
            decimal currentInputNumber = decimal.Parse(Console.ReadLine());
            totalSum += currentInputNumber;
        }

        Console.WriteLine(totalSum);

    }
}