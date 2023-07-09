string input = Console.ReadLine();

string command = Console.ReadLine();

while (command != "Finish")
{
    string[] tokens = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    string decryptingCommand = tokens.First();

    if (decryptingCommand == "Replace")
    {
        string currentChar = tokens[1];
        string newChar = tokens[2];
        input = input.Replace(currentChar, newChar);
        Console.WriteLine(input);
    }
    else if (decryptingCommand == "Cut")
    {
        int startIndex = int.Parse(tokens[1]);
        int endIndex = int.Parse(tokens[2]);
        if (startIndex >= 0 && startIndex < input.Length && endIndex >= 0 && endIndex < input.Length)
        {
            input = input.Remove(startIndex, endIndex - startIndex +1);
            Console.WriteLine(input);
        }
        else
        {
            Console.WriteLine("Invalid indices!");
        }
    }
    else if (decryptingCommand == "Make")
    {
        string makeType = tokens[1];
        if (makeType == "Upper")
        {
            input = input.ToUpper();
            Console.WriteLine(input);
        }
        else if (makeType == "Lower")
        {
            input = input.ToLower();
            Console.WriteLine(input);
        }

    }
    else if (decryptingCommand == "Check")
    {
        string substring = tokens[1];
        if (input.Contains(substring))
        {
            Console.WriteLine($"Message contains {substring}");
        }
        else
        {
            Console.WriteLine($"Message doesn't contain {substring}");
        }
    }
    else if (decryptingCommand == "Sum")
    {
        int startIndex = int.Parse(tokens[1]);
        int endIndex = int.Parse(tokens[2]);
        if (startIndex >= 0 && startIndex < input.Length && endIndex >= 0 && endIndex < input.Length)
        {
            string substring = input.Substring(startIndex, endIndex - startIndex + 1);
            int sum = 0;
            for (int i = 0; i < substring.Length; i++)
            {
                sum += substring[i];
            }
            Console.WriteLine(sum);
        }
        else
        {
            Console.WriteLine("Invalid indices!");
        }
       
    }
    command = Console.ReadLine();
}
