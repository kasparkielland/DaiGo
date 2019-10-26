using DaiGo.Models;
using DaiGo.Views;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;


namespace DaiGo.ViewModels
{
    class UserMainViewModel : BaseViewModel
    {

        public ICommand executeProfileCommand { get; set; }
        public ICommand executeMessageCommand { get; set; }
        public ICommand executeRequestCommand { get; set; }
        public ICommand executeQuicAccessCommand { get; set; }


        public UserMainViewModel()
        {
            Title = "User Main Page";
            this.executeProfileCommand = new Command(ProfileClicked);
            this.executeMessageCommand = new Command(MessageClicked);
            this.executeRequestCommand = new Command(async () => await RequestSearchClicked(),
                            () => !IsBusy);
            this.executeQuicAccessCommand = new Command(QuicAccess);


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


        string subject;
        int requestID;

        public string Subject
        {
            get
            {
                return subject;
            }
            set
            {
                subject = value;
            }
        }

        public new bool IsBusy { get; set; }
        public int RequestID
        {
            get
            {
                return requestID;
            }
            set
            {
                requestID = value;
            }
        }

        async Task RequestSearchClicked()
        {
            //IsBusy = true;

            if (!string.IsNullOrWhiteSpace(subject))
            {
                await App.Database.SaveUserRequestAsync(new UserRequest
                {
                    RequestID = RequestID++,
                    Subject = subject
                });


                //IsBusy = false;
                Application.Current.MainPage = new NavigationPage(new EditRequest());

            }
        }
    }

}
