using System;
using System.Threading.Tasks;
using System.Windows.Input;
using DaiGo.Models;
using DaiGo.Views;
using Xamarin.Forms;

namespace DaiGo.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }

        public ICommand SendQuoteCommand { get; set; }
        public ICommand GoMainCommand { get; set; }

        public INavigation navigation { get; set; }

        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Offer;
            Item = item;

            SendQuoteCommand = new Command(async () => await SendQuoteClicked());
            GoMainCommand = new Command(async () => await GoMainClicked());
        }
        private async Task SendQuoteClicked()
        {
            await navigation.PushAsync(new AgentVerificationPage(), false);
            //Application.Current.MainPage = new NavigationPage(new AgentVerificationPage());
        }

        private async Task GoMainClicked()
        {
            await navigation.PopToRootAsync(false);
            //Application.Current.MainPage = new NavigationPage(new AgentMainPage());
        }
    }
}
