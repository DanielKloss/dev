using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    public class Soldier
    {
        public void Action(string message)
        {
            Console.WriteLine("Soldier's action called with message: {0}", message);
            Console.ReadLine();
        }
    }
}
