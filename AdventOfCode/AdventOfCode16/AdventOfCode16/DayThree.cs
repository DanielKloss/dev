﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode16.Domain
{
    public class DayThree
    {
        public int CheckTriangles(string[] input)
        {
            int triangleCount = 0;

            foreach (string triange in input)
            {
                List<int> sides = new List<int>();

                sides.Add(Convert.ToInt32(triange.Substring(0, 5).Trim(' ')));
                sides.Add(Convert.ToInt32(triange.Substring(5, 5).Trim(' ')));
                sides.Add(Convert.ToInt32(triange.Substring(10, 5).Trim(' ')));

                if (sides[0] + sides[1] <= sides[2])
                {
                    continue;
                }
                else if (sides[1] + sides[2] <= sides[0])
                {
                    continue;
                }
                else if (sides[2] + sides[0] <= sides[1])
                {
                    continue;
                }

                triangleCount++;
            }

            return triangleCount;
        }

        public int CheckTrianglesVertically(string[] input)
        {
            int triangleCount = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < input.Length; j += 3)
                {
                    List<int> sides = new List<int>();

                    for (int k = 0; k < 3; k++)
                    {
                        sides.Add(Convert.ToInt32(input[j + k].Substring(5 * i, 5)));
                    }

                    if (sides[0] + sides[1] <= sides[2])
                    {
                        continue;
                    }
                    else if (sides[1] + sides[2] <= sides[0])
                    {
                        continue;
                    }
                    else if (sides[2] + sides[0] <= sides[1])
                    {
                        continue;
                    }

                    triangleCount++;
                }
            }

            return triangleCount;
        }
    }
}
