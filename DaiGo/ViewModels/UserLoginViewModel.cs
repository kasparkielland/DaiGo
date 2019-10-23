using System;
using System.ComponentModel;
using System.Windows.Input;
using DaiGo.View;
using Xamarin.Forms;

namespace DaiGo.ViewModels
{
    public class UserLoginViewModel : INotifyPropertyChanged
    {
        public new ICommand LoginCommand { get; set; }

        public UserLoginViewModel()
        {
            LoginCommand = new Command(OnLogin);
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        void OnLogin()
        {
            if (string.IsNullOrEmpty(Username))
            {
                MessagingCenter.Send(this, "LoginAlert", Username);
            }
            else if (string.IsNullOrEmpty(Password))
            {
                MessagingCenter.Send(this, "LoginAlert", Password);
            }
            else
            {
                Application.Current.MainPage = new NavigationPage(new UserMainPage());
            }
        }
        public string username;
        public string Username
        {
            get { return username; }
            set
            {
                username = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Username"));
            }
        }
        public string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Password"));
            }
        }
    }
}
