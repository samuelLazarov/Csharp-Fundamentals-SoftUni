﻿string input = Console.ReadLine();
string[] names = input.Split(", ");

foreach (var name in names)
{
    if (IsUserNameValid(name))
    {
        Console.WriteLine(name);
    }
}

bool IsUserNameValid(string name)
{
    //check length

    if (name.Length < 3 || name.Length > 16)
    {
        return false;
    }
    

    foreach (var character in name)
    {
        if (character != '_' && character != '-' 
            && ((character < 'a' || character > 'z')) 
            && (character < 'A' || character > 'Z')
                && (character < '0' || character > '9'))

        {
            return false;
        }
    }

    return true;
}