using System.Text.RegularExpressions;

string matchPattern = @"(=|/)[A-Z][A-Za-z]{2,}\1";

string input = Console.ReadLine();

MatchCollection matchCollection = Regex.Matches(input, matchPattern);

//List<string> matches = new List<string>();
//int travelPoints = 0;

//foreach (Match match in matchCollection)
//{
//    string value = match.Value.Trim('=').Trim('/');

//    matches.Add(value);
//    travelPoints += value.Length;
//}

var result = matchCollection.Select(x => Regex.Match(x.Value, @"\w+").Value);
//var result = matchCollection.Select(x => x.Value.Trim('=').Trim('/'));

Console.WriteLine("Destinations: " + string.Join(", ", result));
Console.WriteLine($"Travel Points: {result.Sum(x => x.Length)}");