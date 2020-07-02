using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Becas_Escolar.Data;
using Becas_Escolar.Pages.Models;

namespace Becas_Escolar.Pages.Madre_Service
{
    public class IndexModel : PageModel
    {
        private readonly Becas_Escolar.Data.Becas_EscolarContext _context;

        public IndexModel(Becas_Escolar.Data.Becas_EscolarContext context)
        {
            _context = context;
        }

        public IList<Datos_Familiar_Madre> Datos_Familiar_Madre { get;set; }

        public async Task OnGetAsync()
        {
            Datos_Familiar_Madre = await _context.Datos_Familiar_Madre.ToListAsync();
        }
    }
}
