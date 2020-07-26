using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SunnyModels;

namespace Sunny.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<SunnyModels.AlumnoPers> AlumnoPers { get; set; }
        public DbSet<SunnyModels.Info_Escolar> Info_Escolar { get; set; }
        public DbSet<SunnyModels.Info_Economica> Info_Economica { get; set; }
        public DbSet<SunnyModels.Info_Padre> Info_Padre { get; set; }
        public DbSet<SunnyModels.Info_Madre> Info_Madre { get; set; }
        public DbSet<SunnyModels.Info_Vivienda> Info_Vivienda { get; set; }
    }
}
