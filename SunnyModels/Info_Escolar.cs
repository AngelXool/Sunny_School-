using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunnyModels
{
    public class Info_Escolar
    {
        public int Id { get; set; }


        [Display(Name = "Nombre Completo De La Escuela:")]
        public string Nombre { get; set; }


        [Display(Name = "Nivel Escolar:")]
        public string Nivel_Escolar { get; set; }


        [Display(Name = "Grado Escolar:")]
        public string Grado_Escolar { get; set; }


        [Display(Name = "Nombre Del Tutor:")]
        public string Nombre_Tutor { get; set; }
    }
}
