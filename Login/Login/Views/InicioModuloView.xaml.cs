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
    public partial class InicioModuloView : ContentPage
    {
        public InicioModuloView()
        {
            InitializeComponent();
        }
        private async void BtnJuego(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new JuegoMemoria("Joel", "Fabian"));
        }
    }
}