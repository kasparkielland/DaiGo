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
            };



        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}