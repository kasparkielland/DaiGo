using DaiGo.ViewModels;
using DaiGo.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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

            passwordEntry.Completed += (object sender, EventArgs e) =>
            {
                userLoginViewModel.LoginCommand.Execute(null);
            };
        }

        async void OnSignupButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new UserSignUp());
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ItemsPage());
        }



    }
}