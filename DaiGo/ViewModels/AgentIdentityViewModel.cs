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
using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Forms;

namespace DaiGo.ViewModels
{
    public class AgentIdentityViewModel : INotifyPropertyChanged
    {
        public ICommand GoToUserCommand { get; set; }
        public ICommand LogoutCommand { get; set; }
        public ICommand executeGoBackCommand { get; set; }

        public INavigation navigation { get; set; }

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
            this.GoToUserCommand = new Command(async () => await UserModeClicked());
            this.LogoutCommand = new Command(async () => await LogoutClicked());
            this.executeGoBackCommand = new Command(async () => await GoBack());
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        bool _deactivateAgent;

        private async Task UserModeClicked()
        {
            navigation.RemovePage(navigation.NavigationStack[0]);
            await navigation.PushAsync(new UserIdentityPage(), false);
            navigation.InsertPageBefore(new AgentMainPage(), navigation.NavigationStack[0]);
            //Application.Current.MainPage = new NavigationPage(new UserIdentityPage());
        }
        private async Task LogoutClicked()
        {
            navigation.InsertPageBefore(new LoginPage(), navigation.NavigationStack[0]);
            await navigation.PopToRootAsync(false);
            //Application.Current.MainPage = new NavigationPage(new LoginPage());
        }
        private async Task GoBack()
        {
            await navigation.PopToRootAsync(false);
            //Application.Current.MainPage = new NavigationPage(new AgentMainPage());
        }

    }
}
