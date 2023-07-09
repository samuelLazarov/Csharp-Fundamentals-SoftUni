int[] array = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

string command = Console.ReadLine();

while (command != "end")
{
    string[] commandInfo = command.Split();

    if (commandInfo[0] == "swap")
    {
        int index1 = int.Parse(commandInfo[1]);
        int index2 = int.Parse(commandInfo[2]);
        int currentNumber = array[index1];
        array[index1] = array[index2];
        array[index2] = currentNumber;
    }
    else if (commandInfo[0] == "multiply")
    {
        int index1 = int.Parse(commandInfo[1]);
        int index2 = int.Parse(commandInfo[2]);
        int product = array[index1]*array[index2];
        array[index1]=product;
    }
    else if (commandInfo[0] == "decrease")
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i]--;
        }
    }
    command = Console.ReadLine();
}

Console.WriteLine(string.Join(", ", array));
