internal class Program
{
    private static void Main(string[] args)
    {
        
        string input = Console.ReadLine();
        string dataType = "";

        while (input != "END")

        {
                    
            if (int.TryParse(input, out int intNumber))
             {
                dataType = "integer";
             }
            else if (float.TryParse(input, out float floatNumber))
             {
                 dataType = "floating point";
             }
            else if (bool.TryParse(input, out bool boolean))

             {
                dataType = "boolean";
             }
            else if (char.TryParse(input, out char char1))
             {
             dataType = "character";
             }
             else
             {
            dataType = "string";
              }
            Console.WriteLine($"{input} is {dataType} type");
            input = Console.ReadLine();
        }
    }
}