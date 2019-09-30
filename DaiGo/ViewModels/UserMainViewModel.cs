using DaiGo.View;
using DaiGo.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DaiGo.ViewModels
{
    class UserMainViewModel : BaseViewModel
    {
        public ICommand GoEditRequestCommand { get; }
        public ICommand GoProfileCommand { get; }
        public ICommand GoMessageCommand { get; }
        public UserMainViewModel()
        {
            Title = "User Main Page";
            this.GoProfileCommand = new Command(ProfileClicked);
            this.GoMessageCommand = new Command(MessageClicked);
            this.GoEditRequestCommand = new Command(SearchClicked);

        }
        void ProfileClicked()
        {
            Application.Current.MainPage = new NavigationPage(new UserIdentityPage());
        }
        void MessageClicked()
        {
            Application.Current.MainPage = new NavigationPage(new NewItemPage());
        }
        void SearchClicked()
        {
            Application.Current.MainPage = new NavigationPage(new EditRequest());
        }

    }
}
