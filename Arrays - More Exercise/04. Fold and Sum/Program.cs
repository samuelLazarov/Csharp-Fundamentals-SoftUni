internal class Program
{
    private static void Main(string[] args)
    {
        int[] inputArray = Console.ReadLine()
           .Split()
           .Select(int.Parse)
           .ToArray();

        int leftFoldIndex = inputArray.Length / 4 - 1;
        int rightFoldIndex = 3 * inputArray.Length / 4;

        int[] topArray = new int[inputArray.Length / 2];

        int howManyNumbersSoFar = 0;
        for (int i = leftFoldIndex; i >= 0; i--)
        {
            howManyNumbersSoFar++;
            topArray[leftFoldIndex - i] = inputArray[i];
        }
        for (int i = inputArray.Length - 1; i >= rightFoldIndex; i--)
        {
            topArray[inputArray.Length - 1 - i + howManyNumbersSoFar] = inputArray[i];
        }

        int[] bottomArray = new int[inputArray.Length / 2];

        for (int i = leftFoldIndex + 1; i < rightFoldIndex; i++)
        {
            bottomArray[i - howManyNumbersSoFar] = inputArray[i];
        }

        for (int i = 0; i < topArray.Length; i++)
        {
            Console.Write(topArray[i] + bottomArray[i] + " ");
        }
    }
}