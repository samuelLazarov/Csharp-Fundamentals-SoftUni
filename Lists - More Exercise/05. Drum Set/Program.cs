decimal savings = decimal.Parse(Console.ReadLine());

List<int> drums = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

List<int> price = new List<int>();

string command;

while ((command = Console.ReadLine()!) != "Hit it again, Gabsy!")
{
    int hit = int.Parse(command);
    for (int i = 0; i < drums.Count; i++)
    {
        drums[i] -= hit;

        if (drums[i] <= 0)
        {

           if (savings - (price[i]) * 3 >= 0)
            {
                savings -= price[i] * 3;
                drums[i] = price[i];
           }

        }
    }
        for (int i = 0; i < drums.Count; i++)
    {
        if (drums[i] <= 0)
        {
            drums.Remove(drums[i]);
            price.Remove(drums[i]);
        }
    }

    command = Console.ReadLine();
}

Console.WriteLine(string.Join(' ', drums));
Console.WriteLine($"Gabsy has {savings:f2}lv.");


