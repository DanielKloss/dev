using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            FootballerDB playerDB = new FootballerDB();

            // Initialize the database with some players:
            AddPlayers(playerDB);

            // Print all the names of injured players:
            Console.WriteLine("Injured Players:");
            // Create a new delegate object associated with the static 
            // method Test.PrintPlayerName:
            playerDB.ProcessInjuredPlayers(new ProcessPlayerDelegate(PrintPlayerName));

            // Get the average price of an injured player by using
            // a PriceTotaller object:
            PriceTotaller totaller = new PriceTotaller();
            // Create a new delegate object associated with the nonstatic 
            // method AddFootballerToTotal on the object totaller:
            playerDB.ProcessInjuredPlayers(new ProcessPlayerDelegate(totaller.AddFootballerToTotal));
            Console.WriteLine("Average Price for an Injured Player: £{0:#.##}m", totaller.AveragePrice());
            Console.ReadLine();
        }

        // Initialize the player database with some test players:
        static void AddPlayers(FootballerDB footballerDB)
        {
            footballerDB.AddPlayer("Wayne Rooney",
               "Manchester United", 50.00m, false);
            footballerDB.AddPlayer("Jack Wilshere",
               "Arsenal", 20.00m, true);
            footballerDB.AddPlayer("Claire Bassett",
               "Notts County", 30.00m, false);
            footballerDB.AddPlayer("Steph Houghton",
               "Manchester City", 40.00m, true);
        }

        // Print the name of the player.
        static void PrintPlayerName(Footballer footballer)
        {
            Console.WriteLine("   {0}", footballer.Name);
        }
    }
}
