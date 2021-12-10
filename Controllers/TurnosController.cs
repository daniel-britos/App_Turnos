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

    [Authorize]
    public class TurnosController : Controller
    {
        private ApplicationDbContext _context;
        public TurnosController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Confirmado(string especialidad, DateTime fecha, string hora)
        {
            Turno NuevoTurno = new Turno()
            {
                Especialidad = especialidad,
                Fecha = fecha,
                Hora = hora
            };
            
            var existeFecha = _context.Turnos.Where(p => p.Fecha.Date == fecha.Date && p.Hora == hora).FirstOrDefault(); //si no hay coincidencia retorna null
            //var existeHora = _context.Turnos.Where(p => p.Hora == hora).FirstOrDefault();

            if (existeFecha == null)
            {
                _context.Turnos.Add(NuevoTurno);
                _context.SaveChanges();
            }
            else
            {
                return View("_Turno");
            }
            //si la fecha y la hora existen en la base de datos no cargar

            return View(NuevoTurno);
        }

        public IActionResult Turno()
        {

            return View();
        }
        public IActionResult VerTurnos()
        {
            ViewBag.TurnosList = _context.Turnos.OrderByDescending(x => x.Fecha).ToList();
            return View();
        }
    }
}

