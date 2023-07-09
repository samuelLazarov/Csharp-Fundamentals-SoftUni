using System.ComponentModel;

internal class Program
{
    static void Main()
    {
        string command = Console.ReadLine();
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        double result = 0;

        switch (command)
        {
            case "add":
               result = Add(a, b);
                break;
            case "subtract":
               result = Subtract(a, b);
                break;
            case "multiply":
               result = Multiply(a, b);
                break;
            case "divide":
               result = Divide(a, b);
                break;

        }
        Console.WriteLine(result);

    }
    private static int Add(int a, int b)
    {
        int result = a + b;
        return result;
    }

    private static int Subtract(int a, int b)
    {
        int substraction = a - b;
        return substraction;
    }

    private static int Multiply(int a, int b)
    {
        int result = a * b;
        return result;
    }

    private static double Divide(double a, double b)
    {
        double result = a / b;
        return result;
    }
}