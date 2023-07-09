internal class Program
{
    private static void Main(string[] args)
    {
        
        int fibonacciLine = int.Parse(Console.ReadLine());
        int[] array = new int[] { 1, 1 };
        int sum = 0;
        if (fibonacciLine <= 1)
        {
            Console.WriteLine("1");
            return;
        }
        else if (fibonacciLine <= 2)
        {
            Console.WriteLine("1");
            return;
        }
        for (int i = 2; i < fibonacciLine; i++)
        {
            sum = array[0] + array[1];
            int[] newArray = new int[] { array[1], sum };
            array = newArray;
        }
        Console.WriteLine(sum);

    }
}