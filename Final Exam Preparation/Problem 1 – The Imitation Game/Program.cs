string message = Console.ReadLine();

string command = Console.ReadLine();  

while (command != "Decode")
{
    string[] commandInfo = command.Split('|', 
        StringSplitOptions.RemoveEmptyEntries);  

    string commandName = commandInfo[0];

    if (commandName == "Move")
    {
        int n = int.Parse(commandInfo[1]);
        string substring = message.Substring(0, n);
        message = message.Remove(0, n);
        message += substring;
    }
    else if (commandName == "Insert")
    {
        int n = int.Parse(commandInfo[1]);
        string value = commandInfo[2];
        message = message.Insert(n, value);
    }
    else if (commandName == "ChangeAll")
    {
        string substring = commandInfo[1];
        string replacement = commandInfo[2];
        message = message.Replace(substring, replacement);
    }

    command = Console.ReadLine();
}

Console.WriteLine($"The decrypted message is: {message}");
