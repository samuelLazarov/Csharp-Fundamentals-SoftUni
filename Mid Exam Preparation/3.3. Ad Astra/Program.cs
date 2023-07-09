int employee1 = int.Parse(Console.ReadLine());
int employee2 = int.Parse(Console.ReadLine());
int employee3 = int.Parse(Console.ReadLine());
int studentsCount = int.Parse(Console.ReadLine());

int time = 0;

while (studentsCount > 0)
{
    studentsCount -= employee1 + employee2 + employee3;
    time++;
    if (time % 4 == 0)
    {
        time++;
    }
}

Console.WriteLine($"Time needed: {time}h.");
