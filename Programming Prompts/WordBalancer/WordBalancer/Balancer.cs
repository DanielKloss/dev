using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordBalancer
{
    public class Result
    {
        public int balancePoint { get; set; }
        public string weight { get; set; }
    }

    public class Balancer
    {
        int balanceLetter = 1;
        char[] letters;
        Result result;

        public string word;

        List<char> alphabet = new List<char> 
        { 
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' 
        };

        public Result CheckWord()
        {
            balanceLetter = 1;
            letters = word.ToCharArray();
            result = null;

            while (result == null)
            {
                int left = 0;
                int right = 0;

                for (int i = 0; i <= balanceLetter - 1; i++)
                {
                    left += CalculateWeight(i);
                }

                for (int i = balanceLetter + 1; i < letters.Length; i++)
                {
                    right += CalculateWeight(i);
                }

                CheckBalance(left, right);
            }

            return result;
        }

        private void CheckBalance(int left, int right)
        {
            if (right == left)
            {
                result = new Result { weight = right.ToString(), balancePoint = balanceLetter };
            }
            else if (balanceLetter > letters.Length / 2)
            {
                result = new Result { weight = "DOES NOT BALANCE" };
            }
            else
            {
                balanceLetter++;
            }
        }

        private int CalculateWeight(int i)
        {
            int weight = alphabet.FindIndex(c => c == letters[i]) + 1;
            int distanceFromBalance = Math.Abs(i - balanceLetter);
            return weight * distanceFromBalance;
        }
    }
}
