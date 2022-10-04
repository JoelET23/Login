using Android.Content;
using Login.Models;
using Login.ViewModels;
using Login.Views.JuegosNumeros;
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
        public string NombreJugador;
        public string FotoJugador;
        public Juegos(string n, string a)
        {
            InitializeComponent();
            BindingContext = new juegosVM();

            NombreUser.Text = n;
            FotoUser.Source = a;

            NombreJugador = n;
            FotoJugador = a;

            TouchJuego.SelectionChanged += TouchJuego_SelectionChanged;
        }

        private async void TouchJuego_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var _clickJuegos = e.CurrentSelection;
            for (int i = 0; i < _clickJuegos.Count; i++)
            {
                var _clickJuego = _clickJuegos[i] as JuegoModels;
                var IdJuego = _clickJuego.Id;

                if(IdJuego == 1)
                {
                    await Navigation.PushAsync(new JuegoMemoria(NombreJugador, FotoJugador));
                }
                else if (IdJuego == 2)
                {
                    //await Navigation.PushAsync(new JuegoTrazo());
                    await Navigation.PushAsync(new InicioModuloView());
                }
                else if (IdJuego == 3)
                {
                    await Navigation.PushAsync(new JuegoE(NombreJugador, FotoJugador));
                }
                else if (IdJuego == 4)
                {
                    await Navigation.PushAsync(new CeroCinco());
                }
                
                /*Intent intent = new Intent((Context)_clickJuego.NombreJuego, typeof(Juegos));
                DisplayAlert("Prueba", msg, "OK");*/
            }
        }

        private async void BackList(object sender, EventArgs e)
        {
            //Application.Current.MainPage = new inicio();
            await Navigation.PushAsync(new inicio());
            /*await Task.WhenAll(
                btnisvis.RotateTo(360, 1000),
                btnisvis.FadeTo(0, 500)
            );*/
        }
        private async void SalirApp(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new inicio());
        }
    }
}