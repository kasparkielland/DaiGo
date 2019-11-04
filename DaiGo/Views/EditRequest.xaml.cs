using System;
using System.Collections.Generic;
using DaiGo.ViewModels;
using Xamarin.Forms;

namespace DaiGo.Views
{
    public partial class EditRequest : ContentPage
    {
        private EditRequestViewModel editRequestViewModel;

        public EditRequest()
        {
            InitializeComponent();
            editRequestViewModel = new EditRequestViewModel();
            editRequestViewModel.navigation = Navigation;
            this.BindingContext = editRequestViewModel;

        }
    }
}
