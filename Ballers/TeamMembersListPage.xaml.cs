using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace Ballers
{
    public partial class TeamMembersListPage : ContentPage
    {
        //string pageTitle = "";
        public TeamMembersListPage()
        {
            InitializeComponent();
        }

        void btnJoinRequest_Clicked(object sender, EventArgs e)
        {
            PopUntilDestination(typeof(WelcomePage));
        }

        void PopUntilDestination(Type DestinationPage)
        {
            int LeastFoundIndex = 0;
            int PagesToRemove = 0;

            for (int index = Navigation.NavigationStack.Count - 2; index > 0; index--)
            {
                if (Navigation.NavigationStack[index].GetType().Equals(DestinationPage))
                {
                    break;
                }
                else
                {
                    LeastFoundIndex = index;
                    PagesToRemove++;
                }
            }

            for (int index = 0; index < PagesToRemove; index++)
            {
                Navigation.RemovePage(Navigation.NavigationStack[LeastFoundIndex]);
            }

            Navigation.PopAsync();
        }
    }
}
