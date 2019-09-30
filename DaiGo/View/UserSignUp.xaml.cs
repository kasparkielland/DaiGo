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
    public partial class UserSignUp : ContentPage
    {
        public UserSignUp()
        {
            InitializeComponent();
            if (Application.Current.Properties.ContainsKey("Email"))    
                email.Text = Application.Current.Properties["Email"].ToString();
        }

        private void OnChange(object sender, EventArgs e)
        {
            Application.Current.Properties["Email"] = email.Text;
            Application.Current.Properties["Nickname"] = nickname.Text;
            Application.Current.SavePropertiesAsync();
        }


        
    }
}