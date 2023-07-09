internal class Program
{
    private static void Main(string[] args)
    {
        int lines = int.Parse(Console.ReadLine());
        int[][] triangle = new int[lines][];

        for (int i = 0; i < lines; i++)
        {
            int[] row = new int[i + 1];
            row[0] = 1;
            row[i] = 1;
            
            for (int j = 1; j < i; j++)
            {
                row[j] = triangle[i - 1][j] + triangle[i - 1][j-1];
            }

            triangle[i] = row;
        }

        for (int i = 0; i < lines; i++)
        {
            Console.WriteLine(string.Join(' ', triangle[i]));
        }

    }
}