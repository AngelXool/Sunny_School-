using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Sunny_School.Pages.Socioeconomico
{
    public class Estudio_Eco_2Model : PageModel
    {
        public void OnGet()
        {

        }
        [BindProperty]
        public Alumno Enlace { get; set; } //Cambiar clase y nombre
        public class Alumno
        {

            [Required]
            [Display(Name = "Piezas de la casa:")]
            public string Piezas_casa { get; set; }

            [Required]
            [Display(Name = "Area")]
            public string Area { get; set; }

            [Required]
            [Display(Name = "Servicios")]
            public string Servicios { get; set; }

            [Required]
            [Display(Name = "Tipo de construccion")]
            public string Construccion { get; set; }

            [Required]
            [Display(Name = "Estatus")]
            public string Estatus { get; set; }



        }
    }
}