List<string> lessons = Console.ReadLine()!
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .ToList();

string input;
int index = 0;

while ((input = Console.ReadLine()!) != "course start")
{
    string[] command = input.Split(':', StringSplitOptions.RemoveEmptyEntries);

    string commandType = command[0];
    string lessonTitle = command[1];

    if (commandType == "Add")
    {
        for (int i = 0; i < lessons.Count; i++)
        {
            if (lessonTitle != lessons[i])
            {
                lessons.Add(lessonTitle);
            }
        }
    }
    else if (commandType == "Insert")
    {
        if (lessons.Contains(lessonTitle))
        {
           index = int.Parse(command[2]);
           lessons.Insert(index, lessonTitle);
        }
    }
    else if (commandType == "Remove")
    {
        if (lessons.Contains(lessonTitle))
        {
           lessons.Remove(lessonTitle);
        }
    }
    else if (commandType == "Swap")
    {
        bool isHereLesson1 = false;
        bool isHereLesson2 = false;
        int indexLessonTitle = 0;
        int indexLessonTitleToBeSwapped = 0;
        string lessonTitleToBeSwapped = command[2];
        
        for (int i = 0; i < lessons.Count; i++)
        {
            if (lessons[i] == 
            {
                string swapLesson = lessonTitleToBeSwapped;


            }
        }
        
    }

    else if (commandType == "Exercise")
    {
        if (lessons.Contains(lessonTitle))
        {

        }
        else
        {
            lessons.Add(lessonTitle);
        }
    }

}

for (int i = 0; i < lessons.Count; i++)
{
    Console.WriteLine($"{i}:{lessons[i]}");
}
    
