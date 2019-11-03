using System;
using System.ComponentModel;
using DaiGo.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DaiGo.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class AgentVerificationPage : ContentPage
    {
        private AgentVerificationViewModel agentVerificationViewModel;

        public AgentVerificationPage()
        {
            InitializeComponent();
            agentVerificationViewModel = new AgentVerificationViewModel();
            agentVerificationViewModel.navigation = Navigation;
            this.BindingContext = agentVerificationViewModel;
        }


    }
}