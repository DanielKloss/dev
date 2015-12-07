using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Checkers
{
    public class Board : INotifyPropertyChanged
    {
        public List<Square> squares { get; set; }

        private List<Piece> _pieces;
        public List<Piece> pieces
        {
            get { return _pieces; }
            set
            {
                _pieces = value;
                onPropertyChanged("pieces");
            }
        }

        public Board()
        {
            squares = new List<Square>();
            pieces = new List<Piece>();

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    AddSquare(i, j);
                    AddPiece(i, j);
                }
            }
        }

        private void AddSquare(int i, int j)
        {
            Square newSquare;

            if (j % 2 == 0 && i % 2 != 0)
            {
                newSquare = new Square(i, j, "Black");
            }
            else if (j % 2 == 0 && i % 2 == 0)
            {
                newSquare = new Square(i, j, "White");
            }
            else if (j % 2 != 0 && i % 2 == 0)
            {
                newSquare = new Square(i, j, "Black");
            }
            else
            {
                newSquare = new Square(i, j, "White");
            }

            squares.Add(newSquare);
        }

        private void AddPiece(int i, int j)
        {
            if ((j % 2 == 0 && i % 2 == 0) || (j % 2 != 0 && i % 2 != 0))
            {
                if (i <= 2)
                {
                    pieces.Add(new Piece(i, j, "Black"));
                }
                else if (i >= 5)
                {
                    pieces.Add(new Piece(i, j, "White"));
                }
            }
        }

        public void CanSingleMove(Piece piece)
        {
            if (piece.colour == "Black")
            {
                int newX = piece.x + 1;
                int newY = piece.y + 1;

                if (pieces.Where<Piece>(p => p.x == newX && p.y == newY).FirstOrDefault<Piece>() == null)
                {
                    piece.x = newX;
                    piece.y = newY;
                }
            }
            else
            {
                int newX = piece.x - 1;
                int newY = piece.y - 1;

                if (pieces.Where<Piece>(p => p.x == newX && p.y == newY).FirstOrDefault<Piece>() == null)
                {
                    piece.x = newX;
                    piece.y = newY;
                }
            }
        }

        #region INPC
        private void onPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
    }
}
