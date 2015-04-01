using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCounter
{
    public class Counter
    {
        public Dictionary<Char, int> Count(string characters)
        {
            Dictionary<Char, int> listOfCharacters = new Dictionary<Char, int>();

            if (characters != null)
            {
                string formattedCharacters = characters.ToLower();

                foreach (Char character in formattedCharacters)
                {
                    if (listOfCharacters.ContainsKey(character))
                    {
                        listOfCharacters[character]++;
                    }
                    else
                    {
                        listOfCharacters.Add(character, 1);
                    }
                }
            }

            return listOfCharacters;
        }
    }
}
