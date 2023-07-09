namespace _02._Center_Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            

            PrintClosestPoint(x1, y1, x2, y2);
        }

        private static void PrintClosestPoint(double x1, double y1, double x2, double y2)
        {
            double lengh1 = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            double lengh2 = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));

            if (lengh1 > lengh2)
            {
                Console.WriteLine($"({x2}, {y2})");
            }
            else if (lengh1 < lengh2)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x1}, {y1})");
            }

                
        }
    }
}