using DaiGo.Models;
using DaiGo.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DaiGo.ViewModels
{
    //class SignUpPageViewModel : INotifyPropertyChanged
    class SignUpPageViewModel : BaseViewModel
    {
        private string username;
        private string password;
        private string firstname;
        private string lastname;
        private string email;
        private string phone;

        public ICommand GoBackCommand { get; set; }
        public ICommand SignUpCommand { get; set; }
        public UserProfile userProfile { get; set; }
        public SignUpPageViewModel()
        {
            GoBackCommand = new Command(BackClicked);
            SignUpCommand = new Command(OnSignUp);
            userProfile = new UserProfile
            {
                UserName = username,
                Password = password,
                FirstName = firstname,
                LastName = lastname,
                Email = email,
                Phonenumber = phone
            };
        }

       // public event PropertyChangedEventHandler PropertyChanged = delegate { };
       public string Username
        {
            get => username;
            set
            {
                SetProperty(ref username, value);
            }
        }
        public string Password
        {
            get => password;
            set
            {
                SetProperty(ref password, value);
            }
        }
        public string Firstname
        {
            get => firstname;
            set
            {
                SetProperty(ref firstname, value);
            }
        }
        public string Lastname
        {
            get => lastname;
            set
            {
                SetProperty(ref lastname, value);
            }
        }
        public string Email
        {
            get => email;
            set
            {
                SetProperty(ref email, value);
            }
        }
        public string Phone
        {
            get => phone;
            set
            {
                SetProperty(ref phone, value);
            }
        }
        void BackClicked()

        {
   
            Application.Current.MainPage = new NavigationPage(new LoginPage());
        }

        async void OnSignUp()
        {
            await App.Database.SaveUserProfileAsync(userProfile);
            Application.Current.MainPage = new NavigationPage(new LoginPage());
        }
    }
}
