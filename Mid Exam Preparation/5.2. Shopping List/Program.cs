List<string> groceries = Console.ReadLine()!
    .Split('!', StringSplitOptions.RemoveEmptyEntries)
    .ToList();

while (true)
{
    string input = Console.ReadLine()!;
    if (input == "Go Shopping!")
    {
        break;
    }

    string[] command = input.Split();
    string commandType = command[0];

    if (commandType == "Urgent")
    {
        string item = command[1];
        if (!groceries.Contains(item))
        {
            groceries.Insert(0, item);
        }


    }
    else if (commandType == "Unnecessary")
    {
        string item = command[1];
        if (groceries.Contains(item))
        {
            groceries.Remove(item);
        }

    }
    else if (commandType == "Correct")
    {
        string oldItem = command[1];
        string newItem = command[2];
        if (groceries.Contains(oldItem))
        {
            int indexOfOldItem = groceries.IndexOf(oldItem);
            groceries.Remove(oldItem);
            groceries.Insert(indexOfOldItem, newItem);
        }

    }
    else if (commandType == "Rearrange")
    {
        string item = command[1];
        if (groceries.Contains(item))
        {
            int indexOfItem = groceries.IndexOf(item);
            string currentItem = groceries[indexOfItem];
            groceries.Remove(item);
            groceries.Add(currentItem);
        }
    }
}

Console.WriteLine(string.Join(", ", groceries));

