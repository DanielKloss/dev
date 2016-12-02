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
        List<KeyPadButton> realKeypad;
        int currentX;
        int currentY;

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

            realKeypad = new List<KeyPadButton>
            {
                new KeyPadButton(".", 1, 1),
                new KeyPadButton(".", 2, 1),
                new KeyPadButton("D", 3, 1),
                new KeyPadButton(".", 4, 1),
                new KeyPadButton(".", 5, 1),
                new KeyPadButton(".", 1, 2),
                new KeyPadButton("A", 2, 2),
                new KeyPadButton("B", 3, 2),
                new KeyPadButton("C", 4, 2),
                new KeyPadButton(".", 5, 2),
                new KeyPadButton("5", 1, 3),
                new KeyPadButton("6", 2, 3),
                new KeyPadButton("7", 3, 3),
                new KeyPadButton("8", 4, 3),
                new KeyPadButton("9", 5, 3),
                new KeyPadButton(".", 1, 4),
                new KeyPadButton("2", 2, 4),
                new KeyPadButton("3", 3, 4),
                new KeyPadButton("4", 4, 4),
                new KeyPadButton(".", 5, 4),
                new KeyPadButton(".", 1, 5),
                new KeyPadButton(".", 2, 5),
                new KeyPadButton("1", 3, 5),
                new KeyPadButton(".", 4, 5),
                new KeyPadButton(".", 5, 5)
            };
        }

        public string FindToiletCode(string[] input)
        {
            currentX = 2;
            currentY = 2;

            StringBuilder builder = new StringBuilder();

            foreach (string instruction in input)
            {
                foreach (char direction in instruction)
                {
                    switch (direction)
                    {
                        case 'U':
                            currentY = increase(currentY, 3);
                            break;
                        case 'D':
                            currentY = decrease(currentY, 1);
                            break;
                        case 'R':
                            currentX = increase(currentX, 3);
                            break;
                        case 'L':
                            currentX = decrease(currentX, 1);
                            break;
                    }
                }

                builder.Append(keypad.Single(k => k.x == currentX && k.y == currentY).value);
            }

            return builder.ToString();
        }

        private int increase(int current, int upperLimit)
        {
            if (current != upperLimit)
            {
                return ++current;
            }
            else
            {
                return current;
            }
        }

        private int decrease(int current, int lowerLimit)
        {
            if (current != lowerLimit)
            {
                return --current;
            }
            else
            {
                return current;
            }
        }

        public string FindRealToiletCode(string[] input)
        {
            currentX = 1;
            currentY = 3;

            StringBuilder builder = new StringBuilder();

            foreach (string instruction in input)
            {
                foreach (char direction in instruction)
                {
                    switch (direction)
                    {
                        case 'U':
                            currentY = increase(currentY, 5);
                            if (CheckForKeys())
                            {
                                currentY = decrease(currentY, 1);
                            }
                            break;
                        case 'D':
                            currentY = decrease(currentY, 1);
                            if (CheckForKeys())
                            {
                                currentY = increase(currentY, 5);
                            }
                            break;
                        case 'R':
                            currentX = increase(currentX, 5);
                            if (CheckForKeys())
                            {
                                currentX = decrease(currentX, 1);
                            }
                            break;
                        case 'L':
                            currentX = decrease(currentX, 1);
                            if (CheckForKeys())
                            {
                                currentX = increase(currentX, 5);
                            }
                            break;
                    }
                }

                builder.Append(realKeypad.Single(k => k.x == currentX && k.y == currentY).value);
            }

            return builder.ToString();
        }

        private bool CheckForKeys()
        {
            return realKeypad.Single(k => k.x == currentX && k.y == currentY).value == ".";
        }
    }
}
