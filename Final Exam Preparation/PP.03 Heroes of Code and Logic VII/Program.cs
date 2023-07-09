using System.ComponentModel.DataAnnotations;

int numberOfHeroes = int.Parse(Console.ReadLine());

Dictionary<string, Hero> heroes = new Dictionary<string, Hero>();


for (int i = 0; i < numberOfHeroes; i++)
{
    string[] heroInfo = Console.ReadLine().Split();
    string name = heroInfo.First();
    int hitPoints = int.Parse(heroInfo[1]);
    int manaPoints = int.Parse(heroInfo[2]);

    heroes[name] = new Hero(name, hitPoints, manaPoints);
}

string input = Console.ReadLine();

while (input != "End")
{
    string[] tokens = input.Split(" - ", StringSplitOptions.RemoveEmptyEntries);

    string action = tokens.First();
    string heroName = tokens[1];
    if (action == "CastSpell")
    {
        
        int mpNeeded = int.Parse(tokens[2]);
        string spellName = tokens[3];
        if (heroes.ContainsKey(heroName))
        {
            if (heroes[heroName].ManaPoints >= mpNeeded)
            {
                heroes[heroName].ManaPoints -= mpNeeded;
                Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroes[heroName].ManaPoints} MP!");
            }
            else
            {
                Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
            }
        }
    }

    else if (action == "TakeDamage")
    {
        int damage = int.Parse(tokens[2]);
        string attacker = tokens[3];

        if (heroes.ContainsKey(heroName))
        {
            heroes[heroName].HitPoints -= damage;

            if (heroes[heroName].HitPoints <= 0)
            {
                Console.WriteLine($"{heroName} has been killed by {attacker}!");
                heroes.Remove(heroName);
            }
            else
            {
                Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroes[heroName].HitPoints} HP left!");
            }
        }
    }

    else if (action == "Recharge")
    {
        int amount = int.Parse(tokens[2]);
        if (heroes.ContainsKey(heroName))
        {
            int actualAmount = 0;
            if (heroes[heroName].ManaPoints + amount > 200)
            {
                actualAmount = 200 - heroes[heroName].ManaPoints;
            }
            else
            {
                actualAmount = amount;
            }
            heroes[heroName].ManaPoints += actualAmount;
            Console.WriteLine($"{heroName} recharged for {actualAmount} MP!");
            
        }
    }

    else if (action == "Heal")
    {
        int amount = int.Parse(tokens[2]);

        if (heroes.ContainsKey(heroName))
        {
            int actualAmount = 0;
            
            if (heroes[heroName].HitPoints + amount > 100)
            {
                 actualAmount = 100 - heroes[heroName].HitPoints;
            }
            else
            {
                actualAmount = amount;
            }
            Console.WriteLine($"{heroName} healed for {actualAmount} HP!");
            heroes[heroName].HitPoints += actualAmount;
        }
    }

    input = Console.ReadLine();
}

foreach (var hero in heroes)
{
    Console.WriteLine($"{hero.Key}");
    Console.WriteLine($"  HP: {hero.Value.HitPoints}");
    Console.WriteLine($"  MP: {hero.Value.ManaPoints}");
}


class Hero
{
  

    public string Name { get; set; }
    [Range(0,100)]
    public int HitPoints { get; set; }
    [Range (0,200)]
    public int ManaPoints { get; set; }

    public Hero(string name, int hp, int mp)
    {
        Name = name;
        HitPoints = hp;
        ManaPoints = mp;
    }
}

