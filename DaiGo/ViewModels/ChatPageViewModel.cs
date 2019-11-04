using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using DaiGo.Models;
using Xamarin.Forms;
using DaiGo.Views;

namespace DaiGo.ViewModels
{
	class ChatPageViewModel : INotifyPropertyChanged
	{

		public ICommand GoBack { get; set; }

		void BackClicked()
		{
			Application.Current.MainPage = new NavigationPage(new UserMainPage());
		}



		public bool ShowScrollTap { get; set; } = false;
		public bool LastMessageVisible { get; set; } = true;
		public int PendingMessageCount { get; set; } = 0;
		public bool PendingMessageCountVisible { get { return PendingMessageCount > 0; } }

		public Queue<Message> DelayedMessages { get; set; } = new Queue<Message>();
		public ObservableCollection<Message> Messages { get; set; } = new ObservableCollection<Message>();
		public string TextToSend { get; set; }
		public ICommand OnSendCommand { get; set; }
		public ICommand MessageAppearingCommand { get; set; }
		public ICommand MessageDisappearingCommand { get; set; }

		public ChatPageViewModel()
		{
			GoBack = new Command(BackClicked);


			Messages.Insert(0, new Message() { Text = "Hello" });
			Messages.Insert(0, new Message() { Text = "Hello, how are you going?", User = App.User });

			MessageAppearingCommand = new Command<Message>(OnMessageAppearing);
			MessageDisappearingCommand = new Command<Message>(OnMessageDisappearing);

			OnSendCommand = new Command(() =>
			{
				if (!string.IsNullOrEmpty(TextToSend))
				{
					Messages.Insert(0, new Message() { Text = TextToSend, User = App.User });
					TextToSend = string.Empty;
				}

			});




		}

		void OnMessageAppearing(Message message)
		{
			var idx = Messages.IndexOf(message);
			if (idx <= 6)
			{
				Device.BeginInvokeOnMainThread(() =>
				{
					while (DelayedMessages.Count > 0)
					{
						Messages.Insert(0, DelayedMessages.Dequeue());
					}
					ShowScrollTap = false;
					LastMessageVisible = true;
					PendingMessageCount = 0;
				});
			}
		}

		void OnMessageDisappearing(Message message)
		{
			var idx = Messages.IndexOf(message);
			if (idx >= 6)
			{
				Device.BeginInvokeOnMainThread(() =>
				{
					ShowScrollTap = true;
					LastMessageVisible = false;
				});

			}
		}


		public event PropertyChangedEventHandler PropertyChanged;

	}
}

