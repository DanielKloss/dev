using FootballTableReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballGui
{
    public class FootballViewModel : INotifyPropertyChanged
    {
        FootballReader footballReader = new FootballReader();

        private List<Team> _teams;
        public List<Team> teams
        {
            get { return _teams; }
            set
            {
                _teams = value;
                onPropertyChanged("teams");
            }
        }

        public FootballViewModel()
        {
            teams = footballReader.ReadTable("football.xml");

            foreach (Team team in teams)
            {
                team.goalDifference = Convert.ToInt16(team.goalsFor) - Convert.ToInt16(team.goalsAgainst);
            }
        }

        private void onPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
