internal class Program
{
    private static void Main(string[] args)
    {
        string input = Console.ReadLine();
        Stack<string> reversed = new Stack<string>();
        for (int i = 0; i < input.Length; i++)
        {
            reversed.Push(String.Format($"{input[i]}"));
        }
        Console.WriteLine(String.Join("", reversed));
    }
}