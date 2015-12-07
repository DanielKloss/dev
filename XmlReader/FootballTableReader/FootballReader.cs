using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FootballTableReader
{
    public class FootballReader
    {
        public XDocument xmlFile;

        public List<Team> ReadTable(string filePath)
        {
            xmlFile = XDocument.Load(filePath);

            List<Team> teamsToReturn = new List<Team>();

            var teams = from team in xmlFile.Descendants("team")
                        select new
                        {
                            name = team.Element("name").Value,
                            played = team.Element("played").Value,
                            won = team.Element("won").Value,
                            lost = team.Element("lost").Value,
                            drawn = team.Element("drawn").Value,
                            goalsFor = team.Element("for").Value,
                            goalsAgainst = team.Element("against").Value,
                            points = team.Element("points").Value
                        };

            foreach (var team in teams)
            {
                Team newTeam = new Team()
                {
                    name = team.name,
                    played = team.played,
                    won = team.won,
                    lost = team.lost,
                    drawn = team.drawn,
                    goalsFor = team.goalsFor,
                    goalsAgainst = team.goalsAgainst,
                    points = team.points
                };

                teamsToReturn.Add(newTeam);
            }

            return teamsToReturn;
        }
    }
}
