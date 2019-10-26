using DaiGo.ViewModels;
using FormsControls.Base;
using System;

using Xamarin.Forms;

namespace DaiGo.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginViewModel LoginViewModel;

        public LoginPage()
        {
            InitializeComponent();
            LoginViewModel = new LoginViewModel();
            MessagingCenter.Subscribe<LoginViewModel, string>(this, "LoginAlert", (sender, args) =>
            {
                DisplayAlert("Login failed", args + "\nEntry fields cannot be empty", "Try again");
            });
            this.BindingContext = LoginViewModel;

            usernameEntry.Completed += (object sender, EventArgs e) =>
            {
                passwordEntry.Focus();
            };

            passwordEntry.Completed += (object sender, EventArgs e) =>
            {
                //if (LoginViewModel.executeLogin.CanExecute(null))
                //    LoginViewModel.executeLogin.Execute(null);
                //LoginViewModel.executeLogin.Execute(null);
            };
        }
    }
}