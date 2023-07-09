using System.Threading;

string[] rooms = Console.ReadLine()
    .Split('|', StringSplitOptions.RemoveEmptyEntries)
    .ToArray();

int health = 100;
int bitCoins = 0;
bool hasDied = false;
string monster = string.Empty;
int bestRoom=0;
for (int i = 0; i < rooms.Length; i++)
{
    string[] command = rooms[i].Split();
    if (command[0] == "potion")
    {
        int potionAmount = int.Parse(command[1]);
        health += potionAmount;
        int healthRestored = potionAmount;
        if (health > 100)
        {
            healthRestored = 100 + potionAmount - health;
            health = 100;
        }
        Console.WriteLine($"You healed for {healthRestored} hp.");
        Console.WriteLine($"Current health: {health} hp.");
    }
    else if (command[0] == "chest")
    {
        bitCoins += int.Parse(command[1]);
        Console.WriteLine($"You found {command[1]} bitcoins.");
    }
    else
    {
        monster = command[0];
        int monsterPower = int.Parse(command[1]);
        health -= monsterPower;
        if (health > 0)
        {
            Console.WriteLine($"You slayed {monster}.");
        }
        else
        {
            bestRoom = i+1;
            health = 0;
            hasDied = true;
            break;
        }
    }
}

if (!hasDied)
{
    Console.WriteLine("You've made it!");
    Console.WriteLine($"Bitcoins: {bitCoins}");
    Console.WriteLine($"Health: {health}");
}
else
{
    Console.WriteLine($"You died! Killed by {monster}.");
    Console.WriteLine($"Best room: {bestRoom}");
}
