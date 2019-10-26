using DaiGo.Views;
using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace DaiGo.ViewModels
{
    public class AgentVerificationViewModel : BaseViewModel
    {
        public ICommand GoHomeCommand { get; }
        public AgentVerificationViewModel()
        {
            Title = "AgentVerification";
            this.GoHomeCommand = new Command(this.GoHomeClicked);

        }
        void GoHomeClicked()
        {
            Application.Current.MainPage = new NavigationPage(new AgentMainPage());
        }

    }
}