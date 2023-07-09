internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            PrintNumbers(i);
        }

        for (int i = n - 1; i >= 1; i--)
        {
            PrintNumbers(i);
        }
    }

    static void PrintNumbers(int end)
    {
        for (int i = 1; i <= end; i++)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine();
    }
}