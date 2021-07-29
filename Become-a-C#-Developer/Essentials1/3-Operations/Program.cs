using System;

namespace _3_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Working witrh numbers and operations
            var test = 5;
            Console.WriteLine(5+5);
            Console.WriteLine(test - 5);
            Console.WriteLine(test * 2);
            Console.WriteLine(test + 1);
            Console.WriteLine(test += 1);
            Console.WriteLine(test -= 1);
            Console.WriteLine(test++);
            Console.WriteLine(test--);
            
            Console.WriteLine(Math.Pow(5, 2));
            Console.WriteLine(Math.Round(5.2));
            Console.WriteLine(Math.Floor(5.8));
            Console.WriteLine(Math.Ceiling(5.8));

            Console.WriteLine("test");
            
            
        }
    }
}
