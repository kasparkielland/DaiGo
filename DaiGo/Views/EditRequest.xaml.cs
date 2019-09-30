using System;
using System.Collections.Generic;
using DaiGo.ViewModels;
using Xamarin.Forms;

namespace DaiGo.Views
{
    public partial class EditRequest : ContentPage
    {
        public EditRequest()
        {
            InitializeComponent();
            BindingContext = new EditRequestViewModel();
            NavigationPage.SetHasNavigationBar(this, false);

        }
        async void OnGoBackButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PopAsync();
        }
    }
}


