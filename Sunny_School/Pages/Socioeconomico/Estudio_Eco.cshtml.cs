using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Sunny_School.Pages.Socioeconomico
{
    public class Estudio_EcoModel : PageModel
    {
        public void OnGet()
        {

        }
        [BindProperty]
        public Alumno Enlace { get; set; }//Cambiar clase y nombre
        public class Alumno
        {

            [Required]
            [Display(Name = "Ingresos Mensuales: $")]
            public Int64 Ingre_mensu { get; set; }

            [Required]
            [Display(Name = "Alimentacion: $")]
            public Int64 Alimentacion { get; set; }

            [Required]
            [Display(Name = "Gasto diario de la escuela: $")]
            public Int64 Diario { get; set; }

            [Required]
            [Display(Name = "Vivienda: $")]
            public Int64 Vivienda { get; set; }

            [Required]
            [Display(Name = "Servicios: $")]
            public string Servicios { get; set; }

            [Required]
            [Display(Name = "Trasporte: $")]
            public Int64 Trasporte { get; set; }

            [Required]
            [Display(Name = "Otros: $")]
            public string Otros { get; set; }

            [Required]
            [Display(Name = "Total: $")]
            public Int64 Total { get; set; }


        }
    }
}