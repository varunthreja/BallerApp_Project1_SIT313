using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Ballers
{
    public partial class ApprovedJoinRequest : ContentPage
    {
        public ApprovedJoinRequest()
        {
            InitializeComponent();
        }

        async void btnDone_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TeamMembersListPage());
        }
    }
}
