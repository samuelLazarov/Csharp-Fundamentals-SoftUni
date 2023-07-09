using System.Security.Cryptography.X509Certificates;

List<int> numbers = Console.ReadLine()!
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

string message = Console.ReadLine()!;

List<char> messageChars = new List<char>();
messageChars.AddRange(message);

for (int i = 0; i < numbers.Count; i++)
{
    int sum = 0;
    while (numbers[i] > 0)
    {
        int n = numbers[i] % 10;
        sum += n;
        numbers[i] /= 10;
    }
    int times = sum / messageChars.Count;
    sum = sum - times * messageChars.Count;
    Console.Write(messageChars[sum]);
    messageChars.RemoveAt(sum);
}
