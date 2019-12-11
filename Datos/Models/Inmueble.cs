using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Datos.Models
{
    public class Inmueble
    {
        public int Id { get; set; }
        
        [Display(Name = "Inmueble")]
        public String Nombre { get; set; }
        
        [Display(Name = "Propietario")]
        public int PropietarioId { get; set; }
        public virtual Propietario Propietario { get; set; }
        
        [Display(Name = "Tipo de inmueble")]
        public TipoInmuebleEnum TipoDeInmueble { get; set; }
        
        [Display(Name = "Dirección")]
        public String Direccion { get; set; }
        
        public int PrecioAlquilerDia { get; set; }

        public int PrecioAlquilerMes { get; set; }

        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
        
    }
}