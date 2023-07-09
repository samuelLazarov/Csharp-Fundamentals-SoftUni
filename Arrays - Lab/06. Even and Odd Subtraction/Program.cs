internal class Program
{
    private static void Main(string[] args)
    {
        int[] inputNumbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        int evenSum = 0;
        int oddSum = 0;

        foreach (var currentNumber in inputNumbers)
        {
            if (currentNumber % 2 == 0)
            {
                evenSum += currentNumber;
            }
            else
            {
                oddSum += currentNumber;
            }
        }

        Console.WriteLine(evenSum - oddSum);
    }
}