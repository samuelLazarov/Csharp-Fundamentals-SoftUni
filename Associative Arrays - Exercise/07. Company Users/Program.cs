Dictionary<string, List<string>> companyUsers =
    new Dictionary<string, List<string>>();
string input;

while ((input = Console.ReadLine()) != "End")
{
    string[] cmdArg = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

    string company = cmdArg[0];
    string employeeId = cmdArg[1];

    if (!companyUsers.ContainsKey(company))
    {
        companyUsers[company] = new List<string>();
    }

    if (!companyUsers[company].Contains(employeeId))
    {
        companyUsers[company].Add(employeeId);
    }

}

foreach (var kvp in companyUsers)
{
    Console.WriteLine($"{kvp.Key}");
    foreach (var user in kvp.Value)
    {
        Console.WriteLine($"-- {user}");
    }
}