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
    public class LoginViewModel : BaseViewModel, INotifyPropertyChanged
    {
        private string username;
        private string password;
        private int userID;
        public int UserID;

        public INavigation navigation { get; set; }

        public ICommand executeLogin { get; set; }
        public ICommand executeSignUp { get; set; }
        public ICommand directLogin { get; set; }
        //public IPageAnimation MyPageAnimation { get; set; }

        public LoginViewModel()
        {
            //this.Username = username;
            // this.UserID = userID;
            executeLogin = new Command(async () => await CheckCredentials());
            executeSignUp = new Command(async () => await OnSignup());
            directLogin = new Command(async () => await OnLogin());

            //TODO: Look into PageAnimation (see https://github.com/AlexandrNikulin/AnimationNavigationPage)
            //      Installation = done, Declaration = REDO!!, Create = DO!!
            //MyPageAnimation = new FlipPageAnimation()
            //{
            //    Duration = AnimationDuration.Long,
            //    Subtype = AnimationSubtype.FromRight
            //};

        }


        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        async Task CheckCredentials()
        {

            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                await App.Current.MainPage.DisplayAlert("Oops", "Entry cannot be empty", "OK");
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
                await OnLogin();
            }

        }

        async Task OnLogin()
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
                    await navigation.PushAsync(new UserMainPage());
                    navigation.RemovePage(navigation.NavigationStack[0]);
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Oops", "Incorrect credientials entered", "OK");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Sorry, there is an error: {ex.Message}");
            }

        }

        private async Task OnSignup()
        {
            await navigation.PushAsync(new SignUpPage());
        }

        public void InsertPageBefore(Page page, Page before)
        {
            throw new NotImplementedException();
        }

        public Task<Page> PopAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Page> PopAsync(bool animated)
        {
            throw new NotImplementedException();
        }

        public Task<Page> PopModalAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Page> PopModalAsync(bool animated)
        {
            throw new NotImplementedException();
        }

        public Task PopToRootAsync()
        {
            throw new NotImplementedException();
        }

        public Task PopToRootAsync(bool animated)
        {
            throw new NotImplementedException();
        }

        public Task PushAsync(Page page)
        {
            throw new NotImplementedException();
        }

        public Task PushAsync(Page page, bool animated)
        {
            throw new NotImplementedException();
        }

        public Task PushModalAsync(Page page)
        {
            throw new NotImplementedException();
        }

        public Task PushModalAsync(Page page, bool animated)
        {
            throw new NotImplementedException();
        }

        public void RemovePage(Page page)
        {
            throw new NotImplementedException();
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

        public IReadOnlyList<Page> ModalStack => throw new NotImplementedException();

        public IReadOnlyList<Page> NavigationStack => throw new NotImplementedException();
    }
}