using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;

namespace Checkers
{
    public class Square
    {
        public int x { get; set; }
        public int y { get; set; }
        public Brush colour { get; set; }
        public Piece piece { get; set; }

        public Square(int X, int Y, Brush Colour)
        {
            x = X;
            y = Y;
            colour = Colour;
        }
    }
}
