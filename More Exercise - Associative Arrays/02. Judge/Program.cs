Dictionary<string, Dictionary<string, int>> contests =
    new Dictionary<string, Dictionary<string, int>>();

SortedDictionary<string, Dictionary<string, int>> individualStatistics =
    new SortedDictionary<string, Dictionary<string, int>>();


string input = string.Empty;

while ((input = Console.ReadLine()) != "no more time")
{
    string student = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries)[0].ToString();
    string contest = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries)[1].ToString();
    int points = int.Parse(input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries)[2].ToString());

    if (contests.ContainsKey(contest))
    {
        if (contests[contest].ContainsKey(student))
        {
            if (contests[contest][student] < points)
            {
                contests[contest][student] = points; 
            }
        }
        else
        {
            contests[contest].Add(student, points);
        }
    }
    else
    {
        contests.Add(contest, new Dictionary<string, int>());
        contests[contest].Add(student, points);
    }

    if (individualStatistics.ContainsKey(student))
    {
        if (individualStatistics[student].ContainsKey(contest))
        {
            if (individualStatistics[student][contest] < points)
            {
                individualStatistics[student][contest] = points;
            }
        }
        else
        {
            individualStatistics[student].Add(contest, points);
        }
    }
    else
    {
        individualStatistics.Add(student, new Dictionary<string, int>());
        individualStatistics[student].Add(contest, points);
    }
}

//contests = contests.OrderByDescending(x => x.Value.Count)
//                   .ThenBy(x => x.Key)
//                   .ToDictionary(a => a.Key, b => b.Value);
int position = 1;

foreach (var contest in contests)
{
    position = 1;
    Console.WriteLine($"{contest.Key}: {contest.Value.Count} participants");
    foreach (var student in contest.Value
        .OrderByDescending(x => x.Value)
        .ThenBy(x => x.Key))
    {
        Console.WriteLine($"{position}. {student.Key} <::> {student.Value}");
        position++;
    }
}

Dictionary<string, int> filterIndividual 
    = new Dictionary<string, int>();

int sum = 0;

foreach (var item in individualStatistics)
{
    foreach (var items in item.Value)
    {
        sum += items.Value;
    }
    filterIndividual.Add(item.Key, sum);
    sum = 0;
}

filterIndividual = filterIndividual.OrderByDescending(x => x.Value)
    .ThenBy(x => x.Key).ToDictionary(a=> a.Key, b => b.Value);
position = 1;
Console.WriteLine("Individual standings:");
foreach (var student in filterIndividual)
{
    Console.WriteLine($"{position}. {student.Key} -> {student.Value}");
    position++;
}

