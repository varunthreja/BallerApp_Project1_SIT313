using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Ballers
{
    public partial class ForgotPasswordPage : ContentPage
    {
        public ForgotPasswordPage()
        {
            InitializeComponent();
        }

        void brtSend_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Confirmation", "Email Send Successfully", "OK");
        }
    }
}
