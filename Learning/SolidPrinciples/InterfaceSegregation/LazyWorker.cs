using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public class LazyWorker : Worker
    {
        public void Work()
        {
            Console.WriteLine("Work only when Im being watched");
        }

        public void Eat()
        {
            Console.WriteLine("Eat whenever I feel like it");
        }
    }
}
