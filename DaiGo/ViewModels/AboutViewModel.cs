using DaiGo.Views;
using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace DaiGo.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public ICommand GoHomeCommand { get; }
        public AboutViewModel()
        {
            Title = "About";
            this.GoHomeCommand = new Command(this.GoHomeClicked);
 
        }
        void GoHomeClicked()
        {
            Application.Current.MainPage = new NavigationPage(new AgentMainPage());
        }
 
    }
}