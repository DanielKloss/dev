using CharacterCounter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GUI
{
    public class ViewModel : INotifyPropertyChanged
    {
        private string _characters;
        public string characters
        {
            get { return _characters; }
            set
            {
                _characters = value;
                onPropertyChanged("characters");
            }
        }

        private Dictionary<Char, int> _result;
        public Dictionary<Char, int> result
        {
            get { return _result; }
            set 
            {
                _result = value;
                onPropertyChanged("result");
            }
        }

        private Counter counter = new Counter();

        private ICommand _countCommand;
        public ICommand countCommand
        {
            get
            {
                if (_countCommand == null)
                {
                    _countCommand = new RelayCommand<object>(Count, AlwaysTrue);
                }
                return _countCommand;
            }
            set { _countCommand = value; }
        }

        private void Count(object unusedParameter)
        {
            result = counter.Count(characters);
        }

        private bool AlwaysTrue(object unusedParameter)
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
