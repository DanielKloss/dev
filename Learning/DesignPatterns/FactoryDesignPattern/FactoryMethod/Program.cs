using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Droid droid;
            DroidFactory factory;

            factory = new AstromechFactory();
            droid = factory.FactoryMethod();
            PrintDroid(droid);

            factory = new ProtocolFactory();
            droid = factory.FactoryMethod();
            PrintDroid(droid);

            factory = new AssassinFactory();
            droid = factory.FactoryMethod();
            PrintDroid(droid);
        }

        private static void PrintDroid(Droid droid)
        {
            Console.WriteLine("Droid Type = {0}, Droid Name = {1} ", droid.GetType().Name, droid.Name);
            Console.ReadLine();
        }
    }
}
