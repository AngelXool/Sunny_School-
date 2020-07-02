using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Becas_Escolar.Pages.Models;

namespace Becas_Escolar.Data
{
    public class Becas_EscolarContext : DbContext
    {
        public Becas_EscolarContext (DbContextOptions<Becas_EscolarContext> options)
            : base(options)
        {
        }

        public DbSet<Becas_Escolar.Pages.Models.Alumno> Alumno { get; set; }

        public DbSet<Becas_Escolar.Pages.Models.Alumno_Escolar> Alumno_Escolar { get; set; }

        public DbSet<Becas_Escolar.Pages.Models.Datos_Familiar_Padre> Datos_Familiar_Padre { get; set; }

        public DbSet<Becas_Escolar.Pages.Models.Datos_Familiar_Madre> Datos_Familiar_Madre { get; set; }

        public DbSet<Becas_Escolar.Pages.Models.Datos_Economicos> Datos_Economicos { get; set; }
    }
}
