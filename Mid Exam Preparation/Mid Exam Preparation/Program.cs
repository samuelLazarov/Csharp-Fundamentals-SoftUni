namespace Mid_Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int initialEnergy = int.Parse(Console.ReadLine());
            
            string command = Console.ReadLine();
            int battlesWon = 0;
            bool hasEnoughEnergy = true;


            while (command != "End of battle")
            {
                int distance = int.Parse(command);

                if (initialEnergy - distance < 0)
                {
                    
                    hasEnoughEnergy = false;
                    break;
                }

                initialEnergy -= distance;
                battlesWon++;

                if (battlesWon % 3 == 0)
                {
                    initialEnergy += battlesWon;
                }


                command = Console.ReadLine();
            }

            if (hasEnoughEnergy)
            {
                Console.WriteLine($"Won battles: {battlesWon}. Energy left: {initialEnergy}");
            }
            else
            {
                Console.WriteLine($"Not enough energy! Game ends with {battlesWon} won battles and {initialEnergy} energy");
            }

        }
    }
}