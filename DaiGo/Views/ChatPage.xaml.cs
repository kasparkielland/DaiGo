using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DaiGo.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DaiGo.Views
{

    public partial class ChatPage : ContentPage
    {
        private ChatPageViewModel chatPageViewModel;

        public ChatPage()
        {
            InitializeComponent();
            chatPageViewModel = new ChatPageViewModel();
            chatPageViewModel.navigation = Navigation;
            this.BindingContext = chatPageViewModel;
        }

        public void ScrollTap(object sender, System.EventArgs e)
        {
            lock (new object())
            {
                if (BindingContext != null)
                {
                    var vm = BindingContext as ChatPageViewModel;

                    Device.BeginInvokeOnMainThread(() =>
                    {
                        while (vm.DelayedMessages.Count > 0)
                        {
                            vm.Messages.Insert(0, vm.DelayedMessages.Dequeue());
                        }
                        vm.ShowScrollTap = false;
                        vm.LastMessageVisible = true;
                        vm.PendingMessageCount = 0;
                        ChatList?.ScrollToFirst();
                    });


                }

            }
        }

        public void OnListTapped(object sender, ItemTappedEventArgs e)
        {
            chatInput.UnFocusEntry();
        }
    }
}