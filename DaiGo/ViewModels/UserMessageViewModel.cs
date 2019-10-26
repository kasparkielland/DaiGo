using System;
using System.ComponentModel;
using System.Windows.Input;
using DaiGo.Views;
using Xamarin.Forms;

namespace DaiGo.ViewModels
{
    public class UserMessageViewModel : INotifyPropertyChanged
    {
        public ICommand GoBack { get; set; }

        public UserMessageViewModel()
        {
            GoBack = new Command(BackClicked);

        }
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        void BackClicked()
        {
            Application.Current.MainPage = new NavigationPage(new UserMainPage());
        }

    }
}
