using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace App_Turnos.Models
{
    public class Contacto : Base
    {
        [Display(Name = "Nombre")]
        [StringLength(12)]
        [Required(ErrorMessage = "Introduce un nombre...")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Introduce un apellido...")]
        [StringLength(12)]
        [Display(Name = "Apellido")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Introduce un e-mail...")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Escribe algo...")]
        [Display(Name = "Mensaje")]
        [StringLength(200)]
        public string Nota { get; set; }

    }
}
