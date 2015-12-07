using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTableReader
{
    public class Team
    {
        public string name { get; set; }
        public string played { get; set; }
        public string won { get; set; }
        public string lost { get; set; }
        public string drawn { get; set; }
        public string goalsFor { get; set; }
        public string goalsAgainst { get; set; }
        public int goalDifference { get; set; }
        public string points { get; set; }
    }
}
