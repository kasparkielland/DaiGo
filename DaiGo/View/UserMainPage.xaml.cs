using DaiGo.ViewModels;
using DaiGo.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DaiGo.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserMainPage : ContentPage
    {
        private UserMainViewModel userMainViewModel;

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
