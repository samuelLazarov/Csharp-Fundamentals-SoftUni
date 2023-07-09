using System.Data;

internal class Program
{
    private static void Main(string[] args)
    {
        decimal.TryParse(Console.ReadLine(), out decimal amountOfMoney);
        int.TryParse(Console.ReadLine(), out int studentsCount);
        decimal.TryParse(Console.ReadLine(), out decimal sabresPrice);
        decimal.TryParse(Console.ReadLine(), out decimal robesPrice);
        decimal.TryParse(Console.ReadLine(), out decimal beltsPrice);

        int freeBelts = 0;

        if (studentsCount / 6 >= 1)
        {
            freeBelts = studentsCount / 6;
        }

        decimal sabresCount = (decimal)Math.Ceiling(studentsCount * 1.1);

        decimal totalCost = sabresPrice * sabresCount + robesPrice * studentsCount + beltsPrice * (studentsCount - freeBelts);

        if (amountOfMoney >= totalCost)
        {
            Console.WriteLine($"The money is enough - it would cost {totalCost:F2}lv.");
        }
        else
        {
            Console.WriteLine($"John will need {totalCost-amountOfMoney:F2}lv more.");
        }

    }
}