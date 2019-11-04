using DaiGo.Views;
using System;
using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Forms;

namespace DaiGo.ViewModels
{
    public class AgentVerificationViewModel : BaseViewModel
    {
        public ICommand GoHomeCommand { get; }

        public INavigation navigation { get; set; }

        public AgentVerificationViewModel()
        {
            Title = "AgentVerification";
            this.GoHomeCommand = new Command(async () => await GoHomeClicked());

        }
        private async Task GoHomeClicked()
        {
            await navigation.PopToRootAsync(false);
            //Application.Current.MainPage = new NavigationPage(new AgentMainPage());
        }

    }
}