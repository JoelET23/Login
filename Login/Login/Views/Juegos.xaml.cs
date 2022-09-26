﻿using Android.Content;
using Login.Models;
using Login.ViewModels;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Login.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Juegos : ContentPage
    {
        public Juegos(string n, string a)
        {
            InitializeComponent();
            BindingContext = new juegosVM();

            NombreUser.Text = n;
            FotoUser.Source = a;

            TouchJuego.SelectionChanged += TouchJuego_SelectionChanged;
        }

        private async void TouchJuego_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var _clickJuegos = e.CurrentSelection;
            for (int i = 0; i < _clickJuegos.Count; i++)
            {
                var _clickJuego = _clickJuegos[i] as JuegoModels;
                await Navigation.PushAsync(new JuegoMemoria("dom", "dem"));
                /*Intent intent = new Intent((Context)_clickJuego.NombreJuego, typeof(Juegos));
                DisplayAlert("Prueba", msg, "OK");*/
            }
        }

        private async void BackList(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new inicio());
        }
        private async void SalirApp(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new inicio());
        }
    }
}