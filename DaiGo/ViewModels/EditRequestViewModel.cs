using DaiGo.Views;
using DaiGo.Views;
using System.Windows.Input;
using Xamarin.Forms;
using System.Threading.Tasks;
using DaiGo.ViewModels;
using DaiGo.Models;

namespace DaiGo.ViewModels
{
    class EditRequestViewModel : BaseViewModel
    {
        public ICommand GoAbout2Command { get; }
        public ICommand GoUserMainCommand { get; }
        public EditRequestViewModel()
        {
            this.GoAbout2Command = new Command(async () => await SaveRequest(),
                                        () => !isBusy);
            this.GoUserMainCommand = new Command(BackClicked);
        }

        void BackClicked()
        {
            Application.Current.MainPage = new NavigationPage(new UserMainPage());
        }

        int requestID;
        string subject;
        string country;
        string category;
        int minPrice;
        int maxPrice;
        string description;
        int userID;
        bool isBusy;

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
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }
        public string Category
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }
        public int MinPrice
        {
            get
            {
                return minPrice;
            }
            set
            {
                minPrice = value;
            }
        }
        public int MaxPrice
        {
            get
            {
                return maxPrice;
            }
            set
            {
                maxPrice = value;
            }
        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
        public int UserID
        {
            get
            {
                return userID;
            }
            set
            {
                userID = value;
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

        public Command OnRequestButtonClicked
        {
            get;
        }

        async Task SaveRequest()
        {
            //IsBusy = true;

            await App.Database.SaveUserRequestAsync(new UserRequest
            {
                RequestID = RequestID++,
                Country = Country,
                Category = Category,
                minPrice = MinPrice,
                maxPrice = MaxPrice,
                Description = Description
            });

            //IsBusy = false;
            Application.Current.MainPage = new NavigationPage(new About2Page());


        }

    }

}
