long first = int.Parse(Console.ReadLine());
long second = int.Parse(Console.ReadLine());


Console.WriteLine("{0:F2}", (double)Factorial(first)/Factorial(second));

long Factorial(long number)
{
    if (number < 1)
    {
        return 1;
    }
    return number * Factorial(number - 1);

}