internal class Program
{
    private static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        PrintNumberSign(number);
    }

    private static void PrintNumberSign(int randomNumber)
    {
        if (randomNumber > 0)
        {
            Console.WriteLine($"The number {randomNumber} is positive. ");
        }
        else if (randomNumber < 0)
        {
            Console.WriteLine($"The number {randomNumber} is negative. ");
        }
        else
        {
            Console.WriteLine($"The number {randomNumber} is zero. ");
        }
    }


}