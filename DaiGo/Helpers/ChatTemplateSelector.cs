﻿using System;
using System.Collections.Generic;
using System.Text;
using DaiGo.Models;
using DaiGo.Views.Cells;
using Xamarin.Forms;

namespace DaiGo.Helpers
{
	class ChatTemplateSelector : DataTemplateSelector
	{
		DataTemplate incomingDataTemplate;
		DataTemplate outgoingDataTemplate;

		public ChatTemplateSelector()
		{
			this.incomingDataTemplate = new DataTemplate(typeof(IncomingViewCell));
			this.outgoingDataTemplate = new DataTemplate(typeof(OutgoingViewCell));
		}

		protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
		{
			var messageVm = item as Message;
			if (messageVm == null)
				return null;


			return (messageVm.User == App.User) ? outgoingDataTemplate : incomingDataTemplate;
		}

	}
}