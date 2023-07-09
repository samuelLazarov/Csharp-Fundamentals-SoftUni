List<string> input = Console.ReadLine()
    .Split('|')
    .ToList();

input.Reverse();

List<int> numbers = new List<int>();

foreach (var number in input)
{
    numbers.AddRange(number
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToList());
}

Console.WriteLine(String.Join(" ", numbers));
