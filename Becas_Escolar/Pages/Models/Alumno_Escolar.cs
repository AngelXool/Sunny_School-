using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Becas_Escolar.Pages.Models
{
    public class Alumno_Escolar
    {
        
        public int id { get; set; }

        [Required]
        [Display(Name = "Nombre Completo:")]
        public string Nombre { get; set; }

        [Required]
        [Display(Name = "Nivel Escolar:")]
        public string Nivel_Escolar { get; set; }

        [Required]
        [Display(Name = "Grado Escolar:")]
        public string Grado_Escolar { get; set; }

        [Required]
        [Display(Name = "Nombre Del Tutor:")]
        public string Nombre_Tutor { get; set; }
    }
}
