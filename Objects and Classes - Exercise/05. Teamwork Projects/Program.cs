using System.Text;

int numberOfTeams = int.Parse(Console.ReadLine());

List<Team> teams = new List<Team>();

for (int i = 0; i < numberOfTeams; i++)
{
    string[] inputTokens = Console.ReadLine()
        .Split("-", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();

    string user = inputTokens[0];
    string teamName = inputTokens[1];
 

    if (teams.Select(x => x.Name).Contains(teamName))
    {
        Console.WriteLine($"Team {teamName} was already created!");
        continue;
    }

    if (teams.Select(x => x.Creator).Contains(user))
    {
        Console.WriteLine($"{user} cannot create another team!");
        continue;
    }

    Team currentTeam = new Team(teamName, user);
    teams.Add(currentTeam);
    Console.WriteLine($"Team {teamName} has been created by {user}!");


}
string input;
while ((input = Console.ReadLine()) != "end of assignment")
{
    string[] inputTokens = input
        .Split("->", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();

    string teamMember = inputTokens[0];
    string teamName = inputTokens[1];

    Team team = teams.FirstOrDefault(x => x.Name == teamName);

    if (team is null)
    {
        Console.WriteLine($"Team {teamName} does not exist!");
        continue;
    }

    if (team.Creator == teamMember || teams.SelectMany(x => x.Members).Contains(teamMember))
    {
        Console.WriteLine($"Member {teamMember} cannot join team {teamName}!");
        continue;
    }

    team.Members.Add(teamMember);
    
}

List<Team> orderedTeamsByMembersCountAndName = teams
    .Where(x => x.Members.Count != 0)
    .OrderByDescending(x => x.Members.Count)
    .ThenBy(x => x.Name)
    .ToList();


List<Team> disbandTeams = teams
    .Where(x => x.Members.Count == 0)
    .OrderBy(x => x.Name)
    .ToList();

foreach (Team team in orderedTeamsByMembersCountAndName)
{
    Console.WriteLine(team);
}
Console.WriteLine("Teams to disband:");
foreach (var team in disbandTeams)
{
    Console.WriteLine(team.Name);
}


public class Team
{
    public Team(string name, string creator)
    {
        Name = name;
        Creator = creator;
    }

    public string Name { get; set; }
    public string Creator { get; set; }

    public List<string> Members { get; set; } = new List<string>();

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(Name);
        sb.AppendLine($"- {Creator}");

        List<string> orderedMembers = Members
            .OrderBy(x => x)
            .ToList();

        foreach (var member in orderedMembers)
        {
            sb.AppendLine($"-- {member}");
        };

        return sb.ToString().TrimEnd('\n');
    }
}

