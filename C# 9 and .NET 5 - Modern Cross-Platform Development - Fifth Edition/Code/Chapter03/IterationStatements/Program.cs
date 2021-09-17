using System;
using static System.Console;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // While statement
            int x = 0;
            while (x < 10)
            {
                 WriteLine(x);
                 x++;
            }

            // Do while statement
            string password = string.Empty;
            int attempts = 0;
            
            do
            {
                Write("Enter your password: ");
                password = ReadLine();
                attempts++;

                if (password == "Pa$$w0rd")
                {
                    WriteLine("Correct password!");
                    break;
                }else
                {
                    WriteLine($"Your password is invalid. You only have {3 - attempts}");
                    break;
                }

            } while (attempts < 3);

            // For statements
            for (int y = 0; y <= 10; y++)
            {
                WriteLine(y);
            }

            // Foreach statement
            string[] names = { "Adam", "Barry", "Charlie"};
            foreach (string name in names)
            {
                WriteLine($"{name} has {name.Length} characters.");
            }

        }
    }
}
