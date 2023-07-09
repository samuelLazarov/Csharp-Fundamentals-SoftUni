using System.Reflection.PortableExecutable;

List<int> wagons = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

int maxCapacityOfWagon = int.Parse(Console.ReadLine());

string input = Console.ReadLine();

while (input != "end")
{
    string[] command = input.Split(" "); //"Add", "60"

    if (command.Length == 2)
    {
        int passengers = int.Parse(command[1]);
        wagons.Add(passengers);
    }
    else
    {
        int passengers = int.Parse(command[0]);

        //int wagon = wagons.First(peopleInWagon => peopleInWagon + passengers <= maxCapacityOfWagon);
        //wagons[wagons.IndexOf(wagon)] += passengers;

        for (int i = 0; i < wagons.Count; i++)
        {
            if (wagons[i] + passengers <= maxCapacityOfWagon)
            {
                wagons[i] += passengers;
                break;
            }
        }
    }

    input = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", wagons));
