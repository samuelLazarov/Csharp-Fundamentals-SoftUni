internal class Program
{
    private static void Main(string[] args)
    {
        decimal startMoney = decimal.Parse(Console.ReadLine());
        decimal balance = startMoney;
        decimal gamePrice = 0;
        string input = Console.ReadLine();
        decimal totalCost = 0;
        
        while (input != "Game Time")
        {

            
            if (input == "OutFall 4")
            {
                gamePrice = 39.99m;                
                if (balance >= gamePrice)
                {
                    Console.WriteLine($"Bought {input}");
                    balance -= gamePrice;
                    totalCost += gamePrice;
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                }
                

            }
            else if (input == "CS: OG")
            {
                gamePrice = 15.99m;
                
                if (balance >= gamePrice)
                {
                    Console.WriteLine($"Bought {input}");
                    balance -= gamePrice;
                    totalCost += gamePrice;
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                }
                
            }
            else if (input == "Zplinter Zell")
            {
                gamePrice = 19.99m;        
                if (balance >= gamePrice)
                {
                    Console.WriteLine($"Bought {input}");
                    balance -= gamePrice;
                    totalCost += gamePrice;
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                }
                
            }
            else if (input == "Honored 2")
            {
                gamePrice = 59.99m;            
                if (balance >= gamePrice)
                {
                    Console.WriteLine($"Bought {input}");
                    balance -= gamePrice;
                    totalCost += gamePrice;
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                }
                
            }
            else if (input == "RoverWatch")
            {
                gamePrice = 29.99m;           
                if (balance >= gamePrice)
                {
                    Console.WriteLine($"Bought {input}");
                    balance -= gamePrice;
                    totalCost += gamePrice;
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                }
            }
            else if (input == "RoverWatch Origins Edition")
            {
                gamePrice = 39.99m;
                if (balance >= gamePrice)
                {
                    Console.WriteLine($"Bought {input}");
                    balance -= gamePrice;
                    totalCost += gamePrice;
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                }
            }
            else
            {
                Console.WriteLine("Not Found");
            }

            if (balance <= 0m)
            {
                Console.WriteLine("Out of money!");
                return;
            }
            
            input = Console.ReadLine();

        }
        Console.WriteLine($"Total spent: ${totalCost:F2}. Remaining: ${startMoney-totalCost:F2}");
    }
}