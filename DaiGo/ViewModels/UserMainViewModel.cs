using DaiGo.Models;
using DaiGo.Views;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;


namespace DaiGo.ViewModels
{
    class UserMainViewModel : BaseViewModel
    {
        private string username;
        private int count;
        public OberservableCollection<AgentQuote> AgentQuotesForThisUser{get; set;}
        public ICommand executeProfileCommand { get; set; }
        public ICommand executeMessageCommand { get; set; }
        public ICommand executeRequestCommand { get; set; }
        public ICommand executeQuicAccessCommand { get; set; }


        public UserMainViewModel()
        {
            WelcomeText = "Good Day, " + username;
            QuickAcessText = "You have " + count.Tostring() + " message"; 
            AgentQuotesForThisUser = new OberservableCollection<AgentQuote>();
            this.executeProfileCommand = new Command(ProfileClicked);
            this.executeMessageCommand = new Command(MessageClicked);
            this.executeRequestCommand = new Command(async () => await RequestSearchClicked());
            //                () => !IsBusy);
            this.executeQuicAccessCommand = new Command(QuicAccess);


        }

        public string Username
        {
            get => username;
            set
            {
                var loginuser = new LoginViewModel();
                username = loginuser.Username;
                this.Username = username;
             }

        }
        public void QuickAccess()
        {
                count = 0;
                
                var request = App.Database.Name_Request_Async(username);
                var quote = App.Database.GetAgentQuoteAsync();
                foreach (var req in request)
                {
                    if (req.RequestID == quote.RequestID)       
                    {

                        count++;
                        AgentQuotesForThisUser.Add(req);
                        
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


        private string subject;
        private int requestID;

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

        public new bool IsBusy { get; set; }
    //    public int RequestID
    //    {
    //        get
    //        {
    //            return requestID;
    //        }
    //        set
    //        {
    //            //requestID = value;
    //        }
    //    }

        async Task RequestSearchClicked()
        {
            //IsBusy = true;

            if (!string.IsNullOrWhiteSpace(subject))
            {
                var newUserRequest = new UserRequest()
                {
                    Subject = subject
                };
                await App.Database.SaveUserRequestAsync(newUserRequest);
             }

            //    await App.Database.SaveUserRequestAsync(new UserRequest
            //    {
            //        RequestID = RequestID++,
            //        Subject = subject
            //    });


                //IsBusy = false;
            Application.Current.MainPage = new NavigationPage(new EditRequest());

            }
        }
    }

}
