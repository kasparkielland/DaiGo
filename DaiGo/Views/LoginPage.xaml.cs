using DaiGo.ViewModels;
using FormsControls.Base;
using System;

using Xamarin.Forms;

namespace DaiGo.Views
{
    public partial class LoginPage : ContentPage
    {
        private LoginViewModel loginViewModel;

        public LoginPage()
        {
            InitializeComponent();
            loginViewModel = new LoginViewModel();
            //MessagingCenter.Subscribe<LoginViewModel, string>(this, "LoginAlert", (sender, args) =>
            //{
            //    DisplayAlert("Login failed", args + "\nEntry fields cannot be empty", "Try again");
            //});
            loginViewModel.navigation = Navigation;
            this.BindingContext = loginViewModel;

            //usernameEntry.Completed += (object sender, EventArgs e) =>
            //{
            //    passwordEntry.Focus();
            //};

            //passwordEntry.Completed += (object sender, EventArgs e) =>
            //{
            //    //if (LoginViewModel.executeLogin.CanExecute(null))
            //    //    LoginViewModel.executeLogin.Execute(null);
            //    //LoginViewModel.executeLogin.Execute(null);
            //};
        }

        private void UsernameEntry_Completed(object sender, EventArgs e)
        {
            passwordEntry.Focus();
        }

        private void PasswordEntry_Completed(object sender, EventArgs e)
        {
            LoginButton.Focus();
        }
    }
}