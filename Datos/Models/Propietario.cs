using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Datos.Models
{
    public class Propietario
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre del propietario es requerido")]
        [Display(Name = "Propietario")]
        public String Nombre { get; set; }
        [Required(ErrorMessage = "El documento del propietario es requerido")]
        public String DNI { get; set; }
        [Required(ErrorMessage = "El teléfono del propietario es requerido")]
        [Display(Name = "Teléfono")]
        public String Telefono { get; set; }
        [Display(Name = "Cuenta bancaria")]
        public String CuentaBancaria { get; set; }
        [Required(ErrorMessage = "La dirección del propietario es requerido")]
        [Display(Name = "Dirección")]
        public String Direccion { get; set; }
        [Display(Name = "Localidad")]
        public int LocalidadId { get; set; }
        public virtual Localidad Localidad { get; set; }
    }
}