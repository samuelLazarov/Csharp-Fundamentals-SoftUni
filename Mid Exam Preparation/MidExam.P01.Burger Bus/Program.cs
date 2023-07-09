int numberOfCities = int.Parse(Console.ReadLine());

decimal totalProfit = 0.00m;

for (int i = 1; i <= numberOfCities; i++)
{
    string cityName = Console.ReadLine();
    decimal income = decimal.Parse(Console.ReadLine());
    decimal expenses = decimal.Parse(Console.ReadLine());
    
    if (i % 3 == 0 && i % 5 !=0)
    {
        expenses *= 1.50m;
    }
    else if (i % 5 == 0)
    {
        income *= 0.9m;
    }
    
    decimal profit = income - expenses;
    Console.WriteLine($"In {cityName} Burger Bus earned {profit:f2} leva.");
    totalProfit += profit;
}

Console.WriteLine($"Burger Bus total profit: {totalProfit:f2} leva.");
