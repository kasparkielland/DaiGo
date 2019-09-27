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
        public UserLoginPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

        }

        async void OnSignupButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new UserSignUp());
        }

        async void OnLoginButtonClicked(object sender, EventArgs args)
        {
            // Do login sequense


            // Go to UserMainPage
            await Navigation.PushAsync(new UserMainPage());
        }

        // Example to Login handling (https://docs.microsoft.com/nb-no/xamarin/xamarin-forms/app-fundamentals/navigation/hierarchical)
        //async void OnLoginButtonClicked(object sender, EventArgs e)
        //{
        //    var isValid = AreCredentialsCorrect(user);
        //    if (isValid)
        //    {
        //        App.IsUserLoggedIn = true;
        //        Navigation.InsertPageBefore(new MainPage(), this);
        //        await Navigation.PopAsync();
        //    }
        //    else
        //    {
        //        // Login failed
        //    }
        //}

    }
}