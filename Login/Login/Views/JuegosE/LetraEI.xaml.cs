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
    public partial class LetraEI : ContentPage
    {
        public LetraEI()
        {
            InitializeComponent();

            Manzana.FadeTo(1, 500);
            Platano.FadeTo(1, 500);
        }

        private async void LetraCorrecta(object sender, EventArgs e)
        {
            await Manzana.FadeTo(1, 300);
            await Task.Delay(200);
            await Manzana.FadeTo(0, 300);
            await Task.Delay(200);
            await Manzana.FadeTo(1, 300);
            await Task.Delay(200);
            await Manzana.FadeTo(0, 300);
            await Task.Delay(200);
            await Manzana.FadeTo(1, 300);
            await Task.Delay(200);
            await Manzana.FadeTo(0, 300);
            await Task.Delay(200);
            await Manzana.FadeTo(1, 300);
            await Task.Delay(200);
            await Navigation.PushAsync(new LetraEII());
        }
        private async void LetraIncorrecta(object sender, EventArgs e)
        {
            await Task.WhenAll(
                Platano.RotateTo(360, 1000),
                Platano.FadeTo(0, 500)
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