using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using Checkers;
using System.Windows.Input;
using CalculatorConsole;

namespace Gui
{
    public class ViewModel : INotifyPropertyChanged
    {
        private Board _board;
        public Board board
        {
            get { return _board; }
            set 
            {
                _board = value;
                onPropertyChanged("board");
            }
        }

        private ICommand _pieceSingleMoveCommand;
        public ICommand pieceSingleMoveCommand
        {
            get
            {
                if (_pieceSingleMoveCommand == null)
                {
                    _pieceSingleMoveCommand = new Command<Piece>(SingleMove, CanSingleMove);
                }
                return _pieceSingleMoveCommand;
            }
            set { _pieceSingleMoveCommand = value; }
        }

        public ViewModel()
        {
            board = new Board();
        }

        public void SingleMove(Piece piece)
        {
            board.CanSingleMove(piece);
        }

        public bool CanSingleMove(Piece piece)
        {
            return true;
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
