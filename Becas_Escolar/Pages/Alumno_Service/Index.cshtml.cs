using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Becas_Escolar.Data;
using Becas_Escolar.Pages.Models;

namespace Becas_Escolar.Pages.Models.Alumno_Service
{
    public class IndexModel : PageModel
    {
        private readonly Becas_Escolar.Data.Becas_EscolarContext _context;

        public IndexModel(Becas_Escolar.Data.Becas_EscolarContext context)
        {
            _context = context;
        }

        public IList<Alumno> Alumno { get;set; }

        public async Task OnGetAsync()
        {
            Alumno = await _context.Alumno.ToListAsync();
        }
    }
}
