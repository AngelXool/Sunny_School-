using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunnyModels
{
    public class Cita
    {
        public int id { get; set; }

        [Display(Name = ":")]
        public string Nombre { get; set; }
    }
}
