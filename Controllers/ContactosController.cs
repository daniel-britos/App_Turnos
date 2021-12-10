using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using App_Turnos.Models;
using App_Turnos.Data;

namespace App_Turnos.Controllers
{
    public class ContactosController : Controller
    {
        private ApplicationDbContext _context;
        public ContactosController(ApplicationDbContext context)
        {
            _context = context;
        }



        [HttpPost]
        public IActionResult Guardar(string nombre, string apellido, string email, string nota)
        {

            Contacto NuevaNota = new Contacto()
            {
                Nombre = nombre,
                Apellido = apellido,
                Email = email,
                Nota = nota
            };


            _context.Publicar.Add(NuevaNota);
            _context.SaveChanges();
            if (NuevaNota.Nota != null)
            {
                ViewBag.msg = "Mensaje enviado... Dentro de las 48hs usted será atendido.";
            }


            return View("Comentario");

        }
        public IActionResult Comentario()
        {
            return View();
        }



    }
}
