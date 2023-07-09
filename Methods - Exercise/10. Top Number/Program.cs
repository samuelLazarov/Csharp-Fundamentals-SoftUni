using System.Reflection.Metadata.Ecma335;

int number = int.Parse(Console.ReadLine()!);

PrintTopNumbers(number);

void PrintTopNumbers(int number)
{
    for (int i = 1; i <= number; i++)
    {
        if (HasOddDigit(i) && IsDigitsSumDivisibleBy8(i))
        {
            Console.WriteLine(i);
        }
    }
}

bool HasOddDigit(int number)
{
    while (number > 0)
    {
        if (number % 2 == 1)
        {
            return true;
        }
        
        number /= 10;
    }
    return false;
}

bool IsDigitsSumDivisibleBy8(int number)
{
    int digitSum = 0;
    
    
    while (number > 0)
    {
        digitSum += number % 10;
        number /= 10;

    }
    
    if (digitSum % 8 == 0)
    {
        return true;
    }
       
    return false;


}

