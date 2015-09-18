using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Checkers
{
    public class Square
    {
        public int x { get; set; }
        public int y { get; set; }
        public string colour { get; set; }

        public Square(int X, int Y, string Colour)
        {
            x = X;
            y = Y;
            colour = Colour;
        }
    }
}
