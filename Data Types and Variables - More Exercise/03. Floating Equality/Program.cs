internal class Program
{
    private static void Main(string[] args)
    {
        double numberA = double.Parse(Console.ReadLine());
        double numberB = double.Parse(Console.ReadLine());
        double eps = 0.000001;

        bool isEqual = Math.Abs(numberA- numberB) < eps;

         
        Console.WriteLine(isEqual);
        

    }
}