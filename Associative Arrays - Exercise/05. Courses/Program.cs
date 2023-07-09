Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

string input;

while ((input = Console.ReadLine()) != "end")
{
    string[] cmdArg = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
    string course = cmdArg[0];
    string student = cmdArg[1];

    if (!courses.ContainsKey(course))
    {
        courses[course] = new List<string>();
    }
    courses[course].Add(student);
}

foreach (var course in courses)
{
    Console.WriteLine($"{course.Key}: {course.Value.Count}");
    foreach (var name in course.Value)
    {
        Console.WriteLine($"-- {name}");
    }
}
