using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using App_Turnos.Models;
using Microsoft.AspNetCore.Identity;

namespace App_Turnos.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Contacto> Publicar { get; set; }
        public DbSet<Turno> Turnos { get; set; }
        public DbSet<Profesional> Profesionales { get; set; }


    }
}
