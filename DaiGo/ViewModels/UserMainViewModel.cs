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
        public string WelcomeText;
        public string QuickAcessText;
        public ObservableCollection<AgentQuote> AgentQuotesForThisUser{get; set;}
        public ICommand executeProfileCommand { get; set; }
        public ICommand executeMessageCommand { get; set; }
        public ICommand executeRequestCommand { get; set; }
        public ICommand executeQuicAccessCommand { get; set; }


        public UserMainViewModel()
        {
            
            WelcomeText = "Good Day, " + loginViewModel.Username;
            QuickAcessText = "You have " + count.ToString() + " message"; 
            AgentQuotesForThisUser = new ObservableCollection<AgentQuote>();
            this.Subject = subject;
            this.executeProfileCommand = new Command(ProfileClicked);
            this.executeMessageCommand = new Command(MessageClicked);
            this.executeRequestCommand = new Command(RequestSearchClicked);
            //                () => !IsBusy);
            this.executeQuicAccessCommand = new Command(QuicAccess);


        }
       
 
        public void QuickAccess()
        {
                count = 0;
                var userID = loginViewModel.UserID; 
                var requests = App.Database.ThisUserRequestAsync(userID);
                var quotes = App.Database.GetAgentQuoteAsync();
                
                
         //       foreach (var req in request)
         //       {
         //           if (req.RequestID == quote.RequestID)       
         //           {

         //               count++;
         //               AgentQuotesForThisUser.Add(req);
                        
         //           }

          //      }
              
            
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
        // private int requestID;

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

     //   public new bool IsBusy { get; set; }
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

    //    async Task RequestSearchClicked()
        public void RequestSearchClicked()
        {
    

     //       if (!string.IsNullOrWhiteSpace(subject))
     //       {
    //            {
    //                Subject = subject
     //           };
     //           await App.Database.SaveUserRequestAsync(newUserRequest);
     //        }

            //    await App.Database.SaveUserRequestAsync(new UserRequest
            //    {
            //        RequestID = RequestID++,
            //        Subject = subject
            //    });


     
            Application.Current.MainPage = new NavigationPage(new EditRequest());
                     
        }
    }

}
