using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Droid
    {
        public string Name;
    }

    public class Astromech : Droid
    {
        public Astromech()
        {
            Name = "R2D2";
        }
    }

    public class Protocol : Droid
    {
        public Protocol()
        {
            Name = "C3PO";
        }
    }

    public class Assassin : Droid
    {
        public Assassin()
        {
            Name = "IG-88";
        }
    }
}
