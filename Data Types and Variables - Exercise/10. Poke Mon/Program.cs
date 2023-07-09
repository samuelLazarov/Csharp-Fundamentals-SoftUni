internal class Program
{
    private static void Main(string[] args)
    {
        int pokePower = int.Parse(Console.ReadLine());
        int pokeDistance = int.Parse(Console.ReadLine());
        int exhaustionFactor = int.Parse(Console.ReadLine());
        int pokePowerByHalf = (int)(0.5 * pokePower);
        int targetsPoked = 0;

        while (pokePower >= pokeDistance)
        {
            pokePower -= pokeDistance;
            targetsPoked++;

            if (pokePower == pokePowerByHalf && exhaustionFactor != 0)
            {
                pokePower /= exhaustionFactor;
            }
        }
        Console.WriteLine(pokePower);
        Console.WriteLine(targetsPoked);

    }
}