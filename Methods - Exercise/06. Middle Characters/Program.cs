string input = Console.ReadLine();
string result = string.Empty;

Console.WriteLine(GetMiddleString(input));


string GetMiddleString(string input)
{
    if (input.Length % 2 == 0)
    {
        result = input[input.Length / 2 - 1].ToString() + input[input.Length / 2].ToString();
    }
    else
    {
        result = input[input.Length / 2].ToString();
    }
    return result;
}


