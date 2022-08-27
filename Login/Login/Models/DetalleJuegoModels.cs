using System;
using System.Collections.Generic;
using System.Text;

namespace Login.Models
{
    public class DetalleJuegoModels
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Porcentaje { get; set; }
        public int IdAlumno { get; set; }
        public int IdJuego { get; set; }
        public string Foto { get; set; }
        public string Edad { get; set; }
    }
}
