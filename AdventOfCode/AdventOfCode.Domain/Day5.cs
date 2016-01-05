using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Domain
{
    public class Day5
    {
        List<string> naughtyStrings = new List<string> { "xy", "pq", "cd", "ab" };
        List<char> vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };

        public bool IsStringNice(string input)
        {
            if (ContainsADoubleLetter(input) && ContainsAtLeastThreeVowels(input) && !ContainsNaughtyString(input))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ContainsAtLeastThreeVowels(string input)
        {
            int vowelCounter = 0;

            foreach (char character in input)
            {
                if (vowels.Contains(character))
                {
                    vowelCounter++;
                }
            }

            if (vowelCounter >= 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ContainsADoubleLetter(string input)
        {
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == input[i - 1])
                {
                    return true;
                }
            }

            return false;
        }

        public bool ContainsNaughtyString(string input)
        {
            foreach (string naughtyString in naughtyStrings)
            {
                if (input.Contains(naughtyString))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
