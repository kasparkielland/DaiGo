using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using DaiGo.Models;
using DaiGo.Views;
using FormsControls.Base;
using Xamarin.Forms;
using System.Collections.Generic;

namespace DaiGo.ViewModels
{
    //public class LoginViewModel : INotifyPropertyChanged
    public class LoginViewModel : BaseViewModel
    {
        private string username;
        private string password;
        private int userID;
        public int UserID;
            

        public ICommand executeLogin { get; set; }
        public ICommand executeSignUp { get; set; }
        public ICommand directLogin { get; set; }
        //public IPageAnimation MyPageAnimation { get; set; }

        public LoginViewModel()
        {
            //this.Username = username;
            //this.UserID = userID;
            executeLogin = new Command(CheckCredentials);
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

    
    //   public event PropertyChangedEventHandler PropertyChanged = delegate { };

        void CheckCredentials()
        {
          
                if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
                {
                    App.Current.MainPage.DisplayAlert("Oops", "Entry cannot be empty", "OK");
                }
                //if (string.IsNullOrEmpty(Username))
                //{
                //    MessagingCenter.Send(this, "LoginAlert", Username);
                //}
                //else if (string.IsNullOrEmpty(Password))
                //{
                //    MessagingCenter.Send(this, "LoginAlert", Password);
                //}
                else
                {
                    OnLogin();
                }
            
        }

        async void OnLogin()
        {
            try
            {   
                var userProfileList = await App.Database.FindUserProfileAsync(username, password);
                if (userProfileList != null)
                {
                    foreach (var user in userProfileList)
                    {
                        userID = user.UserID;
                    }
                   
                    Application.Current.MainPage = new NavigationPage(new UserMainPage());
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Oops", "Incorrect credientials entered", "OK");
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine($"Sorry, there is an error: {ex.Message}");
            }

        }

        void OnSignup()
        {
            Application.Current.MainPage = new NavigationPage(new SignUpPage());
        }

   //     public string username;
        public string Username
        {
            get { return username; }
            set
            {
                //username = value;
                //PropertyChanged(this, new PropertyChangedEventArgs("Username"));
                SetProperty(ref username, value);
            }
        }
        
    //    public string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                //PropertyChanged(this, new PropertyChangedEventArgs("Password"));
                SetProperty(ref password, value);
            }
        }
    }
}