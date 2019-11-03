using DaiGo.Models;
using DaiGo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DaiGo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AgentMessagePage : ContentPage
    {
        private AgentMessageViewModel agentMessageViewModel;

        public AgentMessagePage()
        {
            InitializeComponent();
            agentMessageViewModel = new AgentMessageViewModel();
            agentMessageViewModel.navigation = Navigation;
            this.BindingContext = agentMessageViewModel;

            agentMessageListView.ItemsSource = new List<UserRequest>
            {
            };
        }
    }
}