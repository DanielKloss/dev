using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    public abstract class Observable
    {
        public string Name;
        public string RelationshipStatus;

        public List<Observer> _observers = new List<Observer>();

        public void Attach(Observer observer)
        {
            _observers.Add(observer);
            Console.WriteLine(observer.Name + " is observing " + observer.LoveInterest.Name);
        }

        public void Detach(Observer observer)
        {
            _observers.Remove(observer);
            Console.WriteLine(observer.Name + " is not longer observing " + observer.LoveInterest.Name);
        }

        public void Notify()
        {
            foreach (Observer o in _observers)
            {
                o.Update();
            }
        }
    }

    public class Princess : Observable
    {
        public Princess()
        {
            Name = "Princess";
        }
    }
}
