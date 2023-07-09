using System.Reflection.PortableExecutable;

List<int> numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();


string input = Console.ReadLine();

while (input != "end")
{
    string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int element = int.Parse(command[1]);
    if (command[0] == "Delete")
    {
        numbers.RemoveAll(x => x == element);
    }
    else if (command[0] == "Insert")

    {
        int position = int.Parse(command[2]);
        numbers.Insert(position, element);
    }

    input = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", numbers));
