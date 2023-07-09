internal class Program
{
    private static void Main()
    {
        string numberAsString = Console.ReadLine();
        
        int sumOfEven = GetSum(numberAsString, true);
        int sumOfOdd = GetSum(numberAsString, false);   
        
        int result = sumOfOdd * sumOfEven;
        Console.WriteLine(result);
       


    }

    static int GetSum(string numbers, bool isEven)
    {
        int sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {

            if (numbers[i]>= 48 && numbers[i] <= 57)
            {

                int currentNumber = int.Parse(numbers[i].ToString());
                if (currentNumber % 2 == 0 && isEven)
                {
                    sum += currentNumber;
                }
                else if (currentNumber % 2 != 0 && !isEven)
                {
                    sum += currentNumber;
                }
            }
        }
        return sum;
    }
}