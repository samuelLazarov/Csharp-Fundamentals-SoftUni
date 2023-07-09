int days = int.Parse(Console.ReadLine());
int dailyPlunder = int.Parse(Console.ReadLine());
double targetPlunder = double.Parse(Console.ReadLine());
double totalPlunder = 0;


for (int i = 1; i <= days; i++)
{
    totalPlunder += dailyPlunder;

    if (i % 3 == 0)
    {
        totalPlunder += 0.5 * dailyPlunder;
    }

    if (i % 5 == 0)
    {
        totalPlunder *= 0.7;
    }


}

if (totalPlunder >= targetPlunder)
{
    Console.WriteLine($"Ahoy! {totalPlunder:F2} plunder gained.");
}
else
{
    double percentage = totalPlunder / targetPlunder * 100;
    Console.WriteLine($"Collected only {percentage:F2}% of the plunder.");
}



