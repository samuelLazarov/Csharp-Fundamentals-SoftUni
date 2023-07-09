internal class Program
{
    private static void Main(string[] args)
    {

        DateTime expectedBlossomDay;
        DateTime.TryParse(Console.ReadLine(), out expectedBlossomDay);
            
        int avTemp = int.Parse(Console.ReadLine());
        int avRain = int.Parse(Console.ReadLine());
        int winterDays = int.Parse(Console.ReadLine());

        int optTemp = 20;
        int optRain = 30;

        string yearAsString = expectedBlossomDay.ToString("yyyy");
        int year = int.Parse(yearAsString);
        if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
        {
            avTemp += 5;
        }

        int totalDays = winterDays / 7;
        
        if (avRain - optRain != 0)
        {
            totalDays  += Math.Abs(avRain - optRain) / 3;
        }

        if (avTemp - optTemp > 0)
        {
            totalDays -= Math.Abs(avTemp - optTemp);
        }
        else
        {
            totalDays += Math.Abs(avTemp - optTemp);
        }
        
        string date = expectedBlossomDay.AddDays(totalDays).ToString("dd MMMM yyyy");
        Console.WriteLine(date);
     
    }
}