
Dictionary<string, Animal> animalsList = new Dictionary<string, Animal>();
Dictionary<string, int> hungryAnimals = new Dictionary<string, int>();

string input = Console.ReadLine();

while (input != "EndDay")
{
    string[] tokens = input.Split(": ", StringSplitOptions.RemoveEmptyEntries);
    string command = tokens[0];
    string[] animalInfo = tokens[1].Split('-', StringSplitOptions.RemoveEmptyEntries);
    if (command == "Add")
    {
        string animalName = animalInfo[0];
        int neededFood = int.Parse(animalInfo[1]);
        string animalPlace = animalInfo[2];

        Animal animal = new Animal (animalName, neededFood, animalPlace);

        if (!animalsList.ContainsKey(animalName))
        {
            animalsList.Add(animalName, animal);
            if (!hungryAnimals.ContainsKey(animalPlace))
            {
                hungryAnimals.Add(animalPlace, 1);
            }
            else
            {
                hungryAnimals[animalPlace]++;
            }
            
            
        }
        else
        {
            animalsList[animalName].NeededFood += neededFood;
        }
    }
    else if (command == "Feed")
    {
        string animalName = animalInfo[0];
        int foodAmount = int.Parse(animalInfo[1]);
        
        if (animalsList.ContainsKey(animalName))
        {
            animalsList[animalName].NeededFood -= foodAmount;
            
            if (animalsList[animalName].NeededFood <= 0)
            {
                Console.WriteLine($"{animalsList[animalName].Name} was successfully fed");
                string animalPlace = animalsList[animalName].Area;
                animalsList.Remove(animalName);
                hungryAnimals[animalPlace]--;
                if (hungryAnimals[animalPlace] <= 0)
                {
                    hungryAnimals.Remove(animalPlace);
                }
            }
        }
    }

    input = Console.ReadLine();
}

Console.WriteLine("Animals:");
foreach (var animal in animalsList)
{
    Console.WriteLine($" {animal.Key} -> {animal.Value.NeededFood}g");
}
Console.WriteLine("Areas with hungry animals:");
foreach (var hungryAnimal in hungryAnimals)
{
    Console.WriteLine($" {hungryAnimal.Key}: {hungryAnimal.Value}");
}

class Animal
{
    public string Name { get; set; }
    public int NeededFood { get; set; }
    public string Area { get; set; }
    public Animal(string name, int neededFood, string area)
    {
        Name = name;
        NeededFood = neededFood;
        Area = area;
    }
}