using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using DaiGo.Models;
using DaiGo.Views;
using System.Windows.Input;

namespace DaiGo.ViewModels
{
    public class AgentMainViewModel : BaseViewModel
    {
        public ObservableCollection<Item> Items { get; set; }
        public Command LoadItemsCommand { get; set; }

        public ICommand GoAgentProfileCommand { get; set; }
        public ICommand GoAgentMessageCommand { get; set; }

        public INavigation navigation { get; set; }

        public AgentMainViewModel()
        {
            Title = "Browse";
            Items = new ObservableCollection<Item>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            //MessagingCenter.Subscribe<NewItemPage, Item>(this, "AddItem", async (obj, item) =>
            //{
            //    var newItem = item as Item;
            //    Items.Add(newItem);
            //    await DataStore.AddItemAsync(newItem);
            //});
            this.GoAgentProfileCommand = new Command(async () => await AgentIconClicked());
            this.GoAgentMessageCommand = new Command(async () => await MessageIconClicked());
        }
        private async Task AgentIconClicked()
        {
            await navigation.PushAsync(new AgentIdentityPage());
            //Application.Current.MainPage = new NavigationPage(new AgentIdentityPage());
        }
        private async Task MessageIconClicked()
        {
            await navigation.PushAsync(new AgentMessagePage());
            //Application.Current.MainPage = new NavigationPage(new AgentMessagePage());
        }
        private async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Items.Clear();
                var items = await DataStore.GetItemsAsync(true);
                foreach (var item in items)
                {
                    Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}