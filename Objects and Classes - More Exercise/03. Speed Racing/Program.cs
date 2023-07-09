
List<Car> cars = new List<Car>();

int numberOfCars = int.Parse(Console.ReadLine());

for (int i = 0; i < numberOfCars; i++)
{
    cars.Add(new Car(Console.ReadLine().Split()));
}


while (true)
{
    string command = Console.ReadLine();
    if (command == "End")
    {
        break;
    }

    string[] drive = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

    string model = drive[1];
    int distance = int.Parse(drive[2]);

    cars.Find(x => x.Model == model).Drive(distance);
    
}

foreach (var car in cars)
{
    Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.DistanceTraveled}");
}


public class Car
{
    public string Model { get; set; }
    public decimal FuelAmount { get; set; }
    public decimal FuelConsumption { get; set; }
    public int DistanceTraveled { get; set; }

    public Car(string[] carCharacteristics)
    {
        this.Model = carCharacteristics[0];
        this.FuelAmount = decimal.Parse(carCharacteristics[1]);
        this.FuelConsumption = decimal.Parse(carCharacteristics [2]);
    }

    public void Drive(int distance)
    {
        decimal fuelNeeded = distance * this.FuelConsumption;
        if (this.FuelAmount >= fuelNeeded)
        {
            this.DistanceTraveled += distance;
            this.FuelAmount -= fuelNeeded;
        }
        else
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
    }

   
}