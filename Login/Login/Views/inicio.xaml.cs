using Android.Content;
using Login.Models;
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
    public partial class inicio : ContentPage
    {
        public inicio()
        {
            InitializeComponent();
            BindingContext = new inicioVM();

            TouchAlumno.SelectionChanged += TouchAlumno_SelectionChanged;
        }

        private async void TouchAlumno_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var _clickAlumnos = e.CurrentSelection;
           
            for (int i=0; i<_clickAlumnos.Count; i++)
            {
                var _clickAlumno = _clickAlumnos[i] as AlumnoUserModels;
                await Navigation.PushAsync(new Juegos(_clickAlumno.Nombre, _clickAlumno.Foto));
                //Intent intent = new Intent((Context)_clickAlumno.Nombre, typeof(Juegos));
                //DisplayAlert("Prueba", msg, "OK");
            }
        }
    }
}