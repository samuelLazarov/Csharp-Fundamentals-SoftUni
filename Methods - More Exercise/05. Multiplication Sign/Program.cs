using System.Xml.Serialization;

namespace _05._Multiplication_Sign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            
            int[] array = new int[3] { number1, number2, number3};


            if (true)
            {
                Console.WriteLine("negative");
            }
            else if (array.Any())
            {
                Console.WriteLine("zero");
            }

        }
    }
}