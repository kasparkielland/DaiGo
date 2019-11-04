using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using DaiGo.Views;
using Xamarin.Forms;

namespace DaiGo.ViewModels
{
    public class AgentMessageViewModel : INotifyPropertyChanged
    {
        public ICommand ContactUserCommand { get; set; }
        public ICommand GoBackCommand { get; set; }

        public INavigation navigation { get; set; }

        public AgentMessageViewModel()
        {
            ContactUserCommand = new Command(async () => await GoContactUser());
            GoBackCommand = new Command(async () => await BackClicked());

        }
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        private async Task GoContactUser()
        {
            await navigation.PushAsync(new ChatPage(), true);
        }


        private async Task BackClicked()
        {
            await navigation.PopToRootAsync(false);
            //Application.Current.MainPage = new NavigationPage(new AgentMainPage());
        }
    }
}
