using Datos.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class InmobiliariaDesktopContext:DbContext 
    {
        public InmobiliariaDesktopContext() : base("InmobiliariaDesktopContext")
        {
            Database.SetInitializer<InmobiliariaDesktopContext>(new MigrateDatabaseToLatestVersion<InmobiliariaDesktopContext, Configuration>());
        }

        public DbSet<Models.Alquileres> Alquileres { get; set; }
        public DbSet<Models.Inmueble> Inmuebles { get; set; }
        public DbSet<Models.Inquilino> Inquilinos { get; set; }
        public DbSet<Models.Localidad> Localidades { get; set; }
        public DbSet<Models.Propietario> Propietarios { get; set; }
    }
}
