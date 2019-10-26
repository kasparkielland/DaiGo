//using DaiGo.Views;
//using DaiGo.Views;
//using System;
//using System.Windows.Input;

//using Xamarin.Forms;

//namespace DaiGo.ViewModels
//{
//    class AgentIdentityViewModel:BaseViewModel
//    {
//        public new ICommand GoToUserCommand { get; }
//        public new ICommand LogoutCommand { get; }
//        public new ICommand GoToItemsCommand { get; }

//        public AgentIdentityViewModel()
//        {
//            Title = "Agents Name and Rating";
//            this.GoToUserCommand = new Command(ToggleToUser);
//            this.LogoutCommand = new Command(LogoutClicked);
//            this.GoToItemsCommand = new Command(ToItemsClicked);
//        }
//        void ToggleToUser()
//        {
//            Application.Current.MainPage = new NavigationPage(new UserIdentityPage());
//        }
//        void LogoutClicked()
//        {
//            Application.Current.MainPage = new NavigationPage(new LoginPage());
//        }
//        void ToItemsClicked()
//        {
//            Application.Current.MainPage = new NavigationPage(new AgentMainPage());
//        }
//    }
//}

using DaiGo.Views;
using System.ComponentModel;
using System.Windows.Input;

using Xamarin.Forms;

namespace DaiGo.ViewModels
{
    public class AgentIdentityViewModel : INotifyPropertyChanged
    {
        public ICommand GoToUserCommand { get; set; }
        public ICommand LogoutCommand { get; set; }
        public ICommand executeGoBackCommand { get; set; }
        public bool dectivateAgent
        {
            get
            {
                return _deactivateAgent;
            }
            set
            {
                _deactivateAgent = value;
                UserModeClicked();
            }
        }


        public AgentIdentityViewModel()
        {
            this.GoToUserCommand = new Command(UserModeClicked);
            this.LogoutCommand = new Command(LogoutClicked);
            this.executeGoBackCommand = new Command(GoBack);
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        bool _deactivateAgent;

        void UserModeClicked()
        {
            Application.Current.MainPage = new NavigationPage(new UserIdentityPage());
        }
        void LogoutClicked()
        {
            Application.Current.MainPage = new NavigationPage(new LoginPage());
        }
        void GoBack()
        {
            Application.Current.MainPage = new NavigationPage(new AgentMainPage());
        }

    }
}
