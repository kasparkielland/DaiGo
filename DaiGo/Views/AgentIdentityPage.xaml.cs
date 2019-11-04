using System;
using System.Collections.Generic;
using DaiGo.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DaiGo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AgentIdentityPage : ContentPage
    {
        private AgentIdentityViewModel agentIdentityViewModel;

        public AgentIdentityPage()
        {
            InitializeComponent();
            agentIdentityViewModel = new AgentIdentityViewModel();
            agentIdentityViewModel.navigation = Navigation;
            this.BindingContext = agentIdentityViewModel;
        }
    }
}
