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
    public class DetailsModel : PageModel
    {
        private readonly Becas_Escolar.Data.Becas_EscolarContext _context;

        public DetailsModel(Becas_Escolar.Data.Becas_EscolarContext context)
        {
            _context = context;
        }

        public Datos_Familiar_Madre Datos_Familiar_Madre { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Datos_Familiar_Madre = await _context.Datos_Familiar_Madre.FirstOrDefaultAsync(m => m.id == id);

            if (Datos_Familiar_Madre == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
