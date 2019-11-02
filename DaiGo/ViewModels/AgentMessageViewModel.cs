using System;
using System.ComponentModel;
using System.Windows.Input;
using DaiGo.Views;
using Xamarin.Forms;

namespace DaiGo.ViewModels
{
    public class AgentMessageViewModel : INotifyPropertyChanged
    {
        public ICommand GoBackCommand { get; set; }

        public AgentMessageViewModel()
        {
            GoBackCommand = new Command(BackClicked);

        }
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        void BackClicked()
        {
            Application.Current.MainPage = new NavigationPage(new AgentMainPage());
        }
    }
}
