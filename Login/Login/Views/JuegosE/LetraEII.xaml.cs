using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Login.Views.JuegosE
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LetraEII : ContentPage
    {
        public LetraEII()
        {
            InitializeComponent();
        }

        private async void FrutaCorrecta(object sender, EventArgs e)
        {
            //FrameVis.IsVisible = false;

            await Task.WhenAll(
                Platano.RotateTo(360, 1000),
                Platano.FadeTo(1, 500)
            );
            await Task.Delay(1500);
            //await Navigation.PushAsync(new FrutasII());
        }

        private async void FrutaIncorrectaI(object sender, EventArgs e)
        {
            await Task.WhenAll(
                FrutII.RotateTo(360, 1000),
                FrutII.FadeTo(0, 500)
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