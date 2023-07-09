double quantityOfFood = double.Parse(Console.ReadLine());
double quantityOfHay = double.Parse(Console.ReadLine());
double quantityOfCover = double.Parse(Console.ReadLine());
double puppyWeight = double.Parse(Console.ReadLine());

bool hasEnought = true;

for (int i = 1; i <= 30; i++)
{
    
    if (quantityOfFood > 0)
    {
        quantityOfFood -= 0.3;
    }
    else
    {
        hasEnought = false;
        break;
    }

    
    if (i % 2 == 0 && quantityOfHay > 0)
    {
        quantityOfHay -= quantityOfFood * 0.05;
    }
    
    if (i % 3 == 0 && quantityOfCover > 0)
    {
        quantityOfCover -= puppyWeight / 3;
    }
   
    if (quantityOfFood <= 0 || quantityOfHay <= 0 || quantityOfCover <= 0)
    {
        hasEnought = false;
        break;
    }
}

if (hasEnought)
{
    Console.WriteLine($"Everything is fine! Puppy is happy! Food: {quantityOfFood:f2}, Hay: {quantityOfHay:f2}, Cover: {quantityOfCover:f2}.");
}
else
{
    Console.WriteLine("Merry must go to the pet store!");
}
