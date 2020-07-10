using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunnyModels
{
    public class AlumnoPers
    {
        public int Id { get; set; }

        [Display(Name = "Nombre Alumno:")]
        public string Nombre { get; set; }

        [Display(Name = "C.U.R.P:")]
        public string CURP { get; set; }

        [Display(Name = "Nacionalidad:")]
        public string Nacionalidad { get; set; }

        [Display(Name = "Fecha De Nacimiento:")]
        [DataType(DataType.Date)]
        public DateTime Fecha_nacimiento { get; set; }

        [Display(Name = "Genero:")]
        public string Genero { get; set; }

        [Display(Name = "Discapacidad:")]
        public string Discapacidad { get; set; }
    }
}
