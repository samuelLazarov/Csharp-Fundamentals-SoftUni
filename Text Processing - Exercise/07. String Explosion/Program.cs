using System.Text;

string input = Console.ReadLine();

StringBuilder output = new StringBuilder();

int explosionStrength = 0;

for (int i = 0; i < input.Length; i++)
{
    if (input[i] == '>')
    {
        explosionStrength += int.Parse(input[i+1].ToString());
        output.Append(input[i]);

    }
    else if (explosionStrength > 0)
    {
        explosionStrength--;
    }
    else
    {
        output.Append(input[i]);
    }
}

Console.WriteLine(output.ToString());