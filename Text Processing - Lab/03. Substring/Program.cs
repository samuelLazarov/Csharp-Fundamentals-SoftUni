string wordToRemove = Console.ReadLine();

string words = Console.ReadLine();

while (words.Contains(wordToRemove))
{
    int index = words.IndexOf(wordToRemove);
    words = words.Remove(index, wordToRemove.Length);
}

Console.WriteLine(words);
