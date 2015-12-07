using OpenClosedAndDependencyInversion.Stocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedAndDependencyInversion
{
    public class TradeController
    {
        public void Trade(Stock stock)
        {
            int value = stock.value;

            Console.WriteLine("Value of stock is: " + value);
        }
    }
}
