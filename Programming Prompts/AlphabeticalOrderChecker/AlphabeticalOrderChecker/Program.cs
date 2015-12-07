using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphabeticalOrderChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> testWords = new List<string>
            {
                "billowy",
                "biopsy",
                "chinos",
                "defaced",
                "chintz",
                "sponged",
                "bijoux",
                "abhors",
                "fiddle",
                "begins",
                "chimps",
                "wronged"
            };

            foreach (string word in testWords)
            {
                Console.WriteLine(word + " " + Checker.CheckWord(word).Value);
            }

            Console.ReadLine();
        }
    }
}
