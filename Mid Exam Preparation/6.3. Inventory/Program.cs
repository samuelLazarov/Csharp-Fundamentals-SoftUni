using System.Globalization;

List<string> items = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .ToList();

string input = string.Empty;

while (true)
{
    input = Console.ReadLine();
    if (input == "Craft!")
    {
        break;
    }

    string[] command = input.Split(" - ");
    string commandType = command[0];

    if (commandType == "Collect")
    {
        string item = command[1];
        if (!items.Contains(item))
        {
            items.Add(item);
        }
    }
    else if (commandType == "Drop")
    {
        string item = command[1];
        if (items.Contains(item))
        {
            items.Remove(item);
        }
    }
    else if (commandType == "Combine Items")
    {
        string[] oldNewItem = command[1].Split(':');
        string oldItem = oldNewItem[0];
        string newItem = oldNewItem[1];
        int indexOfOldItem = items.IndexOf(oldItem);
        if (items.Contains(oldItem))
        {
            items.Insert(indexOfOldItem+1, newItem);
        }
    }
    else if (commandType == "Renew")
    {
        string item = command[1];
        if (items.Contains(item))
        {
            items.Remove(item);
            items.Add(item);
        }
    }

}

Console.WriteLine(string.Join(", ", items));
