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
            Navigation.PopAsync();
        }
        async void OnProfileIconButtonClicked(object sender, EventArgs args)
        {
            //await Navigation.PushAsync(new UserIdentityPage());
        }
        async void OnMessageIconButtonClicked(object sender, EventArgs args)
        {
            await DisplayAlert("Clicked on messageIcon", "...", "OK");
        }
        async void OnQuickAccessFrameClicked(object sender, EventArgs args)
        {
            await DisplayAlert("Clicked on QA", "...", "OK");
        }
        async void OnSearchButtonClicked(object sender, EventArgs args)
        {
            await DisplayAlert("Clicked", "Searching...", "OK");
        }
    }
}
