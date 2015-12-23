using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Domain
{
    public class DayTwo
    {
        public int squareFeet { get; set; }
        public int slack { get; set; }
        public int squareFeetNeeded { get; set; }

        public void FindSquareFeetNeeded(int height, int width, int length)
        {
            int sideOne = length * width;
            int sideTwo = width * height;
            int sideThree = height * length;
            List<int> sides = new List<int>() { sideOne, sideTwo, sideThree };

            squareFeet = (2 * sideOne) + (2 * sideTwo) + (2 * sideThree);
            slack = sides.Min();
            squareFeetNeeded += squareFeet + slack;
        }
    }
}