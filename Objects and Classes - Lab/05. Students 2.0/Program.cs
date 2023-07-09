
List<Student> students = new List<Student>();

string info = Console.ReadLine();

while (info != "end")
{
    string[] infoArray = info.Split();
    string firstName = infoArray[0];
    string lastName = infoArray[1];
    int age = int.Parse(infoArray[2]);
    string town = infoArray[3];
    bool studentExist = false;

    foreach (var student in students)
    {
        if (student.FirstName == firstName && student.LastName == lastName)
        {
            student.Age = age;
            student.Hometown = town;
            studentExist = true;
            break;
        }
    }

    //Student currentStudent = students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);
    //if (currentStudent != null)
    //{
    //    currentStudent.Age = age;
    //    currentStudent.Hometown = town;
    //}
    //studentExist = students.Any(x => x.FirstName == firstName && x.LastName == lastName); // съкратен запис на горния foreach;

    if (!studentExist)
    {
        Student student = new Student()
        {
            FirstName = firstName,
            LastName = lastName,
            Age = age,
            Hometown = town
        };

        students.Add(student);
    }

    info = Console.ReadLine();
}

string homeTown = Console.ReadLine();

foreach (Student currentStudent in students)
{
    if (currentStudent.Hometown == homeTown)
    {
        Console.WriteLine($"{currentStudent.FirstName} {currentStudent.LastName} is {currentStudent.Age} years old.");
    }
}

//Console.WriteLine(String.Join(Environment.NewLine, students
//    .Where(x => x.Hometown == homeTown)
//    .Select(x => $"{x.FirstName} {x.LastName} is {x.Age} years old.")));  //върши същата работа като предния foreach с LINQ



class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public int Age { get; set; }

    public string Hometown { get; set; }
}