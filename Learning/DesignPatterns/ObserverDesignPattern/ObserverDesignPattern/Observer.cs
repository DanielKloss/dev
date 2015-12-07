using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    public abstract class Observer
    {
        public string Name;
        public string ObserverState;
        public Observable LoveInterest;

        public abstract void Update();
    }

    public class EligibleBachelor : Observer
    {
        public EligibleBachelor(Princess observable, string name)
        {
            LoveInterest = observable;
            Name = name;
        }

        public override void Update()
        {
            ObserverState = LoveInterest.RelationshipStatus;
            Console.WriteLine("I am {0} and I am observing {1}. Thier new relationship status is {2}", Name, LoveInterest.Name, ObserverState);
        }
    }
}
