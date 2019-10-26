using System;
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
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Offer;
            Item = item;
            SendQuoteCommand = new Command(SendQuoteClicked);
            GoMainCommand = new Command(GoMainClicked);
        }
        void SendQuoteClicked()
        {
            Application.Current.MainPage = new NavigationPage(new AgentVerificationPage());
        }

        void GoMainClicked()
        {
            Application.Current.MainPage = new NavigationPage(new AgentMainPage());
        }
    }
}
