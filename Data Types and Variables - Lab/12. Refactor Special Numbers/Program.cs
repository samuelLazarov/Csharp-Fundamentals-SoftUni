internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        int currentNumber = 0;
        bool trueOrFalse = false;
        for (int i = 1; i <= n; i++)
        {
            currentNumber = i;
            while (i > 0)
            {
                sum += i % 10;
                i = i / 10;
            }
            trueOrFalse = (sum == 5) || (sum == 7) || (sum == 11);
            Console.WriteLine("{0} -> {1}", currentNumber, trueOrFalse);
            sum = 0;
            i = currentNumber;
        }

    }
}