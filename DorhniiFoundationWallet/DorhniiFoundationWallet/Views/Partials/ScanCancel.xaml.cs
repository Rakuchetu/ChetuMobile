﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DorhniiFoundationWallet.Views.Partials
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ScanCancel : ContentView
    {
        public ScanCancel()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await App.Current.MainPage.Navigation.PopModalAsync();
        }
    }
}