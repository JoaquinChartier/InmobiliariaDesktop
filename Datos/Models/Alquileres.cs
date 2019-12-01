using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Datos.Models
{
    public class Alquileres
    {
        public int Id { get; set; }

        [Display(Name = "Inquilino")]
        public int InquilinoId { get; set; }
        public virtual Inquilino Inquilino { get; set; }

        public int InmuebleId { get; set; }
        public virtual Inmueble Inmueble { get; set; }

        public DateTime Desde { get; set; }
        public DateTime Hasta { get; set; }

        public int Precio { get; set; }
    }
}