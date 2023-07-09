internal class Program
{
    private static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        while (number % 2 != 0)
        {
            Console.WriteLine($"Please write an even number.");
            number = int.Parse(Console.ReadLine());        
          if (number % 2 == 0)
          {           
            break;
          }          
        }
        Console.WriteLine($"The number is: {Math.Abs(number)}");
    }
}