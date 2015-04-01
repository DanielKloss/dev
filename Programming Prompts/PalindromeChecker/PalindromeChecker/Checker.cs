using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PalindromeChecker
{
    public class Checker
    {
        public bool CheckWord(string word)
        {
            int wordLength = word.Length - 1;

            if (wordLength == 0)
            {
                return false;
            }

            for (int i = 0; i <= wordLength; i++)
            {
                if (word[i] != word[wordLength - i])
                {
                    return false;
                }

                if (i >= wordLength / 2)
                {
                    return true;
                }
            }

            return false;
        }

        public List<string> CheckText(string text)
        {
            List<string> words = RemoveSpecialCharacters(text).Split(' ').ToList();
            List<string> palindromicWords = new List<string>();

            foreach (string word in words)
            {
                if (CheckWord(word))
                {
                    palindromicWords.Add(word);
                }
            }

            return palindromicWords;
        }

        public List<string> CheckFile(string fileLocation)
        {
            string text = string.Empty;

            try
            {
                using (StreamReader sr = new StreamReader(fileLocation))
                {
                    text = sr.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return CheckText(text);
        }

        public string RemoveSpecialCharacters(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if (char.IsLetter(c) || c == ' ')
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
    }
}
