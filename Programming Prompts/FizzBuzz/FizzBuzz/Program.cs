using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzzer fizzBuzzer = new FizzBuzzer();

            for (int i = 1; i <= 100; i++)
            {
                string result = fizzBuzzer.Check(i);
                Console.WriteLine(result);
            }

            Console.ReadLine();
        }
    }
}
