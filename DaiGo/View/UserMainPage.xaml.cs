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
        }
        async void OnSearchButtonClicked(object sender, EventArgs args)
        {
            await DisplayAlert("Cicked", "Searching...", "OK");
        }
    }
}
