﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FindPi
{
    public static class CircleScanner
    {
        public static double ScanCircle(string imagePath)
        {
            Bitmap circle = (Bitmap)Image.FromFile(imagePath, true);
            double area = 0;
            double radius = 0;

            int leftMost = circle.Width;
            int rightMost = 0;

            //Count Pixels To Get Circle Area
            for (int i = 0; i < circle.Width; i++)
            {
                for (int j = 0; j < circle.Height; j++)
                {
                    //If Pixel Is Black
                    if (circle.GetPixel(i, j).R == 0)
                    {
                        area += 1;

                        //If the current black pixel is further to the left then save it as the left most pixel
                        if (i < leftMost)
                        {
                            leftMost = i;
                        }

                        //If the current black pixel is further to the right then save it as the right most pixel
                        if (i > rightMost)
                        {
                            rightMost = i;
                        }
                    }
                }
            }

            //Get the radius
            radius = (rightMost - leftMost) / 2;

            //Calculate Pi
            return area / Math.Pow(radius, 2);
        }
    }
}
