using System;
using System.IO;
using System.Xml;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // object height = 1.74; // storing a double in an object
            // object name = "Franco"; // storing a string in an object

            // Console.WriteLine($"{name} is {height} meters tall.");

            // //int lenght1 = name.Lenght; // it gives a compile error
            // int lenght2 = ((string)name).Length; // it tells the compiler it is a string

            // Console.WriteLine($"{name} has {lenght2} characters.");

            // // Storing a string in a dynamic object
            // dynamic anotherName = "Esteban";

            // This compiles but would throw an exception at run-time
            // If you later store a data type that does not have a property names Lenght
            // int lenght = anotherName.Lenght;

            // Warms the variables are declared but never used.
            // int population = 66_000_000; // 66 million in UK 
            // double weight = 1.88; // in kilograms
            // decimal price = 4.99M; // in pounds sterling
            // string fruit = "Apples"; // strings use double-quotes
            // char letter = 'Z'; // chars use single-quotes
            // bool happy = true; // Booleans have value of true or false

            // var population = 66_000_000; // 66 million in UK 
            // var weight = 1.88; // in kilograms
            // var price = 4.99M; // in pounds sterling
            // var fruit = "Apples"; // strings use double-quotes 
            // var letter = 'Z'; // chars use single-quotes
            // var happy = true; // Booleans have value of true or false

            // // Good use of var because it avoids the repeated type
            // // as shown in the more verbose second statement
            // var xml1 = new XmlDocument();
            // XmlDocument xml2 = new XmlDocument();
            // XmlDocument xml3 = new();

            // // Bad use of var because we cannot tell the type, so we 
            // // should use a specific type declaration as shown in
            // // the second statement
            // var file1 = File.CreateText(@"C:\something.txt");
            // StreamWriter file2 = File.CreateText(@"C:\something.txt");

            Console.WriteLine($"default(int) = {default(int)}");
            Console.WriteLine($"default(bool) = {default(bool)}");
            Console.WriteLine(
            $"default(DateTime) = {default(DateTime)}");
            Console.WriteLine(
            $"default(string) = {default(string)}");
        }
    }
}
