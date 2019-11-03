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
    public partial class UserMessagePage : ContentPage
    {
        private UserMessageViewModel userMessageViewModel;


        public UserMessagePage()
        {
            InitializeComponent();
            userMessageViewModel = new UserMessageViewModel();
            userMessageViewModel.navigation = Navigation;
            this.BindingContext = userMessageViewModel;

        }
    }
}