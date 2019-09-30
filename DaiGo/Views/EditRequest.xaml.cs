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
<<<<<<< HEAD:DaiGo/Views/EditRequest.xaml.cs
<<<<<<< HEAD:DaiGo/Views/EditRequest.xaml.cs
=======
=======
>>>>>>> parent of 7cae416... I have change Agent Page and related message page:DaiGo/View/EditRequest.xaml.cs
        async void OnSendRequestButtonClicked(object sender, EventArgs args)
        {

        }
>>>>>>> parent of 7cae416... I have change Agent Page and related message page:DaiGo/View/EditRequest.xaml.cs
    }
}


