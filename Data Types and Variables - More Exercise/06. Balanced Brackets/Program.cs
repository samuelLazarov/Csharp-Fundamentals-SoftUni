using System.Threading.Channels;

internal class Program
{
    private static void Main(string[] args)
    {
        int.TryParse(Console.ReadLine(), out int n);
        string input = string.Empty;
        bool isOpened = false;
        bool  isClosed = true;


        for (int i = 0; i < n; i++)
        {
            input = Console.ReadLine();

            if (input == "(")
            {
                if (!isOpened)
                {
                    isOpened = true;
                }
                else
                {
                    isClosed = false;
                }
                
            }

            else if (input == ")")
            {
                
                if (isOpened)
                {
                    isOpened = false;
                }
                else
                {
                    isClosed = false;
                }
                 
            }

                        
        }

        if (isClosed && !isOpened)
        {
            Console.WriteLine("BALANCED");
        }
        else
        {
            Console.WriteLine("UNBALANCED");
        }

       
    }
}