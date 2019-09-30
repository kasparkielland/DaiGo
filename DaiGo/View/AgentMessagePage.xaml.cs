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
    public partial class AgentMessagePage : ContentPage
    {
        public AgentMessagePage()
        {
            InitializeComponent();

            AgentMessageListView.ItemsSource = new List<UserRequest>
            {
                new UserRequest { RequestID = "LV serial 003", Request = "Can you hand deliver?", UserID="003" },       
                new UserRequest { RequestID = "BlackMore FishOil 1000mg" , Request= "no more than USD300", UserID="033"}
            };



        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}