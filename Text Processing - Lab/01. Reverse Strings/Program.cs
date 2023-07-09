string line = string.Empty;
while ((line = Console.ReadLine()) != "end")
{
    string reversed = string.Empty;

    for (int i = line.Length - 1; i >= 0; i--)
    {
        reversed += line[i];
    }
    Console.WriteLine($"{line} = {reversed}");
}
