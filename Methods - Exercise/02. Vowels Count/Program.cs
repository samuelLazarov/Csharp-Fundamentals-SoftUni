namespace _02._Vowels_Count
    
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(VowelsCount(input));
            
        }

        static int VowelsCount(string input)
        {
            int count = 0;
            foreach (var character in input)
            {
                if (IsVowel(character))
                {
                    count++;
                }
                
            }
            return count;
        }

        static bool IsVowel(char characeter)
        {
            return "aeiouyAEIOUY".IndexOf(characeter) >= 0;
        }
    }
}