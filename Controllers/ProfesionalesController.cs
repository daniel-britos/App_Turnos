using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App_Turnos.Models;
using App_Turnos.Data;

namespace App_Turnos.Controllers
{
    public class ProfesionalesController : Microsoft.AspNetCore.Mvc.Controller
    {
        private ApplicationDbContext _context;
        public ProfesionalesController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.ProfList = _context.Profesionales.OrderByDescending(x => x.id).ToList();

            return View();
        }

        public IActionResult Guardar(string especialista, string nombre, string apellido, int numerodocumento, DateTime fechanacimiento, string email, string celular, string genero)
        {
            Profesional nuevoProfesional = new Profesional()
            {
                Especialista = especialista,
                Nombre = nombre,
                Apellido = apellido,
                NumeroDocumento = numerodocumento,
                FechaNacimiento = fechanacimiento,
                Email = email,
                Celular = celular,
                Genero = genero
            };

            _context.Profesionales.Add(nuevoProfesional);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult Crear()
        {
            return View();
        }

        
        public IActionResult Borrar(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var persona = _context.Profesionales.Find(id);
            if (persona == null )
            {
                return NotFound();
            }
            return View(persona);
        }
        
        [HttpPost, ActionName("Borrar")]
        public IActionResult BorrarConfirm(int? id)
        {
            var persona = _context.Profesionales.Find(id);
            _context.Profesionales.Remove(persona);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        
    }
}
