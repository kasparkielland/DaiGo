using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DaiGo.View
{
    public partial class EditRequest : ContentPage
    {
        public EditRequest()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

        }

        async void OnGoBackButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PopAsync();
        }
        async void OnSendRequestButtonClicked(object sender, EventArgs args)
        {

        }
    }
}
