internal class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        
        int longestSequenceStartIndex = 0;
        int longestSequenceLenght = 0;
        

        for (int i = 1; i < numbers.Length; i++)
        {
            int currentSequenceStartIndex = i - 1;
            int currentSequenceLenght = 1;
            while (i < numbers.Length && numbers[i] == numbers[i-1])
            {
                currentSequenceLenght++;
                i++;
            }
            
            if (currentSequenceLenght > longestSequenceLenght)
            {
                longestSequenceLenght = currentSequenceLenght;
                longestSequenceStartIndex = currentSequenceStartIndex;
            }
        }
        for (int i = longestSequenceStartIndex; i < longestSequenceStartIndex + longestSequenceLenght; i++)
        {
            Console.Write($"{numbers[i]} ");
        }
        

    }
}