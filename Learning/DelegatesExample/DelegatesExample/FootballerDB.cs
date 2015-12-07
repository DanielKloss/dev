using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExample
{
    public class FootballerDB
    {
        // List of all players on the transfer list:
        ArrayList transferList = new ArrayList();

        // Add a player to the list:
        public void AddPlayer(string name, string team, decimal price, bool injured)
        {
            transferList.Add(new Footballer(name, team, price, injured));
        }

        // Call a passed-in delegate on each injured player to process it: 
        public void ProcessInjuredPlayers(ProcessPlayerDelegate processPlayer)
        {
            foreach (Footballer footballer in transferList)
            {
                if (footballer.Injured)
                    // Calling the delegate:
                    processPlayer(footballer);
            }
        }
    }

    // Declare a delegate type for processing a player:
    public delegate void ProcessPlayerDelegate(Footballer footballer);
}
