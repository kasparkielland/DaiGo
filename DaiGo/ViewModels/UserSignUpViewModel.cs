using DaiGo.View;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DaiGo.ViewModels
{
    class UserSignUpViewModel : BaseViewModel
    {
        public new ICommand GoBack { private get; set; }
        public UserSignUpViewModel()
        {
            this.GoBack = new Command(BackClicked);
        }

        void BackClicked()
        {
            Application.Current.MainPage = new NavigationPage(new UserLoginPage());
        }
    }
}
