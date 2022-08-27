using Login.ViewModels;
using Prism.Navigation;
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
    public partial class Juegos : ContentPage
    {
        public Juegos(string n, int a)
        {
            InitializeComponent();
            BindingContext = new juegosVM();
            LblTexto.Text = n + " " + a;          
        }
    }
}