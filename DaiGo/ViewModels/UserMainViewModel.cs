using DaiGo.Models;
using DaiGo.View;
using DaiGo.Views;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;


namespace DaiGo.ViewModels
{
    class UserMainViewModel : BaseViewModel
    {

        public ICommand GoEditRequestCommand { get; }
        public ICommand GoProfileCommand { get; }
        public ICommand GoMessageCommand { get; }
        public UserMainViewModel()
        {
            Title = "User Main Page";
            this.GoProfileCommand = new Command(ProfileClicked);
            this.GoMessageCommand = new Command(MessageClicked);
            this.GoEditRequestCommand = new Command(async () => await SearchClicked(),
                            () => !isBusy);


        }
        void ProfileClicked()
        {
            Application.Current.MainPage = new NavigationPage(new UserIdentityPage());
        }
        void MessageClicked()
        {
            Application.Current.MainPage = new NavigationPage(new NewItemPage());
        }


        string subject;
        int requestID;
        bool isBusy;



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

        public bool IsBusy
        {
            get
            {
                return isBusy;
            }
            set
            {
                isBusy = value;
                //OnRequestButtonClicked.ChangeCanExecute();
            }
        }
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


        public Command OnRequestButtonClicked
        {
            get;
        }

        async Task SearchClicked()
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
