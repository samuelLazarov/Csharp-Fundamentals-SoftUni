using System;

int[] pirateShipSections = Console.ReadLine()
    .Split('>', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int[] warShipSections = Console.ReadLine()
    .Split('>', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
int maxHealth = int.Parse(Console.ReadLine());

string input = string.Empty;

while (true)
{
   input = Console.ReadLine();
    if (input == "Retire")
    {
        break;
    }
    string[] command = input.Split();
    string commandType = command[0];
    
    if (commandType == "Fire")
    {
        int index = int.Parse(command[1]);
        int damage = int.Parse(command[2]);

        if (index < 0 || index >= warShipSections.Length)
        {
            continue;
        }
        warShipSections[index] -= damage;
        if (warShipSections[index] <= 0)
        {
            Console.WriteLine("You won! The enemy ship has sunken.");
            Environment.Exit(0);
        }
    }
    else if (commandType == "Defend")
    {
        int start = int.Parse(command[1]);
        int end = int.Parse(command[2]);
        int damage = int.Parse(command[3]);
        if (start < 0 || end >= pirateShipSections.Length)
        {
            continue;
        }
        for (int i = start; i <= end; i++)
        {
            pirateShipSections[i] -= damage;
            if (pirateShipSections[i] <= 0)
            {
                Console.WriteLine("You lost! The pirate ship has sunken.");
                Environment.Exit(0);
            }
        }
    }
    else if (commandType == "Repair")
    {
        int index = int.Parse(command[1]);
        int health = int.Parse(command[2]);
        if (index < 0 || index >= pirateShipSections.Length)
        {
            continue;
        }
        pirateShipSections[index] += health;
        if (pirateShipSections[index] > maxHealth)
        {
            pirateShipSections[index] = maxHealth;
        }

    }
    else if (commandType == "Status")
    {
        int sectionsForRepair = 0;
        double needOfRepair = 0.2 * maxHealth;
        for (int i = 0; i < pirateShipSections.Length; i++)
        {
            if (pirateShipSections[i] < needOfRepair)
            {
                sectionsForRepair++;
            }
        }
        Console.WriteLine($"{sectionsForRepair} sections need repair.");
    }
}

int pirateShipSum = 0;
int warShipSum = 0;
for (int i = 0; i < pirateShipSections.Length; i++)
{
    pirateShipSum += pirateShipSections[i];
}

for (int i = 0; i < warShipSections.Length; i++)
{
    warShipSum += warShipSections[i];
}

Console.WriteLine($"Pirate ship status: {pirateShipSum}");
Console.WriteLine($"Warship status: {warShipSum}");

