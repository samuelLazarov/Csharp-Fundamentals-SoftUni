internal class Program
{
    private static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());
        char input = default(char);
        int sum = 0;
        for (int i = 1; i <= count; i++)
        {
            input = char.Parse(Console.ReadLine());
            sum += input;
        }

        Console.WriteLine($"The sum equals: {sum}");
    }
}