using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public abstract class CarState
    {
        public Car _car;

        public CarState(Car previousState)
        {
            _car = previousState;
        }

        public abstract void Accelerate();

        public abstract void Break();
    }

    public class OffState : CarState
    {
        public OffState(Car previousState)
            : base(previousState)
        {
            _car.speed = 0;
        }

        public override void Accelerate()
        {
            Console.WriteLine("Car is off - nothing happens");
        }

        public override void Break()
        {
            Console.WriteLine("Car is off - nothing happens");
        }
    }

    public class OnState : CarState
    {
        public OnState(Car previousState)
            : base(previousState)
        {
        }

        public override void Accelerate()
        {
            Console.WriteLine("Car Accelerating!");
            _car.speed++;
            Console.WriteLine("Car Speed: " + _car.speed);
        }

        public override void Break()
        {
            Console.WriteLine("Car Breaking!");
            _car.speed--;
            Console.WriteLine("Car Speed: " + _car.speed);
        }
    }
}
