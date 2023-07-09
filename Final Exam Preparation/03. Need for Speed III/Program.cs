Dictionary<string, string> cars = new Dictionary<string, string>();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] inputInfo = Console.ReadLine()
        .Split('|', StringSplitOptions.RemoveEmptyEntries);

    string carName = inputInfo[0];
    string mileage = inputInfo[1];
    string fuel = inputInfo[2];

    cars.Add(carName, $"{mileage}:{fuel}");

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

        string[] car = cars[carName].Split(':'); 
        double carMileage = double.Parse(car[0]);
        double carFuel = double.Parse(car[1]);

        if (desiredFuel > carFuel)
        {
            Console.WriteLine("Not enough fuel to make that ride");
            command = Console.ReadLine();
            continue;
        }
        carMileage += desiredDistance;
        carFuel -= desiredFuel;

        Console.WriteLine($"{carName} driven for {desiredDistance} kilometers. {desiredFuel} liters of fuel consumed.");

        cars[carName] = $"{carMileage}:{carFuel}";


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

        string[] car = cars[carName].Split(':');
        double mileage = double.Parse(car[0]);
        double carFuel = double.Parse(car[1]);

        double actualFuel = 0;

        if (fuelToRefuel + carFuel > 75)
        {
            actualFuel = 75 - carFuel;
        }
        else
        {
            actualFuel = fuelToRefuel;
        }

        carFuel += fuelToRefuel;

        if (carFuel > 75)
        {
            carFuel = 75;
        }

        cars[carName] = $"{mileage}:{carFuel}";

        Console.WriteLine($"{carName} refueled with {actualFuel} liters");
    }

    else if (commandName == "Revert")
    {

        string carName = commandInfo[1];
        double km = double.Parse(commandInfo[2]);
        string[] car = cars[carName].Split(':');

        double mileage = double.Parse(car[0]);
        double fuel = double.Parse(car[1]);

        mileage -= km;

        if (mileage < 10_000)
        {
            mileage = 10_000;
        }
        else
        {
            Console.WriteLine($"{carName} mileage decreased by {km} kilometers");
        }
        cars[carName] = $"{mileage}:{fuel}";
        Console.WriteLine(); 
    }
    command = Console.ReadLine();
}

foreach (var (key,value) in cars)
{
    string[] carInfo = value.Split(':');
    Console.WriteLine($"{key} -> Mileage: {carInfo[0]} kms, Fuel in the tank: {carInfo[1]} lt."); 
}

