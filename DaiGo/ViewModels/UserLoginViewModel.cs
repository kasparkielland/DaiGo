using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace DaiGo.ViewModels
{
    public class UserLoginViewModel : INotifyPropertyChanged
    {
        public UserLoginViewModel()
        {
            LoginCommand = new Command(OnLogin);
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        private void OnLogin()
        {
            if (string.IsNullOrEmpty(Username))
            {
                MessagingCenter.Send(this, "LoginAlert", Username);
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
        public ICommand LoginCommand { get; set; }
    }

    // Example to Login handling (https://docs.microsoft.com/nb-no/xamarin/xamarin-forms/app-fundamentals/navigation/hierarchical)
    //async void OnLoginButtonClicked(object sender, EventArgs e)
    //{
    //    var isValid = AreCredentialsCorrect(user);
    //    if (isValid)
    //    {
    //        App.IsUserLoggedIn = true;
    //        Navigation.InsertPageBefore(new MainPage(), this);
    //        await Navigation.PopAsync();
    //    }
    //    else
    //    {
    //        // Login failed
    //    }
    //}
}
