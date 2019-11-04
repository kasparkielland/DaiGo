using DaiGo.Models;
using DaiGo.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
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
        private string phonenumber;

        public INavigation navigation { get; set; }

        public ICommand GoBackCommand { get; set; }
        public ICommand SignUpCommand { get; set; }
        public UserProfile userProfile;
        public SignUpPageViewModel()
        {
            GoBackCommand = new Command(async () => await BackClicked());
            SignUpCommand = new Command(async () => await OnSignUp());
            userProfile = new UserProfile
            {
                UserName = username,
                Password = password,
                FirstName = firstname,
                LastName = lastname,
                Email = email,
                Phonenumber = phonenumber
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
        public string Phonenumber
        {
            get => phonenumber;
            set
            {
                SetProperty(ref phonenumber, value);
            }
        }
        private async Task BackClicked()
        {
            await navigation.PopToRootAsync(false);
            //Application.Current.MainPage = new NavigationPage(new LoginPage());
        }

        private async Task OnSignUp()
        {
            await App.Database.SaveUserProfileAsync(userProfile);
            await navigation.PopToRootAsync(false);
            //Application.Current.MainPage = new NavigationPage(new LoginPage());
        }
    }
}
