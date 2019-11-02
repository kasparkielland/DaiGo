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
        public ICommand ContactAgentCommand{get; set;}
        

        public UserMessageViewModel()
        {
            AgentQuotesForThisUser = userMainViewModel.AgentQuotesForThisUser;
            
            ContactAgentCommand = new Command(GoContactAgent);
            GoBackCommand = new Command(BackClicked);

        }
        
        void GoContactAgent()
        {
            // not implement yet
            // shall open an Email or Messenger so User can Contact with Agent
        }
        void BackClicked()
        {
            Application.Current.MainPage = new NavigationPage(new UserMainPage());
        }

    }
}
