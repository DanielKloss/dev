using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Princess princess = new Princess();
            EligibleBachelor a = new EligibleBachelor(princess, "Prince");
            EligibleBachelor b = new EligibleBachelor(princess, "Knight");
            EligibleBachelor c = new EligibleBachelor(princess, "Dragon");

            princess.Attach(a);
            princess.Attach(b);
            princess.Attach(c);

            princess.RelationshipStatus = "Single";
            princess.Notify();

            Console.ReadKey();

            princess.Detach(c);

            princess.RelationshipStatus = "In a Relationship";
            princess.Notify();

            Console.ReadKey();
        }
    }
}
