using System;
using static System.Console;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = a++;
            int c = 3;
            int d = ++c; // increment c before assigning it
            int e = 11;
            int f = 3;
            double g = 11.0;
            int p = 6;

            // Unary operators
            WriteLine($"a is {a}, b is {b}");
            WriteLine($"c is {c}, d is {d}");
            WriteLine("------------------------");

            // Binary arithmetic operators
            WriteLine($"e is {e}, f is {f}");
            WriteLine($"e + f = {e + f}");
            WriteLine($"e - f = {e - f}");
            WriteLine($"e * f = {e * f}");
            WriteLine($"e / f = {e / f}");
            WriteLine($"e % f = {e % f}");
            WriteLine("------------------------");
            WriteLine($"g is {g:N1}, f is {f}");
            WriteLine($"g / f = {g / f}");
            WriteLine("------------------------");

            // Assignment operators
            p += 3; // equivalent to p = p + 3;
            p -= 3; // equivalent to p = p - 3;
            p *= 3; // equivalent to p = p * 3;
            p /= 3; // equivalent to p = p / 3;

        }
    }
}
