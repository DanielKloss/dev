using FootballTableReader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballConsole
{
    class Program
    {
        static void Main()
        {
            FootballReader fr = new FootballReader();
            List<Team> teams = fr.ReadTable("football.xml");

            foreach (Team team in teams)
            {
                int goalDifference = Convert.ToInt16(team.goalsFor) - Convert.ToInt16(team.goalsAgainst);
                Console.WriteLine(team.name + " " + team.played + " " + team.won + " " + team.drawn + " " + team.lost + " " + team.goalsFor + " " + team.goalsAgainst + " " + goalDifference + " " + team.points);
            }

            Console.ReadLine();
        }
    }
}
