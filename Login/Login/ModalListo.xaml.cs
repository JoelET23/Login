using Login.Views;
using Login.Views.JuegosMemoria;
using Login.Views.JuegosMemoria.FrutasIIPage;
using Rg.Plugins.Popup.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Login
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ModalListo : Rg.Plugins.Popup.Pages.PopupPage
    {
        public string NombreJugador;
        public string FotoJugador;
        public ModalListo(string n, string a)
        {
            InitializeComponent();
            NombreJugador = n;
            FotoJugador = a;
        }
        async void BtnSalir(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FrutasIP(NombreJugador, FotoJugador));
            await Navigation.PopPopupAsync();
        }

        async void BtnCancelar(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new JuegoMemoria(NombreJugador, FotoJugador));
            await Navigation.PopPopupAsync();
        }
        async void BtnRepetir(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FrutasI(NombreJugador, FotoJugador));
            await Navigation.PopPopupAsync();
        }

    }
}