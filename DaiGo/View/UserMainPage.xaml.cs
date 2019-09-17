using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace DaiGo.View
{
    public partial class UserMainPage : ContentPage
    {
        public UserMainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
        async void OnProfileIconButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new UserProfile());
        }
        async void OnMessageIconButtonClicked(object sender, EventArgs args)
        {
            await DisplayAlert("Cicked", "Searching...", "OK");
        }
        async void OnQuickAccessButtonClicked(object sender, EventArgs args)
        {
            await DisplayAlert("Cicked", "Searching...", "OK");
        }
        async void OnSearchButtonClicked(object sender, EventArgs args)
        {
            await DisplayAlert("Cicked", "Searching...", "OK");
        }
    }
}
