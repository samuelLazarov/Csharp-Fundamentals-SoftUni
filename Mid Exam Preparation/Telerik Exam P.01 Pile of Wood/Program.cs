namespace Telerik_Exam_P._01_Pile_of_Wood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int height = 0;
            int rows = 0;
                        
            for (int i = 1; i <= n; i++)
            {
               for (int j = 1; j <= i; j++)
               {
                 rows++;
               }
               height++;
              
                if (height + rows >= n)
                {
                    break;
                }
 
            }
            Console.WriteLine(height);

        }
    }
}