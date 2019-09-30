using System;
<<<<<<< HEAD
<<<<<<< HEAD
using System.ComponentModel;
using System.Runtime.CompilerServices;
using DaiGo.Models;
using DaiGo.Views;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace DaiGo.ViewModels
{
    public class EditRequestViewModel
    {
        public EditRequestViewModel()
        {
            OnRequestButtonClicked = new Command(async () => await SaveRequest(),
                                                () => !isBusy);

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
=======
namespace DaiGo.ViewModel
{
    public class EditRequestViewModell
    {
        public EditRequestViewModell()
        {
>>>>>>> parent of 7cae416... I have change Agent Page and related message page
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
                OnRequestButtonClicked.ChangeCanExecute();
            }
=======
namespace DaiGo.ViewModel
{
    public class EditRequestViewModell
    {
        public EditRequestViewModell()
        {
>>>>>>> parent of 7cae416... I have change Agent Page and related message page
        }

        public Command OnRequestButtonClicked
        {
            get;
        }

        async Task SaveRequest()
        {
            IsBusy = true;

            await App.Database.SaveUserRequestAsync(new UserRequst
            {
                RequestID = RequestID++,
                Country = Country,
                Category = Category,
                minPrice = MinPrice,
                maxPrice = MaxPrice,
                Description = Description
            });

            IsBusy = false;


        }

    }

}