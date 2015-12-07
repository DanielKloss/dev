using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordBalancer
{
    class Program
    {
        static void Main()
        {
            List<string> testList = new List<string>
            {
                "STEAD",
                "CONSUBSTANTIATION",
                "WRONGHEADED",
                "UNINTELLIGIBILITY",
                "SUPERGLUE",
                "DANIEL",
                "DAN",
                "DANNY",
                "GEORGINA",
                "ARSENAL",
                "AGRICOLA",
                "PANDEMIC",
                "FLUXX",
                "LIBERTALIA",
                "PREMIERSHIP",
                "ENGLAND",
                "UNITEDKINGDOM",
                "EUROPE",
                "WORLD"
            };

            Balancer balancer = new Balancer();

            foreach (string word in testList)
            {
                balancer.word = word;
                Result result = balancer.CheckWord();
                Console.WriteLine(word + " - " + result.weight);
            }

            Console.ReadLine();
        }
    }
}
