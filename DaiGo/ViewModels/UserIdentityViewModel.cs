using DaiGo.Views;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Forms;

namespace DaiGo.ViewModels
{
    public class UserIdentityViewModel : INotifyPropertyChanged
    {
        public ICommand GoToAgentCommand { get; set; }
        public ICommand LogoutCommand { get; set; }
        public ICommand GoToMainCommand { get; set; }

        public INavigation navigation { get; set; }

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
            this.GoToAgentCommand = new Command(async () => await AgentModeClicked());
            this.LogoutCommand = new Command(async () => await LogoutClicked());
            this.GoToMainCommand = new Command(async () => await ToMainClicked());
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        bool _activateAgent;

        private async Task AgentModeClicked()
        {
            navigation.RemovePage(navigation.NavigationStack[0]);
            await navigation.PushAsync(new AgentIdentityPage());
            navigation.InsertPageBefore(new AgentMainPage(), navigation.NavigationStack[0]);
            //Application.Current.MainPage = new NavigationPage(new AgentMainPage());

        }
        private async Task LogoutClicked()
        {
            navigation.InsertPageBefore(new LoginPage(), navigation.NavigationStack[0]);
            await navigation.PopToRootAsync();

            // Does the same as above code
            //navigation.RemovePage(navigation.NavigationStack[0]);
            //await navigation.PushAsync(new LoginPage());
            //navigation.RemovePage(navigation.NavigationStack[0]);

            //Application.Current.MainPage = new NavigationPage(new LoginPage());
        }

        private async Task ToMainClicked()
        {
            await navigation.PopToRootAsync();
            //Application.Current.MainPage = new NavigationPage(new UserMainPage());
        }

    }
}
