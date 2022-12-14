using Login.Views;
using Prism.Navigation.Xaml;
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
    public partial class ModalSalirJuego : Rg.Plugins.Popup.Pages.PopupPage
    {
        public string NombreJugador;
        public string FotoJugador;
        public ModalSalirJuego(string n, string a)
        {
            InitializeComponent();
            NombreJugador = n;
            FotoJugador = a;
        }

        async void BtnSalir(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new JuegoMemoria(NombreJugador, FotoJugador));
            await Navigation.PopPopupAsync();
        }

        async void BtnCancelar(object sender, EventArgs e)
        {
            await Navigation.PopPopupAsync();
        }
    }
}