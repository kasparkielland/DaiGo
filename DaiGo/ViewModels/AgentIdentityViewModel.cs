using DaiGo.View;
using DaiGo.Views;
using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace DaiGo.ViewModels
{
    class AgentIdentityViewModel:BaseViewModel
    {
        public ICommand GoToUserCommand { get; }
        public ICommand LogoutCommand { get; }
        public ICommand GoToItemsCommand { get; }

        public AgentIdentityViewModel()
        {
            Title = "Agents Name and Rating";
            this.GoToUserCommand = new Command(ToggleToUser);
            this.LogoutCommand = new Command(LogoutClicked);
            this.GoToItemsCommand = new Command(ToItemsClicked);
        }
        void ToggleToUser()
        {
            Application.Current.MainPage = new NavigationPage(new UserIdentityPage());
        }
        void LogoutClicked()
        {
            Application.Current.MainPage = new NavigationPage(new UserLoginPage());
        }
        void ToItemsClicked()
        {
            Application.Current.MainPage = new NavigationPage(new ItemsPage());
        }
    }
}
