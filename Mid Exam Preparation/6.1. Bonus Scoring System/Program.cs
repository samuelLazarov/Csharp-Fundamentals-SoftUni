int studentsCount = int.Parse(Console.ReadLine());
int lecturesCount = int.Parse(Console.ReadLine());
int additionalBonus = int.Parse(Console.ReadLine());
int[] studentsAttendance = new int[studentsCount];
double maxBonus = 0;
int topStudentAttendance = 0;

for (int i = 0; i < studentsCount; i++)
{
    studentsAttendance[i] = int.Parse(Console.ReadLine());
    double totalBonus = ((double)studentsAttendance[i] / lecturesCount) * (5 + additionalBonus);
    if (maxBonus < totalBonus)
    {
        maxBonus = totalBonus;
        topStudentAttendance = studentsAttendance[i];
    }
}

Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
Console.WriteLine($"The student has attended {topStudentAttendance} lectures.");

