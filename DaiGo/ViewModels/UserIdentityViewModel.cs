using DaiGo.Views;
using System.ComponentModel;
using System.Windows.Input;

using Xamarin.Forms;

namespace DaiGo.ViewModels
{
    public class UserIdentityViewModel : INotifyPropertyChanged
    {
        public ICommand GoToAgentCommand { get; set; }
        public ICommand LogoutCommand { get; set; }
        public ICommand GoToMainCommand { get; set; }
        public bool ActivateAgent
        {
            get
            {
                return _activateAgent;
            }
            set
            {
                _activateAgent = value;
                AgentModeClicked();
            }
        }


        public UserIdentityViewModel()
        {
            this.GoToAgentCommand = new Command(AgentModeClicked);
            this.LogoutCommand = new Command(LogoutClicked);
            this.GoToMainCommand = new Command(ToMainClicked);
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        bool _activateAgent;

        void AgentModeClicked()
        {
            Application.Current.MainPage = new NavigationPage(new AgentIdentityPage());
        }
        void LogoutClicked()
        {
            Application.Current.MainPage = new NavigationPage(new LoginPage());
        }
        void ToMainClicked()
        {
            Application.Current.MainPage = new NavigationPage(new UserMainPage());
        }

    }
}
