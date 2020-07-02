using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Becas_Escolar.Pages.Models
{
    public class Datos_Familiar_Madre
    {
        public int id { get; set; }

        [Required]
        [Display(Name = "Nombre De Madre:")]
        public string Nombre_Madre { get; set; }

        [Required]
        [Display(Name = "C.U.R.P:")]
        public string CURP { get; set; }

        [Required]
        [Display(Name = "Nacionalidad:")]
        public string Nacionalidad { get; set; }

        [Required]
        [Display(Name = "Fecha De Nacimiento:")]
        [DataType(DataType.Date)]
        public DateTime Fecha_nacimiento { get; set; }

        [Required]
        [Display(Name = "Ocupacion:")]
        public string Ocupacion { get; set; }

        [Required]
        [Display(Name = "Ingresos:")]
        public Int64 Ingresos { get; set; }
    }
}
