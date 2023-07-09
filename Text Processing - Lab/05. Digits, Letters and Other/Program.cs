string text = Console.ReadLine();

Console.WriteLine(string.Join("", text.Where(char.IsDigit)));
Console.WriteLine(string.Join("", text.Where(char.IsLetter)));
Console.WriteLine(string.Join("", text.Where(x => !char.IsLetter(x) && !char.IsDigit(x))));




