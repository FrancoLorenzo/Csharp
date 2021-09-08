using System; // A semicolon indicates the end of a statement
using System.Linq;
using System.Reflection;
// #error version

namespace Basics
{ // An open brace indicates the start of a block
    class Program
    {
        static void Main(string[] args)
        {
            // declare some unused variables using types
            // in additional assemblies
            System.Data.DataSet ds;
            System.Net.Http.HttpClient client;

            // // #1
            // // Comment with Ctrl + K +C
            // // Un-comment with Ctril + K + U

            // // Outputs a carriage-return
            // Console.WriteLine();

            // // Outputs the greeting and a carriage-return
            // Console.WriteLine("Hello Franco!"); // A statement

            // //Outputs a formatted number, date, and a carriage-return
            // Console.WriteLine("Temperature on {0:D} is {1}°C.", DateTime.Today, 23.4);

            // // #2
            // // loop through the assemblies that this app references 
            // foreach (var r in Assembly.GetEntryAssembly()
            // .GetReferencedAssemblies())
            // {
            // // load the assembly so we can read its details
            // var a = Assembly.Load(new AssemblyName(r.FullName));
            // // declare a variable to count the number of methods
            // int methodCount = 0;
            // // loop through all the types in the assembly
            // foreach (var t in a.DefinedTypes)
            // {
            //     // add up the counts of methods
            //     methodCount += t.GetMethods().Count();
            // }
            // // output the count of types and their methods
            // Console.WriteLine(
            //     "{0:N0} types with {1:N0} methods in {2} assembly.",
            //     arg0: a.DefinedTypes.Count(),
            //     arg1: methodCount,
            //     arg2: r.Name);
            // }

            // #3
            // Let the heighInMeters variable become equal to the value 1.88
            double heighInMeters = 1.88;
            Console.WriteLine($"The variable has the value {heighInMeters}.");

            // #4
            string firstName = "Bob"; // assign literal strings
            string lastName = "Smith";
            string phoneNumber = "(215) 555-8888";

            // Assign a string returned from a function call
            //string address = GetAddressFromDataBase(id: 563);


        }
    }
} // A close brace indicates the end of a block
