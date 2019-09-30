using DaiGo.View;
using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace DaiGo.ViewModels
{
    class UserIdentityViewModel:BaseViewModel
    {
        public ICommand GoToAgentCommand { get; }
        public ICommand LogoutCommand { get; }
        public ICommand GoToMainCommand { get; }
        public UserIdentityViewModel()
        {
            Title = "User's Name and Rating";
            
            this.LogoutCommand = new Command(LogoutClicked);
            this.GoToMainCommand = new Command(ToMainClicked);
        }
        
       
        void LogoutClicked()
        {
            Application.Current.MainPage = new NavigationPage(new UserLoginPage());
        }
        void ToMainClicked()
        {
            Application.Current.MainPage = new NavigationPage(new UserMainPage());
        }
    }
}
