List<string> words = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToList();

string input;

while ((input = Console.ReadLine()) != "3:1")
{
    string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

    string commandType = command[0];

    if (commandType == "merge")
    {
        int startIndex = int.Parse(command[1]);
        int endIndex = int.Parse(command[2]);

        FixInvalidIndexes(words,ref startIndex, ref endIndex);
        MergedWords(words,startIndex,endIndex);
        

    }
    else if (commandType == "divide")
    {

        int index = int.Parse(command[1]);
        int partitions = int.Parse(command[2]);

        string word = words[index];
        List<string> partitionsList = DivideWord(word, partitions);

        words.RemoveAt(index);
        words.InsertRange(index, partitionsList);
        
    }
}

Console.WriteLine(string.Join(" ", words));


void FixInvalidIndexes(List<string> words, ref int startIndex, ref int endIndex)
{
    if (startIndex < 0)
    {
        //First possible
        startIndex = 0;
    }
    if (startIndex >= words.Count)
    {
        startIndex = words.Count - 1;
    }

    if (endIndex <= 0)
    {
        endIndex = 0;
    }

    if (endIndex >= words.Count-1)
    {
        endIndex = words.Count-1;
    }
}

void MergedWords(List<string> words, int startIndex, int endIndex)
{
    string mergedText = string.Empty;

    for (int i = startIndex; i <= endIndex; i++)
    {
        string currentWord = words[startIndex];
        mergedText += currentWord;
        words.RemoveAt(startIndex);
    }

    words.Insert(startIndex, mergedText);
}

static List<string> DivideWord(string word, int partitions)
{
    int substringsLenght = word.Length / partitions;
    int lastSubstringLenght = word.Length - ((partitions - 1) * substringsLenght);
    List<string> partitionsList = new List<string>();
    //All without the last one
    for (int i = 0; i < partitions; i++)
    {
        int desiredLenght = substringsLenght;
        if (i == partitions - 1)
        {
            desiredLenght = lastSubstringLenght;
        }
        char[] newPartitionArr = word
            .Skip(i * substringsLenght)
            .Take(desiredLenght)
            .ToArray();
        string newPartition = string.Join("", newPartitionArr);
        partitionsList.Add(newPartition);

    }
    return partitionsList;
}
