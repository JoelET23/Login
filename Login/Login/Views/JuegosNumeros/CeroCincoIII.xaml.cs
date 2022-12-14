using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Login.Views.JuegosNumeros
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CeroCincoIII : ContentPage
    {
        public CeroCincoIII()
        {
            InitializeComponent();
        }
        private async void HomeBack(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new inicio());
        }

        private async void NumCorrecto(object sender, EventArgs e)
        {
            await FrameNoVis.FadeTo(0, 200);
            CorrectoTp.BackgroundColor = Color.FromHex("#3124B5");
            await Task.Delay(1000);
            await FrameVis.FadeTo(0, 200);
            FrameNoVis.IsVisible = true;
            FrameVis.IsVisible = false;
            await FrameNoVis.FadeTo(1, 500);

            await Task.Delay(1500);
            await Navigation.PushAsync(new CeroCincoIV());
        }

        private async void NumIncorrectoI(object sender, EventArgs e)
        {
            await Task.WhenAll(
                IncoI.FadeTo(0, 500)
            );
        }
        private async void NumIncorrectoII(object sender, EventArgs e)
        {
            await Task.WhenAll(
                IncoII.FadeTo(0, 500)
            );
        }
        private async void NumIncorrectoIII(object sender, EventArgs e)
        {
            await Task.WhenAll(
                IncoIII.FadeTo(0, 500)
            );
        }
        private async void NumIncorrectoIV(object sender, EventArgs e)
        {
            await Task.WhenAll(
                IncoIV.FadeTo(0, 500)
            );
        }
        private async void NumIncorrectoV(object sender, EventArgs e)
        {
            await Task.WhenAll(
                IncoV.FadeTo(0, 500)
            );
        }
    }
}