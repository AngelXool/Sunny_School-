using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunnyModels
{
    public class Info_Economica
    {
        public int Id { get; set; }

        [Display(Name = "Ingresos Mensuales:")]
        public Int64 Ingresos_Mensuales { get; set; }

        [Display(Name = "Gastos Alimenticios:")]
        public Int64 Gasto_Alimentacion { get; set; }

        [Display(Name = "Gastos Escolares:")]
        public Int64 Gasto_Escolar { get; set; }

        [Display(Name = "Gastos De Vivienda:")]
        public Int64 Gasto_Vivienda { get; set; }

        [Display(Name = "Gastos De Servicios:")]
        public Int64 Gasto_Servicios { get; set; }

        [Display(Name = "Gastos De Transporte:")]
        public Int64 Gasto_Transporte { get; set; }

        [Display(Name = "Otros:")]
        public Int64 Otros { get; set; }
    }
}
