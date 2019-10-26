using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using DaiGo.Views;
using Xamarin.Forms;

namespace DaiGo.ViewModels
{
    public class UserLoginViewModel : INotifyPropertyChanged
    {
        public ICommand executeLogin { get; set; }
        public ICommand executeSignUp { get; set; }
        public ICommand directLogin { get; set; }

        private ICommand executeLoginCommand { get; set; }

        public UserLoginViewModel()
        {
            executeLogin = new Command(checkCredentials);
            executeSignUp = new Command(OnSignup);
            directLogin = new Command(OnLogin);
            this.executeLoginCommand = new Command(async () => await LoginClicked());

        }


        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        void checkCredentials()
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
                OnLogin();
            }
        }

        void OnLogin()
        {
            Application.Current.MainPage = new NavigationPage(new UserMainPage());
        }

        void OnSignup()
        {
            Application.Current.MainPage = new NavigationPage(new SignUpPage());
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
        async Task LoginClicked()
        {
            Application.Current.MainPage = new NavigationPage(new EditRequest());

        }
    }

}
