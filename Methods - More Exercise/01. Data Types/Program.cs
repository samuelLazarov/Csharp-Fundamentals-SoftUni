namespace _01._Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            var input2 = Console.ReadLine();

            switch (input1)
            {
                case "int":
                    long number = long.Parse(input2);
                    number *= 2;
                    Console.WriteLine(number);
                    break;
                case "real":
                    double number2 = double.Parse(input2);
                    number2 *= 1.5;
                    Console.WriteLine($"{number2:F2}");
                    break;
                case "string":
                    input2 = "$" + input2 + "$";
                    Console.WriteLine(input2);
                    break;
                    

            }
        }
    }
}