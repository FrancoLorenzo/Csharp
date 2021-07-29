using System;
using System.Text;

namespace _2_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Comment: Working with strings
            var stringOne = "Hello ";
            var stringTwo = "this section covers ";
            var stringThreee = "working with strings.";

            var sentence = stringOne + stringTwo + stringThreee;
            
            Console.WriteLine(sentence);

            // Working with string builder method
            StringBuilder sb = new StringBuilder("");
            sb.Append("It was the best of times, it was the worst of times");
            sb.Append("It was the age of wisdom");
            sb.Append("It was the age of foolishness");
            sb.ToString();

            Console.WriteLine(sb);

            // String format
            var city = "Dallas";
            var temperature = 103.4f;
            var currentDt = DateTime.Now;
            Console.WriteLine(string.Format($"Welcome to {{0}}. The time is {{1}}. The temperature is {{2}}", city, temperature, currentDt));

            // Parsing strings as numbers
            var test = "15,234";
            int.Parse(test.Replace(",", ""));

            Console.WriteLine(test);

            int result;
            int.TryParse("15,234", out result); // This test will fail due to the ,
            
            Console.WriteLine(result);

            int.TryParse("15234", out result); // This test will sucess after removing the ,

            Console.WriteLine(result);

            // Working with dates and times
            var birthday = new DateTime(1991, 05, 13);
            var difference = DateTime.Now - birthday;
            var days = difference.Days;

            Console.WriteLine("I have been on Earth for {0} days.", days);

            var someTime = new DateTime(2017, 10, 18, 9, 51, 32);
            Console.WriteLine(someTime);

            someTime = someTime.AddDays(5);
            Console.WriteLine(someTime);

        }
    }
}
