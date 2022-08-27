using Login.Models;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Essentials;

namespace Login.ViewModels
{
    public class LoginVM : BindableBase
    {
        private string titulo;
        private bool conexion;

        public LoginVM(INavigationService navService)
        {
            NavigationService = navService;
            Connectivity.ConnectivityChanged += Connectivity_ConnectivityChanged;
            Conexion = Connectivity.NetworkAccess != NetworkAccess.Internet;
        }

        public ObservableCollection<usuarios> UsuarioUsers { get; set; }
        public LoginVM()
        {
            UsuarioUsers = new ObservableCollection<usuarios>
            {
                new usuarios
                {
                    Id = 1,
                    Nombre = "Joel",
                    Correo = "joel@demo.com",
                    Password = "123456",
                    Tipo = 1
                },
                new usuarios
                {
                    Id = 2,
                    Nombre = "Fabian",
                    Correo = "fabian@demo.com",
                    Password = "123456",
                    Tipo = 2
                },
                new usuarios
                {
                    Id = 3,
                    Nombre = "Elmer",
                    Correo = "elmer@demo.com",
                    Password = "123456",
                    Tipo = 2
                }
            };
        }

        private void Connectivity_ConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
        {
            Conexion = e.NetworkAccess != NetworkAccess.Internet;
        }

        #region Propiedades

        public string Titulo
        {
            get => titulo;
            set => SetProperty(ref titulo, value);
        }

        public bool Conexion
        {
            get => conexion;
            set => SetProperty(ref conexion, value);
        }

        protected INavigationService NavigationService { get; set; }


        #endregion
    }
}
