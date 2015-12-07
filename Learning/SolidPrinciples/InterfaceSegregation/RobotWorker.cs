using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public class RobotWorker : Worker
    {
        public void Work()
        {
            Console.WriteLine("I work ALL the time");
        }

        //This method will never be called - Interface Pollution
        //Split interface up into two different interfaces. Worker implements Work(), Eater implements Eat()
        public void Eat()
        {

        }
    }
}
