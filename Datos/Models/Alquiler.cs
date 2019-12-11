using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Datos.Models
{
    public class Alquiler
    {
        public int Id { get; set; }

        [Display(Name = "Inquilino")]
        public int InquilinoId { get; set; }
        public virtual Inquilino Inquilino { get; set; }

        public int InmuebleId { get; set; }
        public virtual Inmueble Inmueble { get; set; }

        public int Duracion { get; set; }

        public bool PorMesBool { get; set; }

        public int Precio { get; set; }
    }
}