internal class Program
{
    private static void Main(string[] args)
    {
        //Read n numbers and print them in reverse order, separated by a single space.

        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n]; //prazen masiv
        int[] numbers2 = new int[4];
        for (int i = 0; i < numbers.Length; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());
            numbers[i] = currentNumber;
        }

        for (int i = 0; i < numbers.Length / 2; i++)
        {
            int firstNumber = numbers[i];
            int lastNumber = numbers[numbers.Length - 1 - i];

            numbers[i] = lastNumber;
            numbers[numbers.Length - 1 - i] = firstNumber;
        }


    }
}