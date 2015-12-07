using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public class Car
    {
        public int speed = 0;

        CarState carState;

        public Car()
        {
            carState = new OffState(this);
        }

        public void TurnKey()
        {
            if (carState.GetType() == typeof(OffState))
            {
                carState = new OnState(this);
                Console.WriteLine("Brrruummmm! Car is On");
            }
            else
            {
                carState = new OffState(this);
                Console.WriteLine("Car is off");
            }
        }

        public void Accelerate()
        {
            carState.Accelerate();
        }

        public void Break()
        {
            carState.Break();
        }
    }
}
