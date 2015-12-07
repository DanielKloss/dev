using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFactory
{
    abstract class Droid
    {
        public string Name;
    }

    class Protocol : Droid
    {
        public Protocol()
        {
            Name = "C3PO";
        }
    }

    class AstroMech : Droid
    {
        public AstroMech()
        {
            Name = "R2D2";
        }
    }

    class Assassin : Droid
    {
        public Assassin()
        {
            Name = "IG-88";
        }
    }
}
