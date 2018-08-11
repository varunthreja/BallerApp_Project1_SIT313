using System;
using System.Collections.ObjectModel;

namespace Ballers
{
    public class TeamListViewModel
    {
        public ObservableCollection<TeamModel> TeamModel { get; set; }

        public TeamListViewModel()
        {
            TeamModel = new ObservableCollection<TeamModel>
            {
                new TeamModel
                {
                    teamName = "Real Madrid FC",
                    TeamImage ="RealMadridFC.png"
                },
                new TeamModel
                {
                    teamName = "FC Barcelona",
                    TeamImage ="FCBarcelona.png"
                },
                new TeamModel
                {
                    teamName = "Juventus FC",
                    TeamImage ="JuventusFC.png"
                },
                new TeamModel
                {
                    teamName = "Liverpool FC",
                    TeamImage ="LiverpoolFC.jpg"
                },
                new TeamModel
                {
                    teamName = "FC Bayern Munich",
                    TeamImage ="FCBayernMunich.png"
                },
                new TeamModel
                {
                    teamName = "Inter Milan",
                    TeamImage ="InterMilan.png"
                },
                new TeamModel
                {
                    teamName = "Manchester United FC",
                    TeamImage ="ManchesterUnitedFC.png"
                },
                new TeamModel
                {
                    teamName = "Manchester City FC",
                    TeamImage ="ManchesterCityFC.png"
                },
                new TeamModel
                {
                    teamName = "Tottenham Hotspur FC",
                    TeamImage ="TottenhamHotspurFC.jpg"
                },
                new TeamModel
                {
                    teamName = "Atletico Madrid",
                    TeamImage ="AtleticoMadrid.png"
                }
            };
        }
    }
}
