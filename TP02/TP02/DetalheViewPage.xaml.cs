﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP02
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalheViewPage : ContentPage
    {
        public DetalheViewPage()
        {
            InitializeComponent();
        }
        async void btnVoltar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
        
    }
}