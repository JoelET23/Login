using Login.Models;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Login.ViewModels
{
    public class juegosVM
    {
        public ObservableCollection<JuegoModels> JuegosModel { get; set; }

        public juegosVM()
        {
            JuegosModel = new ObservableCollection<JuegoModels>
            {
                new JuegoModels
                {
                    Id = 1,
                    Nombre = "Memoria",
                    Porcentaje = 15,
                    IdAlumno = 1,
                    Foto = "juego1.png"
                },
                 new JuegoModels
                {
                    Id = 2,
                    Nombre = "Trazo",
                    Porcentaje = 20,
                    IdAlumno = 1,
                    Foto = "juego2.png"
                },
                  new JuegoModels
                {
                    Id = 3,
                    Nombre = "Lectura/Escritura",
                    Porcentaje = 5,
                    IdAlumno = 1,
                    Foto = "juego3.png"
                },
                   new JuegoModels
                {
                    Id = 4,
                    Nombre = "Matemáticas",
                    Porcentaje = 30,
                    IdAlumno = 1,
                    Foto = "juego4.png"
                },
            };
        }
   
    }
}
