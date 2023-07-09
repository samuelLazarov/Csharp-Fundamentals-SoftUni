using System.Text.RegularExpressions;

string text = Console.ReadLine();
string pattern = @"(^|(?<=\s))(([a-zA-Z0-9]+)([\.\-_]?)([A-Za-z0-9]+)(@)([a-zA-Z]+([\.\-][A-Za-z]+)+))(\b|(?=\s))";
Regex regex = new Regex(pattern);
MatchCollection matches = regex.Matches(text);
if (regex.IsMatch(text))
{
	foreach (Match email in matches)
	{
		Console.WriteLine(email);
	}
}
