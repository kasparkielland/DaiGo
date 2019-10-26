using DaiGo.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DaiGo.ViewModels
{
    class SignUpPageViewModel : INotifyPropertyChanged
    {
        public ICommand GoBack { get; set; }
        public ICommand SignUpCommand { get; set; }

        public SignUpPageViewModel()
        {
            GoBack = new Command(BackClicked);
            SignUpCommand = new Command(OnSignUp);
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        void BackClicked()
        {
            //Application.Current.MainPage.Navigation.PopAsync();
            Application.Current.MainPage = new NavigationPage(new LoginPage());
        }

        void OnSignUp()
        {
            //Application.Current.MainPage.Navigation.PushAsync(new LoginPage());
            Application.Current.MainPage = new NavigationPage(new LoginPage());
        }
    }
}
