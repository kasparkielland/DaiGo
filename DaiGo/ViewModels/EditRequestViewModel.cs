using DaiGo.Views;
using System.Windows.Input;
using Xamarin.Forms;
using System.Threading.Tasks;
using DaiGo.Models;

namespace DaiGo.ViewModels
{
    class EditRequestViewModel : BaseViewModel
    {


        private string country;
        private string category;
        private int minPrice;
        private int maxPrice;
        private string description;
        private UserRequest thisUserRequest;
        public UserMainViewModel userMainViewModel = new UserMainViewModel();
        public LoginViewModel loginViewModel = new LoginViewModel();

        public INavigation navigation { get; set; }

        public ICommand GoUserVerificationCommand { get; set; }
        public ICommand GoUserMainCommand { get; set; }
        public ICommand OnCategoryFrameClicked { get; set; }
        public EditRequestViewModel()
        {

            thisUserRequest = new UserRequest
            {
                Subject = userMainViewModel.Subject,
                //Country = country, 
                //MinPrice = minPrice,
                //MaxPrice = maxPrice, 
                //Category = category,
                //Description = description,
                //UserID = loginViewModel.UserID

            };
            this.OnCategoryFrameClicked = new Command(async () => await GoCategory());
            this.GoUserVerificationCommand = new Command(async () => await SaveRequest());
            this.GoUserMainCommand = new Command(async () => await BackClicked());
        }

        private async Task BackClicked()
        {
            await navigation.PopToRootAsync(false);
            //Application.Current.MainPage = new NavigationPage(new UserMainPage());
        }

        int requestID;
        string subject;
        //string country;
        //string category;
        //int minPrice;
        //int maxPrice;
        //string description;
        int userID;
        bool isBusy;

        //public int RequestID
        //{
        //    get
        //    {
        //        return requestID;
        //    }
        //    set
        //    {
        //        requestID = value;
        //    }
        //}

        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                SetProperty(ref country, value);
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
                SetProperty(ref minPrice, value);
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
                SetProperty(ref maxPrice, value);
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
                SetProperty(ref description, value);
            }
        }
        //       public int UserID
        //       {
        //           get
        //           {
        //               return userID;
        //           }
        //           set
        //           {
        //               userID = value;
        //           }
        //       }


        private async Task GoCategory()
        {
            //Category page has not yet established 
            //navigation.PushAsync(new CategoryPage());

            //Application.Current.MainPage = new NavigationPage(new CategoryPage());
        }

        async Task SaveRequest()
        {
            await App.Database.SaveUserRequestAsync(thisUserRequest);
            //IsBusy = false;
            await navigation.PushAsync(new UserVerificationPage(), false);
            //Application.Current.MainPage = new NavigationPage(new UserVerificationPage());
        }

    }

}
