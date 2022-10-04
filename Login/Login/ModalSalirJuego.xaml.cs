using Login.Views;
using Prism.Navigation.Xaml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Login
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ModalSalirJuego : Popup
    {
        public string NombreJugador;
        public string FotoJugador;
        public ModalSalirJuego()
        {
            InitializeComponent();
            /*NombreJugador = n;
            FotoJugador = a;*/
        }

        void BtnSalir(Object sender, EventArgs e)
        {
            Application.Current.MainPage = new Juegos("dom", "dem");
            //await Navigation.PushAsync(new Juegos("dom", "dem"));
            Dismiss(null);
        }

        void BtnCancelar(Object sender, EventArgs e)
        {
            Dismiss(null);
        }
    }
}