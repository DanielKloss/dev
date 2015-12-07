using OpenClosedAndDependencyInversion.Stocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedAndDependencyInversion
{
    class Program
    {
        static void Main(string[] args)
        {
            TradeController dip = new TradeController();
            Share share = new Share();
            share.value = 100;

            ForeignExchange fe = new ForeignExchange();
            fe.value = 200;

            Stock gilt = new Gilt();
            gilt.value = 300;

            dip.Trade(gilt);

            Console.ReadLine();
        }
    }
}
