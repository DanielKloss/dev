using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OffensiveWordsFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> wordsToCheck = new List<string>
            {
                "synchronized",
                "misfunctioned",
                "mispronounced",
                "shotgunned",
                "snond"
            };

            string offensiveWord = "snond";

            foreach (string word in wordsToCheck)
            {
                Console.WriteLine(word + " " + Finder.CheckWordForOffense(word, offensiveWord));
            }

            Console.ReadLine();
        }
    }
}
