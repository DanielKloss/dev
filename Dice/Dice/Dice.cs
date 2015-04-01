using System;
using System.Collections.Generic;

namespace Dice
{
    public abstract class Dice
    {
        protected readonly Random Random = new Random();
        protected readonly int Sides;
        protected readonly List<SymbolicDiceFace> Faces;

        internal bool Held { get; set; }
        internal int Value { get; set; }

        protected Dice(List<SymbolicDiceFace> faces)
        {
            Faces = faces;
        }
        
        protected Dice(int sides)
        {
            Sides = sides;
        }

        public abstract void Roll();

        protected void Hold()
        {
            Held = true;
        }

        protected void Unhold()
        {
            Held = false;
        }
    }
}
