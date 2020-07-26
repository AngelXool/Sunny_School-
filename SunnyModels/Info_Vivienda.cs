using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunnyModels
{
    public class Info_Vivienda
    {
        public int Id { get; set; }

        [Display(Name = "Piezas De La Vivienda:")]
        public Int64 Piezas_Casa { get; set; }

        [Display(Name = "Area De La Vivienda:")]
        public string Area { get; set; }

        [Display(Name = "Servicios Con Los Que Cuenta:")]
        public string Servicios { get; set; }

        public string Construccion { get; set; }

        [Display(Name = "Tipo De Vivienda:")]
        public string Estatus { get; set; }

        [Display(Name = "¿Cuenta con Muebles La Vivienda?")]
        public string Mobiliario { get; set; }

    }
}
