using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

List<Vehicle> catalogue = new List<Vehicle>();

string[] inputTokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

while (inputTokens[0] != "End")
{
    string type = inputTokens[0].ToLower();
    string model = inputTokens[1];
    string color = inputTokens[2].ToLower();
    int horsePower = int.Parse(inputTokens[3]);
    Vehicle currentVehicle = new Vehicle(type, model, color, horsePower);
    catalogue.Add(currentVehicle);
    inputTokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
}

string input = Console.ReadLine();

while (input != "Close the Catalogue")
{
    Console.WriteLine();

    Console.WriteLine(catalogue.Find(x => x.Model == input));

    input = Console.ReadLine();
}



List<Vehicle> ListOfCars = catalogue.Where(x => x.VehicleType == "car").ToList();
List<Vehicle> ListOfTrucks = catalogue.Where(x => x.VehicleType == "truck").ToList();
double totalCarsPower = 0.00;
double totalTrucksPower = 0.00;

foreach (var car in ListOfCars)
{
    totalCarsPower += car.HorsePower;
}

foreach (var truck in ListOfTrucks)
{
    totalTrucksPower += truck.HorsePower;
}

double avgCarsHorsePower = totalCarsPower / ListOfCars.Count;
double avgTruckHorsePower = totalTrucksPower / ListOfTrucks.Count;

if (ListOfCars.Count > 0)
{
    Console.WriteLine($"Cars have average horsepower of: {avgCarsHorsePower:F2}.");
}
else
{
    Console.WriteLine($"Cars have average horsepower of: {0:F2}.");
}
if (ListOfTrucks.Count > 0)
{
    Console.WriteLine($"Trucks have average horsepower of: {avgTruckHorsePower:F2}.");
}
else
{
    Console.WriteLine($"Trucks have average horsepower of: {0:F2}.");
}



public class Vehicle

{
    public Vehicle(string vehicleType, string model, string color, int horsePower)
    {
        VehicleType = vehicleType;
        Model = model;
        Color = color;
        HorsePower = horsePower;
    }

    public string VehicleType { get; set; }

    public string Model { get; set; }

    public string Color { get; set; }

    public int HorsePower { get; set; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"Type: {(this.VehicleType == "car" ? "Car" : "Truck")}");
        sb.AppendLine($"Model: {Model}");
        sb.AppendLine($"Color: {Color}");
        sb.AppendLine($"Horsepower: {HorsePower}");

        return sb.ToString()
        .Trim('\n');
    }



}
