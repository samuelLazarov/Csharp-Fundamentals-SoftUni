internal class Program
{
    private static void Main(string[] args)
    {
        int numberOfPeople = int.Parse(Console.ReadLine());
        int elevatorCapaciry = int.Parse(Console.ReadLine());

        int numberOfCourses = numberOfPeople / elevatorCapaciry;

        if (numberOfPeople % elevatorCapaciry != 0)
        {
            numberOfCourses++;
        }
        Console.WriteLine(numberOfCourses);
    }
}