using System.Security.Cryptography.X509Certificates;

int[] numbers = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
double average = (int)numbers.Average();

int[] result = numbers.Where(c => c > average)
    .OrderByDescending(c => c)
    .Take(5)
    .ToArray();

if (result.Any())
{
    Console.WriteLine(string.Join(" ", result));
}
else
{
    Console.WriteLine("No");
}

