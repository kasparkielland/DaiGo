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


        public LoginViewModel loginViewModel { get; set; } = new LoginViewModel();
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

        public ObservableCollection<AgentQuote> AgentQuotesForThisUser { get; set; } = new ObservableCollection<AgentQuote>();

        public ICommand executeProfileCommand { get; set; }
        public ICommand executeMessageCommand { get; set; }
        public ICommand executeRequestCommand { get; set; }
        public ICommand executeQuicAccessCommand { get; set; }
        public INavigation navigation { get; set; }


        public UserMainViewModel()
        {
            this.executeProfileCommand = new Command(async () => await ProfileClicked());
            this.executeMessageCommand = new Command(async () => await MessageClicked());
            this.executeRequestCommand = new Command(async () => await RequestSearchClicked());
            this.executeQuicAccessCommand = new Command(async () => await QuicAccess());

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
        public async Task QuickAccess()
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

        public async Task ProfileClicked()
        {
            await navigation.PushAsync(new UserIdentityPage());
        }
        public async Task MessageClicked()
        {
            await navigation.PushAsync(new UserMessagePage());
        }
        public async Task QuicAccess()
        {
            await navigation.PushAsync(new UserMessagePage());
        }
        public async Task RequestSearchClicked()
        {
            await navigation.PushAsync(new EditRequest());

        }
    }

}
