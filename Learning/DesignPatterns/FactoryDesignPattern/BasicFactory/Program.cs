using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Droid droid;

            droid = Factory.Get("AstroMech");
            PrintDroid(droid);

            droid = Factory.Get("Protocol");
            PrintDroid(droid);

            droid = Factory.Get("Assassin");
            PrintDroid(droid);
        }

        private static void PrintDroid(Droid droid)
        {
            Console.WriteLine("Droid Type = {0}, Droid Name = {1} ", droid.GetType().Name, droid.Name);
            Console.ReadLine();
        }
    }
}
