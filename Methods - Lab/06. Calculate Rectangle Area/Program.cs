internal class Program
{
    private static void Main(string[] args)
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        
        double area = GetArea(width, height);

        Console.WriteLine(area);
    }

    private static double GetArea(double width, double height)
    {
        double area = width * height;
        return area;
    }
}