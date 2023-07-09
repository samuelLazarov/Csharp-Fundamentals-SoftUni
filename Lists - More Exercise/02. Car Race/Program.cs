List<int> numbers = Console.ReadLine()!
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

double leftCarTime = 0.00;
double rightCarTime = 0.00;

int finishLine = numbers.Count / 2;

for (int i = 0; i < finishLine; i++)
{
    leftCarTime += numbers[i];
    if (numbers[i] == 0)
    {
        leftCarTime *= 0.8;
    }
}

for (int i = numbers.Count-1; i > finishLine; i--)
{
    rightCarTime += numbers[i];
    if (numbers[i] == 0)
    {
        rightCarTime *= 0.8;
    }
}

if (leftCarTime < rightCarTime)
{
    Console.WriteLine($"The winner is left with total time: {leftCarTime}");
}
else
{
    Console.WriteLine($"The winner is right with total time: {rightCarTime}");
}
