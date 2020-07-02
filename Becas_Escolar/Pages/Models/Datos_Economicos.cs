using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Becas_Escolar.Pages.Models
{
    public class Datos_Economicos
    {
        public int id { get; set; }

        [Required]
        [Display(Name = "Ingresos Mensuales:")]
        public Int64 Ingresos_Mensuales { get; set; }

        [Required]
        [Display(Name = "Gastos Alimenticios:")]
        public Int64 Gasto_Alimentacion { get; set; }

        [Required]
        [Display(Name = "Gastos Escolares:")]
        public Int64 Gasto_Escolar { get; set; }

        [Required]
        [Display(Name = "Gastos De Vivienda:")]
        public Int64 Gasto_Vivienda { get; set; }

        [Required]
        [Display(Name = "Gastos De Servicios:")]
        public Int64 Gasto_Servicios { get; set; }

        [Required]
        [Display(Name = "Gastos De Transporte:")]
        public Int64 Gasto_Transporte { get; set; }

        [Required]
        [Display(Name = "Otros:")]
        public Int64 Otros { get; set; }



    }
}
