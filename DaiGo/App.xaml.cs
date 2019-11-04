using System;
using Xamarin.Forms;
using System.IO;
using DaiGo.ViewModels;
using DaiGo.Views;

namespace DaiGo
{
    public partial class App : Application
    {
        static Database database;
		public static string User = "Rendy";
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

            MainPage = new NavigationPage(new ChatPage());

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
