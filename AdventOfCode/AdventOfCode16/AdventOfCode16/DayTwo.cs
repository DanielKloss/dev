using System.Collections.Generic;
using System.Linq;
using System.Text;

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
                new KeyPadButton("1", 1, 3), new KeyPadButton("2", 2, 3), new KeyPadButton("3", 3, 3),
                new KeyPadButton("4", 1, 2), new KeyPadButton("5", 2, 2), new KeyPadButton("6", 3, 2),
                new KeyPadButton("7", 1, 1), new KeyPadButton("8", 2, 1), new KeyPadButton("9", 3, 1)
            };

            realKeypad = new List<KeyPadButton>
            {
                new KeyPadButton(".", 1, 5), new KeyPadButton(".", 2, 5), new KeyPadButton("1", 3, 5), new KeyPadButton(".", 4, 5), new KeyPadButton(".", 5, 5),
                new KeyPadButton(".", 1, 4), new KeyPadButton("2", 2, 4), new KeyPadButton("3", 3, 4), new KeyPadButton("4", 4, 4), new KeyPadButton(".", 5, 4),
                new KeyPadButton("5", 1, 3), new KeyPadButton("6", 2, 3), new KeyPadButton("7", 3, 3), new KeyPadButton("8", 4, 3), new KeyPadButton("9", 5, 3),
                new KeyPadButton(".", 1, 2), new KeyPadButton("A", 2, 2), new KeyPadButton("B", 3, 2), new KeyPadButton("C", 4, 2), new KeyPadButton(".", 5, 2),
                new KeyPadButton(".", 1, 1), new KeyPadButton(".", 2, 1), new KeyPadButton("D", 3, 1), new KeyPadButton(".", 4, 1), new KeyPadButton(".", 5, 1)
            };
        }

        public string FindToiletCode(string[] input)
        {
            currentX = 2;
            currentY = 2;

            StringBuilder builder = new StringBuilder();

            FindKeys(input, builder, keypad);

            return builder.ToString();
        }

        public string FindRealToiletCode(string[] input)
        {
            currentX = 1;
            currentY = 3;

            StringBuilder builder = new StringBuilder();

            FindKeys(input, builder, realKeypad);

            return builder.ToString();
        }

        private void FindKeys(string[] input, StringBuilder builder, List<KeyPadButton> keypad)
        {
            foreach (string instruction in input)
            {
                foreach (char direction in instruction)
                {
                    KeyPadButton key;

                    switch (direction)
                    {
                        case 'U':
                            key = keypad.SingleOrDefault(k => k.x == currentX && k.y == currentY + 1);
                            if (key != null && key.value != ".")
                            {
                                currentY++;
                            }
                            break;
                        case 'D':
                            key = keypad.SingleOrDefault(k => k.x == currentX && k.y == currentY - 1);
                            if (key != null && key.value != ".")
                            {
                                currentY--;
                            }
                            break;
                        case 'R':
                            key = keypad.SingleOrDefault(k => k.x == currentX + 1 && k.y == currentY);
                            if (key != null && key.value != ".")
                            {
                                currentX++;
                            }
                            break;
                        case 'L':
                            key = keypad.SingleOrDefault(k => k.x == currentX - 1 && k.y == currentY);
                            if (key != null && key.value != ".")
                            {
                                currentX--;
                            }
                            break;
                    }
                }

                builder.Append(keypad.Single(k => k.x == currentX && k.y == currentY).value);
            }
        }
    }
}
