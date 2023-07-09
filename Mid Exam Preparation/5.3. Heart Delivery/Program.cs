using System.Globalization;

int[] neighbourhood = Console.ReadLine()
    .Split('@', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
int currentIndex = 0;
int houseCount = 0;
//bool[] hasValentine = new bool[neighbourhood.Length];
while (true)
{
    string input = Console.ReadLine();
    if (input == "Love!")
    {
        break;
    }
    string[] command = input.Split();
    string commandType = command[0];
    int jumpLenght = int.Parse(command[1]);
    currentIndex += jumpLenght;
    
    if (currentIndex >= neighbourhood.Length)
    {
        currentIndex = 0;
    }
    if (neighbourhood[currentIndex] > 0 /*&& !hasValentine[currentIndex]*/)
    {
        neighbourhood[currentIndex] -= 2;
        if (neighbourhood[currentIndex] == 0)
        {
            Console.WriteLine($"Place {currentIndex} has Valentine's day.");
            houseCount++;
            //hasValentine[currentIndex] = true;
        }
    }
    else
    {
        Console.WriteLine($"Place {currentIndex} already had Valentine's day.");
    }
}

Console.WriteLine($"Cupid's last position was {currentIndex}.");

if (houseCount - neighbourhood.Length == 0)
{
    Console.WriteLine($"Mission was successful.");
}
else
{
    Console.WriteLine($"Cupid has failed {neighbourhood.Length-houseCount} places.");
}

