using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using Checkers;

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

        public ViewModel()
        {
            board = new Board();
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
