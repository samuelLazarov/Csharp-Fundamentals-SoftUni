List<Car> cars = new List<Car>();

int numberOfCars = int.Parse(Console.ReadLine());

for (int i = 0; i < numberOfCars; i++)
{
    cars.Add(new Car(Console.ReadLine().Split()));
}

string cargoType = Console.ReadLine();

if (cargoType == "fragile")
{
    foreach (var car in cars.Where(x => x.CarsCargo.Type == "fragile" && x.CarsCargo.Weight < 1000))
    {
        Console.WriteLine($"{car.Model}");
    }
}
else if (cargoType == "flamable")
{
    foreach (var car in cars.Where(x => x.CarsCargo.Type == "flamable" && x.CarsEngine.Power >250))
    {
        Console.WriteLine($"{car.Model}");
    }
}


public class Car
{
    public Car(string[] carInfo)
    {
        this.Model = carInfo[0];
        this.CarsEngine = new Engine(int.Parse(carInfo[1]), int.Parse(carInfo[2]));
        this.CarsCargo = new Cargo(int.Parse(carInfo[3]), carInfo[4]);
     
    }

    public string Model { get; set; }
    public Engine CarsEngine { get; set; }
    public Cargo CarsCargo { get; set; }

    

   



}
public class Engine
{
    public Engine(int speed, int power)
    {
        this.Speed = speed;
        this.Power = power;
    }

    public int Speed { get; set; }
    public int Power { get; set; }
}
public class Cargo
{
    public Cargo(int weight, string type)
    {
        this.Weight = weight;
        this.Type = type;
    }

    public int Weight { get; set; }
    public string Type { get; set; }
}