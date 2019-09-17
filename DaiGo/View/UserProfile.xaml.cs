using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DaiGo.View
{
    public partial class UserProfile : ContentPage
    {
        public UserProfile()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        async void OnLogoutButtonClicked(object sender, EventArgs args)
        {
            // Do logout procydure

            // Go to firstpage
            await Navigation.PopToRootAsync(false);
        }

    }
}
