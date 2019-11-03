using System;
using System.ComponentModel;
using Xamarin.Forms;

using DaiGo.Models;
using DaiGo.ViewModels;

namespace DaiGo.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class AgentMainPage : ContentPage
    {
        public AgentMainViewModel agentMainViewModel;

        public AgentMainPage()
        {
            InitializeComponent();
            agentMainViewModel = new AgentMainViewModel();
            agentMainViewModel.navigation = Navigation;
            this.BindingContext = agentMainViewModel;
        }
        //TODO
        // Put following code in VM
        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Item;
            if (item == null)
                return;

            await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(item)));

            // Manually deselect item.
            ItemsListView.SelectedItem = null;
        }

        //async void AddItem_Clicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushModalAsync(new NavigationPage(new NewItemPage()));
        //}

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (agentMainViewModel.Items.Count == 0)
                agentMainViewModel.LoadItemsCommand.Execute(null);
        }
    }
}