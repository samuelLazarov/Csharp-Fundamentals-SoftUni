using System.Numerics;

namespace _04._Tribonacci_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            PrintTribonacciSequence(num);
            
            
        }

        private static void PrintTribonacciSequence(int num)
        {
            BigInteger[] array = new BigInteger[num];
            switch (num)
            {
                case 1:
                    array[0] = 1;
                    break;
                case 2:
                    array[0] = 1;
                    array[1] = 1;
                    break;
                case 3:
                    array[0] = 1;
                    array[1] = 1;
                    array[2] = 2;
                    break;
                    default:
                    array[0] = array[1] = 1;
                    array[2] = 2;
                    for (int i = 3; i < num; i++)
                    {
                        array[i] = array[i - 1] + array[i - 2] + array[i - 3];
                    }
                    break;

            }
            
            
            Console.WriteLine(String.Join(" ", array));
        }
    }
}