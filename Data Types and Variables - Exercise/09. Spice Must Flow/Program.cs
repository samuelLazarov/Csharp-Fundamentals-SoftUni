﻿internal class Program
{
    private static void Main(string[] args)
    {
        int sourceYield = int.Parse(Console.ReadLine());

        int days = 0;
        int sum = 0;
        int spicePerDay = 0;

        while (sourceYield >= 100)
        {
            days++;
            spicePerDay = sourceYield - 26;
            sum += spicePerDay;
            sourceYield -= 10;
        }
        
        if (days > 0)
        {
            sum -= 26;
        }

        Console.WriteLine(days);
        Console.WriteLine(sum);

    }
}