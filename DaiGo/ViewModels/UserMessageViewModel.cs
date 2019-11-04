using System;
using System.ComponentModel;
using System.Windows.Input;
using DaiGo.Views;
using DaiGo.Models;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

namespace DaiGo.ViewModels
{
    public class UserMessageViewModel : BaseViewModel
    {

        UserMainViewModel userMainViewModel { get; set; } = new UserMainViewModel();

        public ObservableCollection<AgentQuote> AgentQuotesForThisUser { get; set; } = new ObservableCollection<AgentQuote>();

        public ICommand GoBackCommand { get; set; }
        public ICommand ContactAgentCommand { get; set; }

        public INavigation navigation { get; set; }

        public UserMessageViewModel()
        {
            AgentQuotesForThisUser = userMainViewModel.AgentQuotesForThisUser;

            ContactAgentCommand = new Command(async () => await GoContactAgent());
            GoBackCommand = new Command(async () => await BackClicked());

        }

        private async Task GoContactAgent()
        {
            await navigation.PushAsync(new ChatPage(), true);
        }
        private async Task BackClicked()
        {
            await navigation.PopToRootAsync(false);
            //Application.Current.MainPage = new NavigationPage(new UserMainPage());
        }

    }
}
