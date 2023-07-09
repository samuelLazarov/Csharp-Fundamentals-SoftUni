Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string student = Console.ReadLine();
    double grade = double.Parse(Console.ReadLine());

    if (!students.ContainsKey(student))
    {
        students[student] = new List<double>();
    }
    students[student].Add(grade);
}

Console.WriteLine(string.Join($"{Environment.NewLine}", students
    .Where(x => (x.Value.Average()) >= 4.50)
    .Select(x => $"{x.Key} -> {x.Value.Average():F2}")));




