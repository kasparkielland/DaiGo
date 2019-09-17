using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DaiGo.View
{
    public partial class UserProfile : ContentPage
    {
        public UserProfile()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }

        async void OnLogoutButtonClicked(object sender, EventArgs args)
        {
            // Do logout procydure

            // Go to firstpage
            await Navigation.PopToRootAsync(false);
        }

    }
}
