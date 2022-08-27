using Login.Models;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Login.ViewModels
{
    public class inicioVM : LoginVM, IInitialize
    {
        private string email;
        public string Email
        {
            get => email;
            set => SetProperty(ref email, value);
        }
 
        public inicioVM(INavigationService navSer) : base(navSer)
        {
        }

        public void Initialize(INavigationParameters parameters)
        {
            var title = (string)parameters["Titulo"];
            var email = (string)parameters["Email"];
            Titulo = title;
            Email = email;
        }

        public ObservableCollection<AlumnoUser> AlumnosUsers { get; set; }

        public inicioVM()
        {
            AlumnosUsers = new ObservableCollection<AlumnoUser>
            {
                new AlumnoUser
                {
                    Id = 1,
                    Nombre = "Joel",
                    Active = true,
                    Edad = 32,
                    Foto = "user.png"
                },

                new AlumnoUser
                {
                    Id = 2,
                    Nombre = "Fabian",
                    Active = false,
                    Edad = 19,
                    Foto = "user2.png"
                },

                new AlumnoUser
                {
                    Id = 3,
                    Nombre = "Elmer",
                    Active = false,
                    Edad = 21,
                    Foto = "user3.png"
                },

                new AlumnoUser
                {
                    Id = 4,
                    Nombre = "Tello",
                    Active = false,
                    Edad = 24,
                    Foto = "user4.png"
                }
            };
        }
    }
}
