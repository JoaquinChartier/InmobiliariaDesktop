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

        [Required(ErrorMessage = "El nombre del inmueble es requerido")]
        [Display(Name = "Inmueble")]
        public String Nombre { get; set; }

        [Required(ErrorMessage = "El nombre del propietario es requerido")]
        [Display(Name = "Propietario")]
        public int PropietarioId { get; set; }
        public virtual Propietario Propietario { get; set; }

        [Required(ErrorMessage = "El tipo de inmueble es requerida")]
        [Display(Name = "Tipo de inmueble")]
        public TipoInmuebleEnum TipoDeInmueble { get; set; }

        [Required(ErrorMessage = "La dirección del inmueble es requerida")]
        [Display(Name = "Dirección")]
        public String Direccion { get; set; }

        [Required(ErrorMessage = "El precio de alquiler es requerido")]
        [Display(Name = "Costo del alquiler")]
        public int PrecioAlquiler { get; set; }

        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
        
    }
}