using DaiGo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DaiGo.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserMessagePage : ContentPage
    {
        public UserMessagePage()
        {
            InitializeComponent();
            UserMessageListView.ItemsSource = new List<AgentQuote>
            {
                new AgentQuote { QuoteID = "005", QuoteAmount = "AUD300", AgentID = "090", RequestID = "LV serial 003" },
                new AgentQuote { QuoteID = "006", QuoteAmount = "USD30", AgentID = "090", RequestID = "BlackMore FishOil 1000mg" }
            };
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}