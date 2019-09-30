using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using DaiGo.ViewModels;

namespace DaiGo
{
    public partial class App : Application
    {

        static Database database;

        public static Database Database
        {
            get
            {
                if (database == null)
                {
                    database = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "daigo.db3"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new View.UserLoginPage());
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD

=======
>>>>>>> parent of 7cae416... I have change Agent Page and related message page
=======
>>>>>>> parent of 7cae416... I have change Agent Page and related message page
=======
>>>>>>> parent of 7cae416... I have change Agent Page and related message page
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }


    }
}
