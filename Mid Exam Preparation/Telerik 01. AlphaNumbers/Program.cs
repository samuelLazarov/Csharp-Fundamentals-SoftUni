using System.Linq;

int number = 0;

List<int> alphaNumbers = new List<int>();
for (int i = 0; i < 7; i++)
{
    number = int.Parse(Console.ReadLine());
    bool isAlpha = false;
    int currentNumber = number;
    List<int> listOfNumbers = new List<int>();
    
    while (currentNumber > 0)
    {
        listOfNumbers.Add(currentNumber % 10);
        currentNumber /= 10;
    }
       
    int sumOfDigits = listOfNumbers.Sum();
    int smallNum = listOfNumbers.Min();
    int biggestNum = listOfNumbers.Max();
    int maxDiff = biggestNum - smallNum;

    if (sumOfDigits % 10 < maxDiff)
    {
        isAlpha = true;
    }
    if (isAlpha)
    {
        alphaNumbers.Add(number);
    }
}

for (int i = 0; i < alphaNumbers.Count; i++)
{
    Console.WriteLine(alphaNumbers[i]);
}


