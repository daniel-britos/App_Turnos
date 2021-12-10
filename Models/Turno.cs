using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App_Turnos.Models
{
    public class Turno : Base
    {
        public string Especialidad { get; set; }
        public DateTime Fecha { get; set; }
        public string Hora { get; set; }
    }

}
