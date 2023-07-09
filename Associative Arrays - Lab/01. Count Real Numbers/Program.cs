int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

SortedDictionary<int, int> sortedNumbers = new SortedDictionary<int, int>();

foreach (var number in numbers)
{
    if (!sortedNumbers.ContainsKey(number))
    {
        sortedNumbers.Add(number, 1);
    }
    else
    {
        sortedNumbers[number] += 1;
    }
}

foreach (var number in sortedNumbers)
{
    Console.WriteLine($"{number.Key} -> {number.Value}");
}