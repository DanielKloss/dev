using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            General invoker = new General();
            Soldier receiver = new Soldier();
            Order command = new Order(receiver);
            command.Parameter = "This is a command";
            invoker.Command = command;
            invoker.ExecuteCommand();
        }
    }
}
