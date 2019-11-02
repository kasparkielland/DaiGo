using DaiGo.Models;
using DaiGo.Views;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using System.Diagnostics;


namespace DaiGo.ViewModels
{
    class UserMainViewModel : BaseViewModel
    {


        public LoginViewModel loginViewModel = new LoginViewModel();
        private int count;
        public string WelcomeText
        {
            get
            {
                return "Good Day, " + loginViewModel.Username;
            }
        }
        public string QuickAccessText
        {
            get
            {
                return "You have " + count.ToString() + " messages";
            }
        }
        private string subject;
        public ObservableCollection<AgentQuote> AgentQuotesForThisUser{get; set;} = new ObservableCollection<AgentQuote>();
        public ICommand ExecuteProfileCommand { get; set; }
        public ICommand ExecuteMessageCommand { get; set; }
        public ICommand ExecuteRequestCommand { get; set; }
        public ICommand ExecuteQuicAccessCommand { get; set; }


        public UserMainViewModel()
        {
           
            
            this.ExecuteProfileCommand = new Command(ProfileClicked);
            this.ExecuteMessageCommand = new Command(MessageClicked);
            this.ExecuteRequestCommand = new Command(RequestSearchClicked);
            this.ExecuteQuicAccessCommand = new Command(QuicAccess);


        }

       


        public string Subject
        {
            get
            {
                return subject;
            }
            set
            {
                SetProperty(ref subject, value);
                //subject = value;
            }
        }
        public async void QuickAccess()
        {
                count = 0;
                var userID = loginViewModel.UserID; 
                var requests = await App.Database.ThisUserRequestAsync(userID);
                var quotes = await App.Database.GetAgentQuoteAsync();


            foreach (var req in requests)
            {
                foreach (var quo in quotes)
                {
                    if (req.RequestID == quo.RequestID)
                    {

                        count++;
                        AgentQuotesForThisUser.Add(quo);

                    }

                }

            }
        }

        void ProfileClicked()
        {
            Application.Current.MainPage = new NavigationPage(new UserIdentityPage());
        }
        void MessageClicked()
        {
            Application.Current.MainPage = new NavigationPage(new UserMessagePage());
        }
        void QuicAccess()
        {
            Application.Current.MainPage = new NavigationPage(new UserMessagePage());
        }


    

    
        public void RequestSearchClicked()
        {
           Application.Current.MainPage = new NavigationPage(new EditRequest());
                     
        }
    }

}
