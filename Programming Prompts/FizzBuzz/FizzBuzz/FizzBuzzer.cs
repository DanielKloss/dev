using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzer
    {
        string fizzBuzz = "FizzBuzz";
        string fizz = "Fizz";
        string buzz = "Buzz";

        public string Check(int input)
        {
            string output;

            if (input % 15 == 0)
            {
                output = fizzBuzz;
            }
            else if (input % 3 == 0)
            {
                output = fizz;
            }
            else if (input % 5 == 0)
            {
                output = buzz;
            }
            else
            {
                output = input.ToString();
            }

            return output;
        }
    }
}
