using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using DaiGo.Models;
using DaiGo.ViewModels;

namespace DaiGo.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel itemDetailViewModel;

        public ItemDetailPage(ItemDetailViewModel itemDetailViewModel)
        {
            InitializeComponent();
            itemDetailViewModel.navigation = Navigation;
            BindingContext = this.itemDetailViewModel = itemDetailViewModel;
        }

        public ItemDetailPage()
        {
            InitializeComponent();

            var item = new Item
            {

                Description = "This is an item description.",
                Offer = "User Offer Price"
            };
            itemDetailViewModel.navigation = Navigation;
            itemDetailViewModel = new ItemDetailViewModel(item);
            BindingContext = itemDetailViewModel;
        }
    }
}