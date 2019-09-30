using DaiGo.View;
using DaiGo.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DaiGo.ViewModels
{
    class EditRequestViewModel:BaseViewModel
    {
        public ICommand GoAbout2Command { get; }
        public ICommand GoUserMainCommand { get; }
        public EditRequestViewModel()
        {
            this.GoAbout2Command = new Command(SendRequestClicked);
            this.GoUserMainCommand = new Command(BackClicked);
        }
        void SendRequestClicked()
        {
            Application.Current.MainPage = new NavigationPage(new About2Page());
        }
        void BackClicked()
        {
            Application.Current.MainPage = new NavigationPage(new UserMainPage());
        }
    }
}
