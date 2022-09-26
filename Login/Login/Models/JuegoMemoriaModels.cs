using System;
using System.Collections.Generic;
using System.Text;

namespace Login.Models
{
    public class JuegoMemoriaModels
    {
        public int Id { get; set; }
        public string NombreJuego { get; set; }
        public bool Active { get; set; }
        public int Edad { get; set; }
        public string Foto { get; set; }
        public string EdadFull => $"{Edad} años";
    }
}
