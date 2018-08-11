using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;

namespace Ballers
{
    public partial class FindTeamPage : ContentPage
    {
        List<string> teamList = new List<string>
        {
            "Real Madrid FC","FC Barcelona","Juventus FC","Liverpool FC","FC Bayern Munich", "Inter Milan", "Manchester United FC","Manchester City FC","Tottenham Hotspur FC", "Atletico Madrid"
        };

        ObservableCollection<string> selectedColors = new ObservableCollection<string>();

        public FindTeamPage()
        {
            InitializeComponent();
        }

        void Handle_TextChanged(object sender, TextChangedEventArgs e)
        {
            var keyword = findTeamSearchBar.Text;
            if (keyword.Length >= 1)
            {
                var suggestions = teamList.Where(c => c.ToLower().Contains(keyword.ToLower()));
                SuggestionListView.ItemsSource = suggestions;
                SuggestionListView.IsVisible = true;
            }
            else
            {
                SuggestionListView.IsVisible = false;
            }
        }

        async void suggestionList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var title = e.Item as string;
            selectedColors.Add(title);
            SuggestionListView.IsVisible = false;
            TeamListViewModel team = new TeamListViewModel();
            var teamSelected = team.TeamModel.Where(c => c.teamName.ToLower().Contains(title.ToLower())).FirstOrDefault();
            await Navigation.PushAsync(new JoinRequestPage(teamSelected.teamName, teamSelected.TeamImage, title)); 

        }

        void Handle_SearchButtonPressed(object sender, EventArgs e)
        {
            //var keyword = ColorsSearchBar.Text;
            //var suggestions = colorList.Where(c => c.ToLower().Contains(keyword.ToLower()));
            //SuggestionListView.ItemsSource = suggestions;
        }
    }
}
