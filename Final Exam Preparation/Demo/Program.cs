string input = Console.ReadLine();
Dictionary<string, List<string>> guests = new Dictionary<string, List<string>>();
int count = 0;
while (input != "Stop")
{
    string[] tokens = input.Split("-", StringSplitOptions.RemoveEmptyEntries);
    string command = tokens.First();
    string guest = tokens[1];
    string meal = tokens[2];
      
    if (command == "Like")
    {
        if (!guests.ContainsKey(guest))
        {
            guests.Add(guest, new List<string>());
            guests[guest].Add(meal);
        }
        else if (!guests[guest].Contains(meal))
        {
            guests[guest].Add(meal);
        }
    }
    else if (command == "Dislike")
    {
        
        if (!guests.ContainsKey(guest))
        {
            Console.WriteLine($"{guest} is not at the party.");
        }
        else if (guests[guest].Contains(meal))
        {
            guests[guest].Remove(meal);
            Console.WriteLine($"{guest} doesn't like the {meal}.");
            count++;
        }
        else
        {
            Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");
        }
    }
    input = Console.ReadLine();
}
foreach (var (key, value) in guests)
{
    Console.Write($"{key}: ");
    foreach (var meal in value)
    {
        Console.Write(string.Join(", ",meal));
    }
    Console.WriteLine();
}
Console.WriteLine($"Unliked meals: {count}");