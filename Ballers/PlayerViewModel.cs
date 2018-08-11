using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace Ballers
{
    public class PlayerViewModel: INotifyPropertyChanged
    {
        public ObservableCollection<PlayerModel> _PlayerModel { get; set; }
        public ObservableCollection<PlayerModel> PlayerModel
        {
            get { return _PlayerModel; }
            set
            {
                _PlayerModel = value;
                OnPropertyChanged();
            }
        }

        public PlayerViewModel()
        {
            _PlayerModel = new ObservableCollection<PlayerModel>
            {
                new PlayerModel
                {
                    playerName = "Cristiano Ronaldo",
                    playerImage ="Cristiano.jpg"
                },
                new PlayerModel
                {
                    playerName = "Lionel Messi",
                    playerImage ="Messsi.jpg"
                },
                new PlayerModel
                {
                    playerName = "Paul Pogba",
                    playerImage ="Profile.jpg"
                },
                new PlayerModel
                {
                    playerName = "Eden Hazard",
                    playerImage ="Hazard.jpg"
                },
                new PlayerModel
                {
                    playerName = "Neymar",
                    playerImage ="Profile.jpg"
                },
                new PlayerModel
                {
                    playerName = "Kylian Mbappe",
                    playerImage ="Mbape.jpg"
                },
                new PlayerModel
                {
                    playerName = "Antoine Griezmann",
                    playerImage ="Profile.jpg"
                },
                new PlayerModel
                {
                    playerName = "Gareth Bale",
                    playerImage ="Profile.jpg"
                },
                new PlayerModel
                {
                    playerName = "Luka Modric",
                    playerImage ="LukaModric.jpg"
                },
                new PlayerModel
                {
                    playerName = "Luca Zidane",
                    playerImage ="Profile.jpg"
                },
                new PlayerModel
                {
                    playerName = "Sergio Ramos",
                    playerImage ="Profile.jpg"
                },
                new PlayerModel
                {
                    playerName = Application.Current.Properties["Username"].ToString(),
                    playerImage = "Profile.jpg"
                }
            };

            //AddToTeam();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
