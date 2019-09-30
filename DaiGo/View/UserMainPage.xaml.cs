using DaiGo.Views;
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
       
        
        async void OnQuickAccessFrameClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new UserMessagePage());
        }

        private void Entry_Completed(object sender, EventArgs e)
        {

        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UserIdentityPage());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UserMessagePage());
        }
    }
}
