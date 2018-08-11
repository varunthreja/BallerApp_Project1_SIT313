using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Ballers
{
    public partial class JoinRequestPage : ContentPage
    {
        public JoinRequestPage()
        {
            InitializeComponent();
        }
        public JoinRequestPage(string name, string image, string title)
        {
            InitializeComponent();
            teamlogoX.Source = image;
            this.Title = title;
            message.Text = "The "+name+" team captain and team admins have been notified...They will add you to the squad as soon as possible!";
            joinTeamName.Text = "Join " + title;
        }

        async void btnDone_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ApprovedJoinRequest());
        }
    }
}
