internal class Program
{
    private static void Main(string[] args)
    {
        
        double Lenght = double.Parse(Console.ReadLine());
        double Widht = double.Parse(Console.ReadLine());
        double Height = double.Parse(Console.ReadLine());
        double Volume = (Lenght * Widht * Height) / 3;

        Console.Write("Length: ");
        Console.Write("Width: ");
        Console.Write("Height: ");
        Console.Write($"Pyramid Volume: {Volume:f2}");

    }
}