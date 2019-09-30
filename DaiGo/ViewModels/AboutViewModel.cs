using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace DaiGo.ViewModels
{
<<<<<<< HEAD
    //public class AboutViewModel : BaseViewModel
    //{
    //    public AboutViewModel()
    //    {
    //        Title = "About";

    //        OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
    //    }

    //    public ICommand OpenWebCommand { get; }
    //}
=======
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }

        public ICommand OpenWebCommand { get; }
    }
>>>>>>> parent of 7cae416... I have change Agent Page and related message page
}