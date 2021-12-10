using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App_Turnos.Models
{
    public class Profesional : Base
    {
        public string Especialista { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int NumeroDocumento { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string Genero { get; set; }
    }
}
