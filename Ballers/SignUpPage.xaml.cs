using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Ballers
{
    public partial class SignUpPage : ContentPage
    {
        Dictionary<string, string> signupResult;

        public SignUpPage()
        {
            InitializeComponent();
        }

        async void btnSignUp_Clicked(object sender, EventArgs e)
        {
            var email = entryEmail.Text;
            var password = entryPassword.Text;
            var username = entryUsername.Text;
            var confirmPassword = entryConfirmPassword.Text;
            FormValidations signup = new FormValidations();

            signupResult = signup.signUpValidation(username, email, password, confirmPassword);

            if (signupResult["Result"].ToString() == "Success")
            {
                Application.Current.Properties["Username"] = username.ToLower();
                Application.Current.Properties["Email"] = email.ToLower();
                Application.Current.Properties["Password"] = password;
                await Application.Current.SavePropertiesAsync();
                await Navigation.PopAsync(true);
            }
            else
            {
                await DisplayAlert(Message.SIGNUP_ERROR_MSG_TITLE, signupResult["Message"], Message.ALERT_BOX_BUTTON);
            }
        }
    }
}
