using DaiGo.Views;
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
    public partial class AgentIdentityPage : ContentPage
    {
        public AgentIdentityPage()
        {
            InitializeComponent();
        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new UserIdentityPage());
        }
    }
}