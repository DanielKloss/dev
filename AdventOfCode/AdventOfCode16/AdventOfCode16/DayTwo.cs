using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode16.Domain
{
    public class KeyPadButton
    {
        public string value;
        public int x;
        public int y;

        public KeyPadButton(string Value, int X, int Y)
        {
            value = Value;
            x = X;
            y = Y;
        }
    }

    public class DayTwo
    {
        List<KeyPadButton> keypad;
        int currentX = 2;
        int currentY = 2;

        public DayTwo()
        {
            keypad = new List<KeyPadButton>
            {
                new KeyPadButton("1", 1, 3),
                new KeyPadButton("2", 2, 3),
                new KeyPadButton("3", 3, 3),
                new KeyPadButton("4", 1, 2),
                new KeyPadButton("5", 2, 2),
                new KeyPadButton("6", 3, 2),
                new KeyPadButton("7", 1, 1),
                new KeyPadButton("8", 2, 1),
                new KeyPadButton("9", 3, 1)
            };
        }

        public string FindToiletCode(string[] input)
        {
            StringBuilder builder = new StringBuilder();

            foreach (string instruction in input)
            {
                foreach (char direction in instruction)
                {
                    switch (direction)
                    {
                        case 'U':
                            currentY = increase(currentY);
                            break;
                        case 'D':
                            currentY = decrease(currentY);
                            break;
                        case 'R':
                            currentX = increase(currentX);
                            break;
                        case 'L':
                            currentX = decrease(currentX);
                            break;
                    }
                }

                builder.Append(keypad.Single(k => k.x == currentX && k.y == currentY).value);
            }

            return builder.ToString();
        }

        private int increase(int current)
        {
            if (current != 3)
            {
                return ++current;
            }
            else
            {
                return current;
            }
        }

        private int decrease(int current)
        {
            if (current != 1)
            {
                return --current;
            }
            else
            {
                return current;
            }
        }
    }
}
