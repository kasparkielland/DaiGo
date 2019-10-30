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
        public ObservableCollection<AgentQuote> AgentQuotesForThisUser
        {
            set
            {
                this.AgentQuotesForThisUser = UserMainViewModel.AgentQuotesForThisUser;
            }
        }
        
        public ObservableCollection<UserRequest> QuoteDetail
        {
            set
            {
                var requestIDinQuote = AgentQuotesForThisUser.RequestID;
                foreach (var req in requestIDinQuote)
                    {
                    QuoteDetail.Add(req);

                    }
            }
        }
        
        public ICommand GoBackCommand { get; set; }
        public ICommand ContactAgentCommand{get; set;}
        

        public UserMessageViewModel()
        {
            AgentQuotesForThisUser = new ObservableCollection<AgentQuote>();
            QuoteDetail = new ObservableCollection<UserRequest>();
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
