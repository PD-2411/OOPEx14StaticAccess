using StaticClassDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string quote = CustomPrinter.QuoteIt("640k ought to be enough memory for anyone", "Bill Gate");

            Console.WriteLine(quote);

            Console.WriteLine(CustomPrinter.CountVowel("What's up everybody ? Welcome back to channel. Hi ! How are ya !" +
                "?"));

            Console.WriteLine(CustomPrinter.UpperLower("What's up everybody ? Welcome back to channel. Hi ! How are ya !" +
                "?"));

            do
            {
                Console.WriteLine("Specify a size to a count");
                long a = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Specify test type. 1 StringBuilder 2 Concetentation");
                int testType = Convert.ToInt32(Console.ReadLine());

                long result = CustomPrinter.StringBuildTest(a, testType == 1 ?
                    CustomPrinter.StringBuilding.StringBuilder : CustomPrinter.StringBuilding.Conatenation);

                Console.WriteLine("The result is " + result + " milliseconds");

                Console.WriteLine("Go again ? y/n");

            } while (Console.ReadLine().ToLower() != "n");
            Console.ReadLine();
        }
    }
}
