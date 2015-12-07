using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExample
{
    // Describes a player on the transfer list:
    public class Footballer
    {
        public string Name;        // Name of the player.
        public string Team;       // Team the player plays for.
        public decimal Price;       // Price of the player.
        public bool Injured;      // Is the player injured?

        public Footballer(string name, string team, decimal price, bool injured)
        {
            Name = name;
            Team = team;
            Price = price;
            Injured = injured;
        }
    }
}
