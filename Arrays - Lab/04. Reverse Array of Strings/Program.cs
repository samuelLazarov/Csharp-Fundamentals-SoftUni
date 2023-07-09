internal class Program
{
    private static void Main(string[] args)
    {
        string[] names = Console.ReadLine()
            .Split()
            .ToArray();

        
        names = names.Reverse().ToArray();
        //Array.Sort(names);
        Console.WriteLine(string.Join(" ", names));
    }
}