Dictionary<string, double[]> orders =
    new Dictionary<string, double[]>();

string input;
while ((input = Console.ReadLine()) != "buy")
{
    string[] cmdArg = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
    string product = cmdArg[0];
    double price = double.Parse(cmdArg[1]);
    double quantity = double.Parse(cmdArg[2]);

    if (!orders.ContainsKey(product))
    {
        orders[product] = new double[2]; // 0 -> price
                                         // 1 -> quantity
    }

    orders[product][0] = price;
    orders[product][1] += quantity;

}

foreach (var kvp in orders)
{
    double totalPrice = kvp.Value[0] * kvp.Value[1];
    
    Console.WriteLine($"{kvp.Key} -> {totalPrice:F2}");

}
