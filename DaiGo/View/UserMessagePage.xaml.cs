﻿using DaiGo.Models;
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
    public partial class UserMessagePage : ContentPage
    {
        public UserMessagePage()
        {
            InitializeComponent();
            UserMessageListView.ItemsSource = new List<AgentQuote>
            {
            };
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}