using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public class EfficientWorker : Worker
    {
        public void Work()
        {
            Console.WriteLine("Works as much as I can");
        }

        public void Eat()
        {
            Console.WriteLine("Eat only when I have to");
        }
    }
}
