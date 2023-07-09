internal class Program
{
    private static void Main(string[] args)
    {

        char inputSymbol = char.Parse(Console.ReadLine());

        if (char.IsUpper(inputSymbol))
        {
            Console.WriteLine("upper-case");
        }
        else
        {
            Console.WriteLine("lower-case");
        }

    }
}