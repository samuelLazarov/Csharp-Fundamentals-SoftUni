internal class Program
{
    private static void Main(string[] args)
    {
        string userName = Console.ReadLine();
        string expectedPassword = new string(userName.Reverse().ToArray());
        int loginAttempts = 0;
        
        while (true)
        {
            string providedPassword = Console.ReadLine();
            if (providedPassword == expectedPassword)
            {
                Console.WriteLine($"User {userName} logged in.");
                return;
            }
            else
            {
                loginAttempts++;
                Console.WriteLine($"Incorrect password. Try again.");
            }

            if (loginAttempts == 3)
            {
                Console.WriteLine($"User {userName} blocked!");
                break;
            }


        }
          
    }
}