//INPUT ^(?<tagSymbol>\$|%)(?<tag>[A-Z][a-z]{2,})\k<tagSymbol>: (?<nums>\[\d+\])\|(?<numsTwo>\[\d+\])\|(?<numsThree>\[\d+\])\|$
using System.Text.RegularExpressions;

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    string pattern = @"^(?<tagSymbol>\$|%)(?<tag>[A-Z][a-z]{2,})\k<tagSymbol>: \[(?<nums>\d+)\]\|\[(?<numsTwo>\d+)\]\|\[(?<numsThree>\d+)\]\|$";
    Regex regex = new Regex(pattern);
    Match currentMatch = regex.Match(input);

    if (currentMatch.Success)
    {
        string numsGroupOne = (currentMatch.Groups["nums"].Value);
        string numsGroupTwo = (currentMatch.Groups["numsTwo"].Value);
        string numsGroupThree = (currentMatch.Groups["numsThree"].Value);

        int numOne = int.Parse(numsGroupOne);
        int numTwo = int.Parse(numsGroupTwo);
        int numThree = int.Parse(numsGroupThree);

        char charOne = Convert.ToChar(numOne);
        char charTwo = Convert.ToChar(numTwo);
        char charThree = Convert.ToChar(numThree);

        Console.WriteLine($"{currentMatch.Groups["tag"]}: {charOne}{charTwo}{charThree}");
    }
    else
    {
        Console.WriteLine("Valid message not found!");
    }

}