using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Login.Views.JuegosMemoria
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FrutasII : ContentPage
    {
        public FrutasII()
        {
            InitializeComponent();
            Manzana.FadeTo(1, 500);
            Platano.FadeTo(1, 500);
        }

        private async void ClickInicioFruta(object sender, EventArgs e)
        {
            await FrameNoVis.FadeTo(0, 500);
            await FrameVis.FadeTo(0, 500);
            await Task.Delay(500);
            FrameVis.IsVisible = false;
            /*await Task.WhenAll(
                Platano.FadeTo(0, 200)
            );*/
            FrameNoVis.IsVisible = true;
            await Task.Delay(500);
            await FrameNoVis.FadeTo(1, 500);
        }

        private async void FrutaCorrecta(object sender, EventArgs e)
        {
            TapCorrecto.BackgroundColor = Color.FromHex("#3124B5");
            await Task.Delay(1000);
            FrameVis.IsVisible = true;
            FrameNoVis.IsVisible = false;
            await FrameVis.FadeTo(1, 500);

            //Navigation.ShowPopup(new ModalBien());
            await Task.Delay(1500);
            await Navigation.PushAsync(new FrutasII());

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
            await Navigation.PushAsync(new inicio());
        }
        private async void SalirApp(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new inicio());
        }
    }
}