using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFactory
{
    static class Factory
    {
        public static Droid Get(string droidType)
        {
            switch (droidType)
            {
                case "Protocol":
                    return new Protocol();
                case "AstroMech":
                    return new AstroMech();
                case "Assassin":
                    return new Assassin();
                default:
                    throw new Exception();
            }
        }
    }
}
