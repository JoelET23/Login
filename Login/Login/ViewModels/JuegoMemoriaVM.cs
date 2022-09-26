using Login.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Login.ViewModels
{
    public class JuegoMemoriaVM
    {
        public ObservableCollection<JuegoMemoriaModels> ListadoJuegoModel { get; set; }

        public JuegoMemoriaVM()
        {
            ListadoJuegoModel = new ObservableCollection<JuegoMemoriaModels>
            {
                new JuegoMemoriaModels
                {
                    Id = 1,
                    NombreJuego = "Frutas I",
                    Active = true,
                    Edad = 6,
                    Foto = "Memoria1.png"
                },

                new JuegoMemoriaModels
                {
                    Id = 2,
                    NombreJuego = "Frutas II",
                    Active = false,
                    Edad = 7,
                    Foto = "Memoria1.png"
                },

                new JuegoMemoriaModels
                {
                    Id = 3,
                    NombreJuego = "Animales I",
                    Active = false,
                    Edad = 8,
                    Foto = "Memoria2.png"
                },

                new JuegoMemoriaModels
                {
                    Id = 4,
                    NombreJuego = "Animales II",
                    Active = false,
                    Edad = 8,
                    Foto = "Memoria2.png"
                },

                new JuegoMemoriaModels
                {
                    Id = 5,
                    NombreJuego = "Cosas I",
                    Active = false,
                    Edad = 8,
                    Foto = "Memoria3.png"
                },

                new JuegoMemoriaModels
                {
                    Id = 6,
                    NombreJuego = "Cosas II",
                    Active = false,
                    Edad = 8,
                    Foto = "Memoria3.png"
                },

                new JuegoMemoriaModels
                {
                    Id = 7,
                    NombreJuego = "Otros I",
                    Active = false,
                    Edad = 8,
                    Foto = "Memoria4.png"
                },

                new JuegoMemoriaModels
                {
                    Id = 8,
                    NombreJuego = "Otros II",
                    Active = false,
                    Edad = 8,
                    Foto = "Memoria4.png"
                }
            };
        }
    }
}
