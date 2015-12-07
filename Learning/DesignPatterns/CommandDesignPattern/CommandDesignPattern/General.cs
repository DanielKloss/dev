using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CommandDesignPattern
{
    public class General
    {
        public ICommand Command { get; set; }

        public void ExecuteCommand()
        {
            Command.Execute();
        }
    }
}
