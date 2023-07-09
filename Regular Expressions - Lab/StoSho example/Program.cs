using System.Text.RegularExpressions;

string input = "Hello, SoftUni"; //Console...
string pattern = @"[A-Z][a-z]+";

//static or non-static (instance)

//Regex regex = new Regex("[A-Z][a-z]+");
//Match match = regex.Match(input);
//bool isMatch = regex.IsMatch(input);
//MatchCollection matches = regex.Matches(input);
//string result = regex.Replace(input, "***");
//string[] result2 = regex.Split(input);

Match match = Regex.Match(input, pattern);
bool isMatch = Regex.IsMatch(input, pattern);
MatchCollection matchCollection = Regex.Matches(input, pattern);

string result = match.Value;
bool success = match.Success;
GroupCollection groupCollection = match.Groups;
string value = groupCollection[1].Value;
string value2 = groupCollection["name"].Value;

foreach (Match item in groupCollection)
{

}