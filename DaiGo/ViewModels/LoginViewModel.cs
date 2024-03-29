﻿using System;
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
        public ICommand executeForgotPassword { get; set; }
        public ICommand GoogleButtonCommand { get; set; }
        public ICommand FacebookButtonCommand { get; set; }
        //public IPageAnimation MyPageAnimation { get; set; }

        public LoginViewModel()
        {
            //this.Username = username;
            // this.UserID = userID;
            executeLogin = new Command(async () => await CheckCredentials());
            executeSignUp = new Command(async () => await OnSignup());
            directLogin = new Command(async () => await OnLogin());
            executeForgotPassword = new Command(async () => await OnForgotPassword());
            GoogleButtonCommand = new Command(async () => await OnGoogleLogin());
            FacebookButtonCommand = new Command(async () => await OnFacebookLogin());


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
                    await navigation.PushAsync(new UserMainPage(), false);
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
            await navigation.PushAsync(new SignUpPage(), false);
        }

        private async Task OnForgotPassword()
        {
            //TODO
            //Change for 'Forgot Password'
            await App.Current.MainPage.DisplayAlert("Reset Password", "So you want to reset your password?", "Yes");
        }

        private async Task OnGoogleLogin()
        {
            //TODO
            //Change for 'Google login'
            await App.Current.MainPage.DisplayAlert("Login with Google", "This logs you in with Google", "Cool");
        }
        private async Task OnFacebookLogin()
        {
            //TODO
            //Change for 'Google login'
            await App.Current.MainPage.DisplayAlert("Login with Facebook", "This logs you in with Facebook", "Cool");
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