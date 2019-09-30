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
        public ICommand SendQuoteCommand { get; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Offer;
            Item = item;
            SendQuoteCommand = new Command(ToAboutClicked);
        }
        void ToAboutClicked()
        {
            Application.Current.MainPage = new NavigationPage(new AboutPage());
        }
    }
}
