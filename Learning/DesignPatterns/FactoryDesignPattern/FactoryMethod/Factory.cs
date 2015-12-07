using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class DroidFactory
    {
        public abstract Droid FactoryMethod();
    }

    public class AstromechFactory : DroidFactory
    {
        public override Droid FactoryMethod()
        {
            Droid droid = new Astromech();
            return droid;
        }
    }

    public class ProtocolFactory : DroidFactory
    {
        public override Droid FactoryMethod()
        {
            Droid droid = new Protocol();
            return droid;
        }
    }

    public class AssassinFactory : DroidFactory
    {
        public override Droid FactoryMethod()
        {
            Droid droid = new Assassin();
            return droid;
        }
    }
}
