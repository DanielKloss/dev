using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimeMinister pm = PrimeMinister.Instance;

            Console.WriteLine(pm.Name);
            Console.ReadLine();

            pm.Name = "Daniel Kloss";
            Console.WriteLine(pm.Name);
            Console.ReadLine();

            //PrimeMinister.Instance = new PrimeMinister();
            //pm = new PrimeMinister();
        }
    }
}
