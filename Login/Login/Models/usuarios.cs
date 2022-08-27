using System;
using System.Collections.Generic;
using System.Text;

namespace Login.Models
{
    public class usuarios
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Password { get; set; }
        public int Tipo { get; set; }
    }
}