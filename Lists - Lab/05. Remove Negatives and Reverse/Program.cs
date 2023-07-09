namespace _05._Remove_Negatives_and_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                if (numbers[i] < 0)
                {
                    numbers.RemoveAt(i);
                }

            }
            //numbers.RemoveAll(x => x < 0);

            if (numbers.Count > 0)
            {
                numbers.Reverse();
                Console.WriteLine(String.Join(" ", numbers));
            }
            else
            {
                Console.WriteLine("empty");
            }
            
           
         }
    }
}