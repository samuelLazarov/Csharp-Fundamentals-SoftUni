Dictionary<string, List<double>> cars 
    = new Dictionary<string, List<double>>();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] inputInfo = Console.ReadLine()
        .Split('|', StringSplitOptions.RemoveEmptyEntries);

    string carName = inputInfo[0];
    double mileage = double.Parse(inputInfo[1]);
    double fuel = double.Parse(inputInfo[2]);

    cars.Add(carName, new List<double> { mileage, fuel });
}

string command = Console.ReadLine();
while (command != "Stop")
{
    string[] commandInfo = command
        .Split(" : ", StringSplitOptions.RemoveEmptyEntries);

    string commandName = commandInfo[0];

    if (commandName == "Drive")
    {
        string carName = commandInfo[1];
        double desiredDistance = double.Parse(commandInfo[2]);
        double desiredFuel = double.Parse(commandInfo[3]);

        List<double> car = cars[carName];
        double carMileage = car[0];
        double carFuel = car[1];

        if (desiredFuel > carFuel)
        {
            Console.WriteLine("Not enough fuel to make that ride");
            command = Console.ReadLine();
            continue;
        }
        cars[carName][0] += desiredDistance;
        cars[carName][1] -= desiredFuel;

        Console.WriteLine($"{carName} driven for {desiredDistance} kilometers. {desiredFuel} liters of fuel consumed.");

        if (carMileage > 100_000)
        {
            Console.WriteLine($"Time to sell the {carName}!");
            cars.Remove(carName);
        }

    }
    else if (commandName == "Refuel")
    {
        string carName = commandInfo[1];
        double fuelToRefuel = double.Parse(commandInfo[2]);

        List<double> car = cars[carName];
        double mileage = car[0];
        double carFuel = car[1];

        double actualFuel = 0;

        if (fuelToRefuel + carFuel > 75)
        {
            actualFuel = 75 - carFuel;
        }
        else
        {
            actualFuel = fuelToRefuel;
        }

        car[1] += fuelToRefuel;

        if (car[1] > 75)
        {
            car[1] = 75;
        }

        Console.WriteLine($"{carName} refueled with {actualFuel} liters");
    }

    else if (commandName == "Revert")
    {

        string carName = commandInfo[1];
        double km = double.Parse(commandInfo[2]);
        List<double> car = cars[carName];

        double mileage = car[0];
        double fuel = car[1];

        car[0] -= km;

        if (car[0] < 10_000)
        {
            car[0] = 10_000;
        }
        else
        {
            Console.WriteLine($"{carName} mileage decreased by {km} kilometers");
        }
        
    }
    command = Console.ReadLine();
}

foreach (var (key, value) in cars)
{
    Console.WriteLine($"{key} -> Mileage: {value[0]} kms, Fuel in the tank: {value[1]} lt.");
}