using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Ballers
{
    public partial class SignInPage : ContentPage
    {
        Dictionary<string, string> loginResult;

        public SignInPage()
        {
            InitializeComponent();
            lblSignUp.GestureRecognizers.Add(
            new TapGestureRecognizer()
            {
                Command = new Command(() => {
                    NavigateToSignUpPage();
                })
            });

            forgotPassword.GestureRecognizers.Add(
            new TapGestureRecognizer()
            {
                Command = new Command(() => {
                    NavigateToForgotPasswordPage();
                })
            });

            //if (Application.Current.Properties.ContainsKey("Email") && Application.Current.Properties.ContainsKey("Password"))
            //{
            //    Navigation.PushAsync(new WelcomePage());
            //}

        }
        //protected virtual void OnAppearing()
        //{
        //    base.OnAppearing();
        //    DisplayAlert("alert", "test", "ok");

        //}

        async void NavigateToSignUpPage()
        {
            await Navigation.PushAsync(new SignUpPage());
        }

        async void NavigateToForgotPasswordPage()
        {
            await Navigation.PushAsync(new ForgotPasswordPage());
        }

        async void btnSignIn_Clicked(object sender, EventArgs e)
        {
            var email = entryEmail.Text;
            var password = entryPassword.Text;
            FormValidations login = new FormValidations();

            loginResult = login.LoginValidation(email, password);

            if (loginResult["Result"].ToString() == "Success")
            {
                if (Application.Current.Properties.ContainsKey("Email") && Application.Current.Properties.ContainsKey("Password"))
                {
                    if ((Application.Current.Properties["Email"].ToString() == email.ToLower()) && (Application.Current.Properties["Password"].ToString() == password.ToLower()))
                    {
                        await Navigation.PushAsync(new WelcomePage());
                    }
                    else
                    {
                        await DisplayAlert(Message.LOGIN_ERROR_MSG_TITLE, Message.VALID_CREDENTIALS_MESSAGE, Message.ALERT_BOX_BUTTON);
                    }
                }
                else
                {
                    await DisplayAlert(Message.LOGIN_ERROR_MSG_TITLE, Message.VALID_CREDENTIALS_MESSAGE, Message.ALERT_BOX_BUTTON);
                }
            }
            else
            {
                await DisplayAlert(Message.LOGIN_ERROR_MSG_TITLE, loginResult["Message"], Message.ALERT_BOX_BUTTON);
            }
        }

    }
}
