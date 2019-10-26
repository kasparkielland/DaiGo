using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using DaiGo.Views;
using FormsControls.Base;
using Xamarin.Forms;

namespace DaiGo.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public ICommand executeLogin { get; set; }
        public ICommand executeSignUp { get; set; }
        public ICommand directLogin { get; set; }
        //public IPageAnimation MyPageAnimation { get; set; }

        public LoginViewModel()
        {
            executeLogin = new Command(checkCredentials);
            executeSignUp = new Command(OnSignup);
            directLogin = new Command(OnLogin);

            //TODO: Look into PageAnimation (see https://github.com/AlexandrNikulin/AnimationNavigationPage)
            //      Installation = done, Declaration = REDO!!, Create = DO!!
            //MyPageAnimation = new FlipPageAnimation()
            //{
            //    Duration = AnimationDuration.Long,
            //    Subtype = AnimationSubtype.FromRight
            //};

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
    }
}