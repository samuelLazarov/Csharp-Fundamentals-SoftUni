internal class Program
{
    private static void Main(string[] args)
    {
        //int[] inputnumbers = console.readline()
        //                    .split()
        //                    .select(int.parse)
        //                    .toarray();

        //for (int i = 0; i < inputnumbers.length; i++)
        //{
        //    bool istopinteger = true;
        //    for (int j = i + 1; j < inputnumbers.length; j++)
        //    {
        //        if (inputnumbers[i] <= inputnumbers[j])
        //        {
        //            istopinteger = false;
        //        }

        //    }

        //    if (istopinteger)
        //    {
        //        console.write(inputnumbers[i] + " ");
        //    }
        //}

        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        
        for (int i = 0; i < numbers.Length; i++)
        {
            bool isTop = true;
            for (int j = i+1; j < numbers.Length; j++)
            {
                if (numbers[i] <= numbers[j])
                {
                    isTop = false;
                    break;
                }
                
            }
            if (isTop)
            {
                Console.Write($"{numbers[i]} ");

            }
        }

        


    }
}