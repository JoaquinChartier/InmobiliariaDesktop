using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Datos.Models
{
    public class Localidad
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre de la localidad es requerido")]
        [Display(Name = "Localidad")]
        public String Nombre { get; set; }
    }
}