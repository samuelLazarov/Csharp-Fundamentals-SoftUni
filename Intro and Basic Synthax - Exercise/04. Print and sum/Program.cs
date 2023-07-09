internal class Program
{
    private static void Main(string[] args)
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());

        var sequence = Enumerable.Range(start, end - start + 1);
                
        Console.WriteLine(string.Join(' ', sequence));
        Console.WriteLine();
        Console.WriteLine($"Sum: {sequence.Sum()}");
    }
}