using DaiGo.Views;
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
    public partial class UserIdentityPage : ContentPage
    {
        public UserIdentityViewModel userIdentityViewModel;

        public UserIdentityPage()
        {
            InitializeComponent();
            userIdentityViewModel = new UserIdentityViewModel();
            this.BindingContext = userIdentityViewModel;

        }
    }
}