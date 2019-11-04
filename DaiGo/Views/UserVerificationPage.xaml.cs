using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DaiGo.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DaiGo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserVerificationPage : ContentPage
    {
        private UserVerificationViewModel userVerificationViewModel;

        public UserVerificationPage()
        {
            InitializeComponent();
            userVerificationViewModel = new UserVerificationViewModel();
            userVerificationViewModel.navigation = Navigation;
            this.BindingContext = userVerificationViewModel;
        }
    }
}