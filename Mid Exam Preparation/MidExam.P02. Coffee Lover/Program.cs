using System.Diagnostics.Contracts;

List<string> coffeeList = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .ToList();

int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    string input = Console.ReadLine();
    string[] command = input.Split(' ',StringSplitOptions.RemoveEmptyEntries);
    
    if (command[0] == "Include")
    {
        coffeeList.Add(command[1]);
    }
    else if (command[0] == "Remove")
    {
        int count = int.Parse(command[2]);
        if (count >= coffeeList.Count)
        {
            continue;
        }
        if (command[1] == "first")
        {
            coffeeList.RemoveRange(0, count);
        }
        else if (command[1] == "last")
        {
            for (int j = 1; j <= count; j++)
            {
                coffeeList.RemoveAt(coffeeList.Count - 1);
            }
            
        }
    }
    else if (command[0] == "Prefer")
    {
        int index1 = int.Parse(command[1]);
        int index2 = int.Parse(command[2]);

        if (index1 < 0 
            || index1 >= coffeeList.Count 
            || index2 < 0
            || index2 >= coffeeList.Count)
        {
            continue;
        }
        string currentCoffee = coffeeList[index1];
        coffeeList[index1] = coffeeList[index2];
        coffeeList[index2] = currentCoffee;
    }
    else if (command[0] == "Reverse")
    {
        coffeeList.Reverse();
    }

}

Console.WriteLine("Coffees:");
Console.WriteLine(string.Join(' ', coffeeList));
