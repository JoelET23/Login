using System;
using System.Collections.Generic;
using System.Text;

namespace Login.Models
{
    public class AlumnoUserModels
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Active { get; set; }
        public int Edad { get; set; }
        public string Foto { get; set; }
        public string ColorFoto { get; set; }
        public string EdadFull => $"{Edad} años";
    }
}
