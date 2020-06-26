using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace SunnySchool.models
{
    
    public class Info_Alumno1
    {
        
        //public Info_Alumno Enlace { get; set; }
        

            [Required]
            [Display(Name = "Nombre:")]
            public string Nombre { get; set; }

            [Required]
            [Display(Name = "C.U.R.P:")]
            public char CURP { get; set; }

            [Required]
            [Display(Name = "Nacionalidad:")]
            public string Nacionalidad { get; set; }

            [Required]
            [Display(Name = "Fecha de Nacimiento::")]
            public DateTime Fecha_Nacimineto { get; set; }

            [Required]
            [Display(Name = "Genero:")]
            public string Genero { get; set; }

            [Required]
            [Display(Name = "¿Tiene alguna discapacidad?")]
            public string Discapacidad { get; set; }



        
    }
}
