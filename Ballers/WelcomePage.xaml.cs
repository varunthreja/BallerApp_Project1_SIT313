using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Ballers
{
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        async void btnFindTeam_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FindTeamPage());
        }

        async void btnLogout_Clicked(object sender, EventArgs e)
        {
            if (Application.Current.Properties.ContainsKey("Email") && Application.Current.Properties.ContainsKey("Password") && Application.Current.Properties.ContainsKey("Username"))
            {
                Application.Current.Properties["Username"] = "";
                Application.Current.Properties["Email"] = "";
                Application.Current.Properties["Password"] = "";
                await Application.Current.SavePropertiesAsync();
            }
            await Navigation.PopAsync(true);
        }
    }
}
