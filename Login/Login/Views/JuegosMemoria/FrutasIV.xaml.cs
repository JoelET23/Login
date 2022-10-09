using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Login.Views.JuegosMemoria
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FrutasIV : ContentPage
    {
        public string NombreJugador;
        public string FotoJugador;
        public FrutasIV(string n, string a)
        {
            InitializeComponent();

            NombreJugador = n;
            FotoJugador = a;

            Manzana.FadeTo(1, 500);
            Platano.FadeTo(1, 500);
        }
        private async void BtnReady(object sender, EventArgs e)
        {
            Vibration.Vibrate(TimeSpan.FromMilliseconds(500));
            await FrameNoVis.FadeTo(0, 500);
            await FrameVis.FadeTo(0, 500);
            FramInicio.BackgroundColor = Color.Transparent;
            FramInicio.BorderColor = Color.FromHex("#1B1464");
            await BtnListoOff.FadeTo(0, 500);
            await Task.Delay(500);
            FrameVis.IsVisible = false;

            FrameNoVis.IsVisible = true;
            await Task.Delay(500);
            await FrameNoVis.FadeTo(1, 500);
        }

        private async void FrutaCorrecta(object sender, EventArgs e)
        {
            Vibration.Vibrate(TimeSpan.FromMilliseconds(1000));
            FramInicio.BackgroundColor = Color.FromHex("#FFFFFF");
            FramInicio.BorderColor = Color.FromHex("#FFFFFF");
            TapCorrecto.BackgroundColor = Color.FromHex("#3124B5");
            await Task.Delay(1000);
            FrameVis.IsVisible = true;
            FrameNoVis.IsVisible = false;
            await FrameVis.FadeTo(1, 500);

            await Task.Delay(1500);
            await PopupNavigation.Instance.PushAsync(new ModalBien());
            await Task.Delay(3000);
            await Navigation.PopPopupAsync();
            await Navigation.PushAsync(new FrutasV(NombreJugador, FotoJugador));
        }

        private async void FrutaIncorrectaI(object sender, EventArgs e)
        {
            await Task.WhenAll(
                FrutII.RotateTo(360, 1000),
                FrutII.FadeTo(0, 500)
            );
        }

        private async void FrutaIncorrectaII(object sender, EventArgs e)
        {
            await Task.WhenAll(
                FrutIII.RotateTo(360, 1000),
                FrutIII.FadeTo(0, 500)
            );
        }

        private async void HomeBack(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new ModalSalirJuego(NombreJugador, FotoJugador));
            //await Navigation.PushAsync(new JuegoMemoria(NombreJugador, FotoJugador));
        }
        private async void SalirApp(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new inicio());
        }
    }
}