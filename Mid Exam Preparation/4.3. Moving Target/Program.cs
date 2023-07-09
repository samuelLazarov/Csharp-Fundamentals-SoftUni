List<int> targets = Console.ReadLine()!
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

while (true)
{
    string input = Console.ReadLine()!;
    if (input == "End")
    {
        break;
    }
    string[] command = input.Split();
    string commandType = command[0];
    int index = int.Parse(command[1]);
    if (commandType == "Shoot")
    {
        if (index < 0 || index >= targets.Count)
        {
            continue;
        }
        int power = int.Parse(command[2]);
        targets[index] -= power;
        if (targets[index] <= 0)
        {
            targets.RemoveAt(index);
        }
    }
    else if (commandType == "Add")
    {
        if (index < 0 || index >= targets.Count)
        {
            Console.WriteLine("Invalid placement!");
            continue;
        }
        int value = int.Parse(command[2]);
        targets.Insert(index, value);
    }
    else if (commandType == "Strike")
    {
        int radius = int.Parse(command[2]);
        int start = index - radius;
        int end = index + radius;
        if (start < 0 || end >= targets.Count)
        {
            Console.WriteLine("Strike missed!");
            continue;
        }
        targets.RemoveRange(start, 2 * radius + 1);


    }
}

Console.WriteLine(string.Join('|', targets));

