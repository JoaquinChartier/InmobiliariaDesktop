using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Datos.Models
{
    public class Inquilino
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del inquilino es requerido")]
        [Display(Name = "Inquilino")]
        public String Nombre { get; set; }

        [Required(ErrorMessage = "El documento del inquilino es requerido")]
        [MinLength(7)]
        [MaxLength(10)]
        public String DNI { get; set; }

        [Required(ErrorMessage = "El dato del inquilino es requerido")]
        public bool Jubilado { get; set; }

        [Required(ErrorMessage = "El teléfono del inquilino es requerido")]
        [Display(Name = "Teléfono")]
        public String Telefono { get; set; }

        [Required(ErrorMessage = "El email del inquilino es requerido")]
        [Display(Name = "Correo electrónico")]
        public String Email { get; set; }

    }
}