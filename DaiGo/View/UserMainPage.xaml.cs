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
        async void OnButtonClicked(object sender, EventArgs args)
        {
            await DisplayAlert("Last warning...", "DON'T click OK!", "OK");
        }
    }
}
