using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExample
{
    // Class to total and average prices of footballers:
    public class PriceTotaller
    {
        int countPlayers = 0;
        decimal pricePlayers = 0.0m;

        internal void AddFootballerToTotal(Footballer footballer)
        {
            countPlayers += 1;
            pricePlayers += footballer.Price;
        }

        internal decimal AveragePrice()
        {
            return pricePlayers / countPlayers;
        }
    }
}
