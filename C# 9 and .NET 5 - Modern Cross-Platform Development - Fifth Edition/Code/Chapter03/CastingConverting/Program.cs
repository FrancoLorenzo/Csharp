using System;
using static System.Console;
using static System.Convert;

namespace CastingConverting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Casting from an integer to a double
            int a = 10;
            double b = a; // an int can be safely cast into a double
            WriteLine(b);

            double c = 9.8;
            int d = (int)c; // compiler gives an error for this line. You need to add (int) for the casting
            WriteLine(d);

            long e = 5_000_000_000;
            int f = (int)e;
            WriteLine($"e is {e:N0} and f is {f:N0}");
            e = long.MaxValue;
            f = (int)e;
            WriteLine($"e is {e:N0} and f is {f:N0}");
            
            WriteLine("------------------------");

            // Convert exercise
            double g = 9.8;
            int h = ToInt32(g);
            WriteLine($"g is {g} and h is {h}");

            WriteLine("------------------------");

            // Rounding numbers
            double[] doubles = new[]{ 9.49, 9.5, 9.51, 10.49, 10.5, 10.51 };

            WriteLine("------------------------");

            // C# uses banking rule to round numbers
            foreach (double n in doubles)
            {
                WriteLine($"ToInt({n}) is {ToInt32(n)}");
            }

            WriteLine("------------------------");

            // Take control of rounding by using AwayFromZero rounding rule
            foreach (double n in doubles)
            {
            WriteLine(format: 
                "Math.Round({0}, 0, MidpointRounding.AwayFromZero) is {1}",
                arg0: n,
                arg1: Math.Round(value: n, digits: 0, 
                        mode: MidpointRounding.AwayFromZero));
            }

            WriteLine("------------------------");

            // Converting from any type to a string
            int number = 12;
            WriteLine(number.ToString());
            bool boolean = true;
            WriteLine(boolean.ToString());
            DateTime now = DateTime.Now;
            WriteLine(now.ToString());
            object me = new object();
            WriteLine(me.ToString());

            WriteLine("------------------------");

            // Converting from a binary object to a string
            // allocate array of 128 bytes
            byte[] binaryObject = new byte[128];

            //populate array with random bytes
            (new Random()).NextBytes(binaryObject);
            WriteLine("Binary Object as bytes: ");
            for (int index = 0; index < binaryObject.Length; index++)
            {
                Write($"{binaryObject[index]:X}");
            }

            WriteLine();
            // convert to Base64 string and output as text
            string encoded = Convert.ToBase64String(binaryObject);
            WriteLine($"Binary Object as Base64: {encoded}");

            // Parsing from string to numbers or dates and times
            int age = int.Parse("30");
            DateTime birthday = DateTime.Parse("13 May 1991");
            WriteLine($"I was born {age} years ago.");
            WriteLine($"My birthday is {birthday}");
            WriteLine($"My birthday is {birthday:D}.");

            // Avoiding exception using the TryParse method
            Write("How many eggs are there?");
            int count;
            string input = ReadLine();
            if (int.TryParse(input,out count))
            {
                WriteLine($"There are {count} eggs.");
            }else
            {
                WriteLine("I could not parse the input");
            }
        }
    }
}
