﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Login
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ModalBien : Popup
    {
        public ModalBien()
        {
            InitializeComponent();
        }
        void Button_Clicked(Object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new FrutasI());
            Dismiss(null);
        }
    }
}