using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    public interface ICommand
    {
        void Execute();
    }

    public class Order : ICommand
    {
        protected Soldier _receiver;
        public string Parameter { get; set; }

        public Order(Soldier receiver)
        {
            _receiver = receiver;
        }

        public void Execute()
        {
            _receiver.Action(Parameter);
        }
    }
}
