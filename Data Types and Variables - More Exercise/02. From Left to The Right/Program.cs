internal class Program
{
    public static void Main(string[] args)
    {
        int inputNumber = int.Parse(Console.ReadLine());
        string input = string.Empty;
        

        for (int i = 0; i < inputNumber; i++)
        {
            input = Console.ReadLine();
            string[] numbers = input.Split(" ");
            long firstNumber = long.Parse(numbers[0]);
            long secondNumber = long.Parse(numbers[1]);

            if (firstNumber > secondNumber)
            {
                Console.WriteLine(SumTheDigitsOfNumber(firstNumber));
            }    
            else
            {
                Console.WriteLine(SumTheDigitsOfNumber(secondNumber));
            }
        }
    }
    private static int SumTheDigitsOfNumber(long number)
    {
        int sum = 0;

        while (number != 0)
        {
            sum += (int)(number % 10);
            number /= 10;
        }
        return Math.Abs(sum);

    }
}