using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Login.Views.JuegosMemoria.FrutasIIPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FrutasIP : ContentPage
    {
        public string NombreJugador;
        public string FotoJugador;
        public FrutasIP(string n, string a)
        {
            InitializeComponent();
            NombreJugador = n;
            FotoJugador = a;
        }
    }
}