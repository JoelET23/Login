using Login.Views;
using Login.Views.JuegosMemoria;
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
    public partial class ModalJugar : Rg.Plugins.Popup.Pages.PopupPage
    {
        public string NombreJugador;
        public string FotoJugador;
        public ModalJugar(string n, string a)
        {
            InitializeComponent();
            NombreJugador = n;
            FotoJugador = a;
        }

        async void BtnEmpezar(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FrutasI(NombreJugador, FotoJugador));
            await Navigation.PopPopupAsync();
        }

        async void BtnCerrar(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new JuegoMemoria(NombreJugador, FotoJugador));
            await Navigation.PopPopupAsync();
        }
    }
}