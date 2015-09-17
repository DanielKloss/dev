using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Checkers
{
    public class Board
    {
        public List<Square> squares { get; set; }

        public Board()
        {
            squares = new List<Square>();

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Square newSquare;

                    if (j % 2 == 0 && i % 2 != 0)
                    {
                        newSquare = new Square(i, j, new SolidBrush(Color.Black));

                        if (i <= 2)
                        {
                            newSquare.piece = new Piece(new SolidBrush(Color.Black));
                        }
                    }
                    else if (j % 2 == 0 && i % 2 == 0)
                    {
                        newSquare = new Square(i, j, new SolidBrush(Color.White));

                        if (i >= 5)
                        {
                            newSquare.piece = new Piece(new SolidBrush(Color.White));
                        }
                    }
                    else if (j % 2 != 0 && i % 2 == 0)
                    {
                        newSquare = new Square(i, j, new SolidBrush(Color.Black));

                        if (i <= 2)
                        {
                            newSquare.piece = new Piece(new SolidBrush(Color.Black));
                        }
                    }
                    else
                    {
                        newSquare = new Square(i, j, new SolidBrush(Color.White));

                        if (i >= 5)
                        {
                            newSquare.piece = new Piece(new SolidBrush(Color.White));
                        }
                    }

                    squares.Add(newSquare);
                }
            }
        }
    }
}
