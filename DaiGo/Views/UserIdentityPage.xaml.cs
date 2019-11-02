using DaiGo.ViewModels;

using Xamarin.Forms;

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