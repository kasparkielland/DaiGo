using DaiGo.Views;
using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace DaiGo.ViewModels
{
    class UserVerificationViewModel : BaseViewModel
    {
        public ICommand GoHomeCommand { get; }
        public UserVerificationViewModel()
        {
            Title = "UserVerification";
            this.GoHomeCommand = new Command(this.GoHomeClicked);

        }
        void GoHomeClicked()
        {
            Application.Current.MainPage = new NavigationPage(new UserMainPage());
        }

    }
}
