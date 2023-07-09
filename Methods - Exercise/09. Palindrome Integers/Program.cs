
while (true)
{
    string input = Console.ReadLine()!;
    if (input == "END")
    {
        break;
    }
    string reversedInput = string.Empty;
    char[] charArray = input.ToCharArray();
    for (int i = charArray.Length - 1; i > -1; i--)
    {
        reversedInput += charArray[i];
    }

    Console.WriteLine(IsPalindrome(input, reversedInput));
       
}

bool IsPalindrome(string input, string reversedInput)
{
    bool isPalindrome = true;
    int number1 = int.Parse(input);
    int number2 = int.Parse(reversedInput);


    if (number1 != number2)
    {
       isPalindrome = false;
    }
    return isPalindrome;
}