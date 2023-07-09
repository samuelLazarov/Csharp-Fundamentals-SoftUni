internal class Program
{
    private static void Main(string[] args)
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());

        double topNumber = Math.Max(Math.Max(firstNumber,secondNumber),thirdNumber);
        double bottomNumber = Math.Min(Math.Min(firstNumber, secondNumber), thirdNumber);
        double middleNumber = (firstNumber + secondNumber + thirdNumber) - (topNumber + bottomNumber);


        Console.WriteLine(topNumber);
        Console.WriteLine(middleNumber);
        Console.WriteLine(bottomNumber);
           
        
        

    }
}