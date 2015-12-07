using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OffensiveWordsFinder
{
    public static class Finder
    {
        public static bool CheckWordForOffense(string input, string offensiveWord)
        {
            //Put word into an array of characters
            char[] letters = input.ToCharArray();

            //Find all characters in the word that also appear in the offensive word
            char[] offensiveLettersFound = letters.Where(c => offensiveWord.Contains(c)).ToArray();

            //Convert the charactersfound into a word
            string offensiveWordFound = string.Concat(offensiveLettersFound);

            //Check if that word is offensive
            if (offensiveWordFound == offensiveWord)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
