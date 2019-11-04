using DaiGo.Views;
using System;
using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Forms;

namespace DaiGo.ViewModels
{
    class UserVerificationViewModel : BaseViewModel
    {
        public INavigation navigation { get; set; }
        public ICommand GoHomeCommand { get; set; }
        public UserVerificationViewModel()
        {
            Title = "UserVerification";
            this.GoHomeCommand = new Command(async () => await GoHomeClicked());

        }
        private async Task GoHomeClicked()
        {
            await navigation.PopToRootAsync(false);
            //Application.Current.MainPage = new NavigationPage(new UserMainPage());
        }

    }
}
