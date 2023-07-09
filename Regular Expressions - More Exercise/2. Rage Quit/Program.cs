using System.Text;
using System.Text.RegularExpressions;

string input = Console.ReadLine().ToUpper();

StringBuilder sb = new StringBuilder();

string[] symbolArr = input.Split(new char[] {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9' },
    StringSplitOptions.RemoveEmptyEntries);
string pattern = @"[\d]+";

MatchCollection matches = Regex.Matches(input, pattern);

int[] digits = new int[matches.Count];

int count = 0;

foreach (Match digit in matches)
{
    digits[count] = int.Parse(digit.Value);
    count++;
}
for (int i = 0; i < digits.Length; i++)
{
    int countOfRepeats = digits[i];
    for (int j = 0; j < countOfRepeats; j++)
    {
        sb.Append(symbolArr[i]);
    }
}
char[] uniqueSymbols = sb.ToString().Distinct().ToArray();
Console.WriteLine($"Unique symbols used: {uniqueSymbols.Length}");
Console.WriteLine(sb);