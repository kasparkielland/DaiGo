﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DaiGo.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AgentIdentifyPage : ContentPage
    {
        public AgentIdentifyPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

        }
    }
}