int[] targets = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
int targetsShotCounter = 0;

while (true)
{
    string input = Console.ReadLine()!;
    if (input == "End")
    {
        break;
    }
    int index = int.Parse(input);
    if (index < 0 || index > targets.Length-1 || targets[index] == -1)
    {
        continue;
    }
    int targetValue = targets[index];
    targetsShotCounter++;
    targets[index] = -1;
    for (int i = 0; i < targets.Length; i++)
    {
        if (targets[i] == -1)
        {
            continue;
        }
        if (targets[i] > targetValue)
        {
            targets[i] -= targetValue;
        }
        else if (targets[i] <= targetValue)
        {
            targets[i] += targetValue;
        }
    }
}

Console.WriteLine($"Shot targets: {targetsShotCounter} -> {string.Join(" ", targets)}");

