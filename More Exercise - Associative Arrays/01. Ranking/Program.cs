Dictionary<string, string> contests 
    = new Dictionary<string, string>();

Dictionary<string, Dictionary<string, int>> students 
    = new Dictionary<string, Dictionary<string, int>>();

string input = string.Empty;

while ((input = Console.ReadLine()) != "end of contests")
{
    string[] cmdArg = input.Split(':',StringSplitOptions.RemoveEmptyEntries);
    string contest = cmdArg[0];
    string password = cmdArg[1];

    if (!contests.ContainsKey(contest))
    {
        contests.Add(contest, "");
    }
    contests[contest] = password;
}

while ((input = Console.ReadLine()) != "end of submissions")
{
    string[] cmdArg = input.Split("=>", StringSplitOptions.RemoveEmptyEntries);
    string contestInput = cmdArg[0];
    string passwordInput = cmdArg[1];
    string student = cmdArg[2];
    int points = int.Parse(cmdArg[3]);
    if (contests.ContainsKey(contestInput) && contests[contestInput] == passwordInput)
    {
        if (!students.ContainsKey(student))
        {
            students.Add(student, new Dictionary<string, int>());
            students[student].Add(contestInput, points);
        }
        else
        {
            if (!students[student].ContainsKey(contestInput))
            {
                students[student].Add(contestInput, points);
            }
            else
            {
                if (students[student][contestInput] < points) 
                {
                    students[student][contestInput] = points;
                }
            }
        }
    }
}

string bestStudent = "";
int highestPoints = 0;

foreach (var student in students)
{
    int totalPoints = 0;
    foreach (var course in student.Value)
    {
        totalPoints += course.Value;
    }
    if (totalPoints > highestPoints)
    {
        bestStudent = student.Key;
        highestPoints = totalPoints;
    }
}

Console.WriteLine($"Best candidate is {bestStudent} with total {highestPoints} points.");
students = students.OrderBy(x => x.Key).ToDictionary(k => k.Key, v => v.Value);
Console.WriteLine("Ranking: ");
foreach (var student in students)
{
    Console.WriteLine(student.Key);
    foreach (var course in student.Value.OrderByDescending(x => x.Value))
    {
        Console.WriteLine($"#  {course.Key} -> {course.Value}");
    }
}
