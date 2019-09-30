using DaiGo.View;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DaiGo.ViewModels
{
    class UserSignUpViewModel:BaseViewModel
    {
        public ICommand GoMainCommand { get; }
        public UserSignUpViewModel()
        {
            Title = "User Signup Page";
            this.GoMainCommand = new Command(SignUpClicked);
        }

        void SignUpClicked()
        {
            Application.Current.MainPage = new NavigationPage(new UserMainPage());
        }
    }
}
