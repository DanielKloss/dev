using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            Console.WriteLine("Type what you want to do:");
            Console.WriteLine("- Turn Key");
            Console.WriteLine("- Accelerate");
            Console.WriteLine("- Break");
            Console.WriteLine("Or type anything else to quit.");

            while (true)
            {
                string input = Console.ReadLine();

                switch (input)
                {
                    case "turn key":
                        car.TurnKey();
                        break;
                    case "accelerate":
                        car.Accelerate();
                        break;
                    case "break":
                        car.Break();
                        break;
                    default:
                        return;
                }
            }
        }
    }
}
