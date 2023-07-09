int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
int thirdNumber = int.Parse(Console.ReadLine());
int sum = NumberAdd(firstNumber, secondNumber);

Console.WriteLine(NumberSubstract(sum, thirdNumber));


int NumberAdd(int firstNumber, int secondNumber)
{
   int sum = firstNumber + secondNumber;
    return sum;
}

int NumberSubstract(int sum, int thirdNumber)
{
    int result = sum - thirdNumber;
    return result;
}
