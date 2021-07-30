using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NLog;

namespace EssentialTrainingApp
{
    class Program
    {
        public static Logger logger = LogManager.GetCurrentClassLogger();
        
        public static List<string> Words;
        static void Main(string[] args)
        {
            logger.Trace("The program started.");
            Words = new List<string>();
            Words.Add("Milk");
            Words.Add("Bread");
            Words.Add("Cheese");

            CrazyMathProblem();
            ReadTextFile();
            Console.ReadLine();
        }

        private static void ReadTextFile()
        {
            try
            {
                using (var sr = new StreamReader(@"C:\temp\test.txt"))
                {
                    string contents = sr.ReadToEnd();
                    Console.WriteLine(contents);
                }
            }
            catch (System.IO.DirectoryNotFoundException ex)
            {
                Console.WriteLine("Could not find the directory.");
                logger.Error("The directory was not found" + ex);

            }

            catch (System.IO.FileNotFoundException ex)
            {
                Console.WriteLine("Could not find the file.");
                logger.Error(ex.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine("An unknown error occured " + ex.Message);
            }

            finally
            {
                Console.WriteLine("The finally runs all the time.");
            }
        }

        private static int CrazyMathProblem()
        {
            var income = 1000;

            for (int i = 100000000; i >= 0; i--)
            {
                //income = income = (income / i); // This excercise will produce an error because it is dividing by 0
            }

            return income;
        }
    }
}
