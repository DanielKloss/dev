using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Domain
{
    public class Day2
    {
        public int squareFeet { get; set; }
        public int slack { get; set; }
        public int squareFeetNeeded { get; set; }
        public int ribbon { get; set; }
        public int ribbonBow { get; set; }
        public int ribbonNeeded { get; set; }

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

        public void FindRibbonNeeded(int height, int width, int length)
        {
            List<int> sides = new List<int>() {height, width, length};
            int shortestSide = sides.Min();
            sides.Remove(sides.Min());
            int secondShortestSide = sides.Min();
            ribbon = (shortestSide * 2) + (secondShortestSide * 2);
            ribbonBow = height * width * length;

            ribbonNeeded += ribbon + ribbonBow;
        }
    }
}