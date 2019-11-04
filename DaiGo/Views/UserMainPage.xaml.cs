using System;
using System.Collections.Generic;
using DaiGo.ViewModels;
using Xamarin.Forms;

namespace DaiGo.Views
{
    public partial class UserMainPage : ContentPage
    {
        private UserMainViewModel userMainViewModel;

        public UserMainPage()
        {
            InitializeComponent();
            userMainViewModel = new UserMainViewModel();
            userMainViewModel.navigation = Navigation;
            this.BindingContext = userMainViewModel;
        }
    }
}
