using DaiGo.Views;
using System.Windows.Input;
using Xamarin.Forms;
using System.Threading.Tasks;
using DaiGo.Models;

namespace DaiGo.ViewModels
{
    class EditRequestViewModel : BaseViewModel
    {
        private string subject;
        public string Subject;
        private string country;
        private string category;
        private int minPrice;
        private int maxPrice;
        private string description;
        private UserRequest thisUserRequest;
        public ICommand GoUserVerificationCommand { get; set;}
        public ICommand GoUserMainCommand { get;set; }
        public ICommand OnCategoryFrameClicked{get; set;}
        public EditRequestViewModel()
        {
            thisUserRequest = new UserRequest
            {
                Subject = UserMainViewModel.Subject, 
                Country = country, 
                MinPrice = minPrice,
                MaxPrice = maxPrice, 
                Category = category,
                Description = description,
                UserID = LoginViewModel.UserID

            };   
            this.OnCategoryFrameClicked = new Command(GoCategory);
            this.GoUserVerificationCommand = new Command(async () => await SaveRequest());
          //                              () => !isBusy);
            this.GoUserMainCommand = new Command(BackClicked);
        }

        void BackClicked()
        {
            Application.Current.MainPage = new NavigationPage(new UserMainPage());
        }

        //int requestID;
       
        // int userID;
        //bool isBusy;

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
                SetProperty(description, value);
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
 

        public GoCategory()
        {
           //Category page has not yet established 

           //Application.Current.MainPage = new NavigationPage(new CategoryPage());
        }

        async Task SaveRequest()
        {
             await App.Database.SaveUserRequestAsync(thisUserRequest);
            //IsBusy = false;
            Application.Current.MainPage = new NavigationPage(new UserVerificationPage());
        }

    }

}
