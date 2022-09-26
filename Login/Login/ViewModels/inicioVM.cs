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

        public ObservableCollection<AlumnoUserModels> AlumnosUsers { get; set; }

        public inicioVM()
        {
            AlumnosUsers = new ObservableCollection<AlumnoUserModels>
            {
                new AlumnoUserModels
                {
                    Id = 1,
                    Nombre = "Joel",
                    Active = "#F0EFFC",
                    Edad = 32,
                    Foto = "user.png"
                },

                new AlumnoUserModels
                {
                    Id = 2,
                    Nombre = "Matilde",
                    Active = "#F0EFFC",
                    Edad = 19,
                    Foto = "user3.png"
                },

                new AlumnoUserModels
                {
                    Id = 3,
                    Nombre = "Fabian",
                    Active = "#F0EFFC",
                    Edad = 21,
                    Foto = "user2.png"
                },

                new AlumnoUserModels
                {
                    Id = 4,
                    Nombre = "Maria",
                    Active = "#F0EFFC",
                    Edad = 24,
                    Foto = "user4.png"
                }
            };
        }
    }
}
