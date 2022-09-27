using Login.Models;
using Login.ViewModels;
using Login.Views.JuegosE;
using Login.Views.JuegosMemoria;
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
    public partial class JuegoE : ContentPage
    {
        public string NombreJugador;
        public string FotoJugador;
        public JuegoE(string n, string a)
        {
            InitializeComponent();
            BindingContext = new JuegoMemoriaVM();

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
                var _clickJuego = _clickJuegos[i] as JuegoMemoriaModels;

                //Navigation.ShowPopup(new ModalJugar());

                await Navigation.PushAsync(new LetraEI());

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
        private async void HomaBack(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new inicio());
            //Navigation.ShowPopup(new ModalSalirJuego(NombreJugador, FotoJugador));
        }
    }
}