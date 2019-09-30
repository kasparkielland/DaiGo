using DaiGo.View;
using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace DaiGo.ViewModels
{
    class About2ViewModel : BaseViewModel
    {
        public ICommand GoHomeCommand { get; }
        public About2ViewModel()
        {
            Title = "About2";
            this.GoHomeCommand = new Command(this.GoHomeClicked);
                     
        }
        void GoHomeClicked()
        {
            Application.Current.MainPage = new NavigationPage(new UserMainPage());
        }
        
    }
}
