using System.Security.Cryptography.X509Certificates;

string input = Console.ReadLine();
decimal productPrice = 0.00m;
decimal priceSum = 0.00m ;
decimal totalTaxes = 0.00m;
decimal totalSum = 0.00m;
bool isSpecial = false;
while (true)
{
    if (input == "special")
    {
        isSpecial = true;
        break;
    }
    else if (input == "regular")
    {
        break;
    }
    productPrice = decimal.Parse(input);
    if (productPrice < 0)
    {
        Console.WriteLine("Invalid price!");
    }
    else
    {
        priceSum += productPrice;
    }
    
    input = Console.ReadLine();
}

if (productPrice == 0)
{
    Console.WriteLine("Invalid order!");
    Environment.Exit(0);
}
totalTaxes = 0.2m * priceSum;
totalSum = priceSum + totalTaxes;
if (isSpecial)
{
    totalSum *= 0.9m;
}

Console.WriteLine("Congratulations you've just bought a new computer!");
Console.WriteLine($"Price without taxes: {priceSum:f2}$");
Console.WriteLine($"Taxes: {totalTaxes:f2}$");
Console.WriteLine("-----------");
Console.WriteLine($"Total price: {totalSum:f2}$");
