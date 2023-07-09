int n = int.Parse(Console.ReadLine());

List<string> guestlist = new List<string>();

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine()
		.Split(" ", StringSplitOptions.RemoveEmptyEntries);

    string name = input[0];

    if (input.Length == 3)
	{
		if (guestlist.Contains(name))
		{
			Console.WriteLine($"{name} is already in the list!");
		}
		else
		{
            guestlist.Add(name);
        }
		
	}
	else if (input.Length == 4)
	{
		if (!guestlist.Contains(name))
		{
			Console.WriteLine($"{name} is not in the list!");
		}

		else
		{
            guestlist.Remove(name);
        }
		
	}

}
Console.WriteLine(string.Join(Environment.NewLine, guestlist));
