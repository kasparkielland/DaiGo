using DaiGo.ViewModels;
using System;

using Xamarin.Forms;

namespace DaiGo.View
{
    public partial class UserLoginPage : ContentPage
    {
        public UserLoginViewModel userLoginViewModel;

        public UserLoginPage()
        {
            InitializeComponent();
            userLoginViewModel = new UserLoginViewModel();
            MessagingCenter.Subscribe<UserLoginViewModel, string>(this, "LoginAlert", (sender, args) =>
            {
                DisplayAlert("Login failed", args + "\nEntry fields cannot be empty", "Try again");
            });
            this.BindingContext = userLoginViewModel;

            usernameEntry.Completed += (object sender, EventArgs e) =>
            {
                passwordEntry.Focus();
            };

            //passwordEntry.Completed += (object sender, EventArgs e) =>
            //{
            //    userLoginViewModel.LoginCommand.Execute(null);
            //};
        }
    }
}