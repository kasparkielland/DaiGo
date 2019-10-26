using System;
using DaiGo.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DaiGo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserSignUp : ContentPage
    {
        private UserSignUpViewModel userSignUpViewModel;


        public UserSignUp()
        {
            InitializeComponent();
            userSignUpViewModel = new UserSignUpViewModel();
            this.BindingContext = userSignUpViewModel;

            usernameEntry.Completed += (object sender, EventArgs e) =>
            {
                passwordEntry.Focus();
            };

            passwordEntry.Completed += (object sender, EventArgs e) =>
            {
                passwordReEntry.Focus();
            };

            passwordReEntry.Completed += (object sender, EventArgs e) =>
            {
                firstnameEntry.Focus();
            };

            firstnameEntry.Completed += (object sender, EventArgs e) =>
            {
                lastnameEntry.Focus();
            };

            lastnameEntry.Completed += (object sender, EventArgs e) =>
            {
                emailEntry.Focus();
            };

            emailEntry.Completed += (object sender, EventArgs e) =>
            {
                phonenumberEntry.Focus();
            };

            phonenumberEntry.Completed += (object sender, EventArgs e) =>
            {
                userSignUpViewModel.SignUpCommand.Execute(null);
            };
        }

    }
}