using System;
using DaiGo.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DaiGo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPage : ContentPage
    {
        private SignUpPageViewModel SignUpPageViewModel;


        public SignUpPage()
        {
            InitializeComponent();
            SignUpPageViewModel = new SignUpPageViewModel();
            this.BindingContext = SignUpPageViewModel;

            //usernameEntry.Completed += (object sender, EventArgs e) =>
            //{
            //    passwordEntry.Focus();
            //};

            //passwordEntry.Completed += (object sender, EventArgs e) =>
            //{
            //    passwordReEntry.Focus();
            //};

            //passwordReEntry.Completed += (object sender, EventArgs e) =>
            //{
            //    firstnameEntry.Focus();
            //};

            //firstnameEntry.Completed += (object sender, EventArgs e) =>
            //{
            //    lastnameEntry.Focus();
            //};

            //lastnameEntry.Completed += (object sender, EventArgs e) =>
            //{
            //    emailEntry.Focus();
            //};

            //emailEntry.Completed += (object sender, EventArgs e) =>
            //{
            //    phonenumberEntry.Focus();
            //};

            //phonenumberEntry.Completed += (object sender, EventArgs e) =>
            //{
            //    SignUpPageViewModel.SignUpCommand.Execute(null);
            //};
        }

        private void UsernameEntry_Completed(object sender, EventArgs e)
        {
            passwordEntry.Focus();
        }

        private void PasswordEntry_Completed(object sender, EventArgs e)
        {
            passwordReEntry.Focus();
        }

        private void PasswordReEntry_Completed(object sender, EventArgs e)
        {
            if (Equals(passwordReEntry.Text, passwordEntry.Text))
            {
                firstnameEntry.Focus();
            }
            else
            {
                DisplayAlert("Oops", "Inconsistency occur!", "Enter password agian");
                passwordEntry.Focus();
            }
        }

        private void FirstnameEntry_Completed(object sender, EventArgs e)
        {
            lastnameEntry.Focus();
        }

        private void LastnameEntry_Completed(object sender, EventArgs e)
        {
            emailEntry.Focus();
        }

        private void EmailEntry_Completed(object sender, EventArgs e)
        {
            phonenumberEntry.Focus();
        }

        private void PhonenumberEntry_Completed(object sender, EventArgs e)
        {
            Signupbutton.Focus();
        }
    }
}