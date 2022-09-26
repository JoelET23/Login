using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Login.ViewModels
{
    public class indexVM : LoginVM
    {
        private string contrasena, email;
        public indexVM(INavigationService navSer) : base(navSer)
        {
            LoginCommand = new DelegateCommand(Login);
        }

        #region Propiedades

        public string Email
        {
            get => email;
            set => SetProperty(ref email, value);
        }
        public string Contrasena
        {
            get => contrasena;
            set => SetProperty(ref contrasena, value);
        }


        public DelegateCommand LoginCommand
        {
            get;
            set;
        }

        #endregion

        #region Metodos

        void Login()
        {
            if (!Conexion)
            {
                if (!string.IsNullOrWhiteSpace(email) && !string.IsNullOrWhiteSpace(contrasena))
                {
                    if (Email == "joel@demo.com" && Contrasena == "123456")
                    {
                        var parametros = new NavigationParameters
                        {
                            {"Titulo", "Bienvenido al inicio" },
                            {"Email", email }
                        };
                        NavigationService.NavigateAsync("inicio", parametros);
                    }
                    else
                    {
                        App.Current.MainPage.DisplayAlert("Login fallido", "Ingresar correctamente su usuario o contraseña", "Aceptar");
                    }
                }
                else
                {
                    App.Current.MainPage.DisplayAlert("Insertar datos", "Por favor ingresa tu usuario y contraseña", "Aceptar");
                }
            }
            
        }

        #endregion
    }
}