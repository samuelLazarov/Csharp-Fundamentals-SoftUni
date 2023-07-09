using System.Reflection.Metadata.Ecma335;

int peopleInLine = int.Parse(Console.ReadLine());

int[] wagons = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
bool hasSpots = false;
for (int i = 0; i < wagons.Length; i++)
{
    if (wagons[i] >= 0 && wagons[i] < 4)
    {
        int emptySpot = 4 - wagons[i];

        if (peopleInLine >= emptySpot)
        {
            wagons[i] += emptySpot;
            peopleInLine -= emptySpot;
        }
        else
        {
            wagons[i] += peopleInLine;
            peopleInLine -= peopleInLine;
            hasSpots = true;
        }
    }
}

if (hasSpots)
{
    Console.WriteLine("The lift has empty spots!");
    Console.WriteLine($"{string.Join(' ', wagons)}");
}
else if (!hasSpots && peopleInLine > 0)
{
    Console.WriteLine($"There isn't enough space! {peopleInLine} people in a queue!");
    Console.WriteLine($"{string.Join(' ', wagons)}");
}
else
{
    Console.WriteLine($"{string.Join(' ', wagons)}");
}

