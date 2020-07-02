using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Becas_Escolar.Data;
using Becas_Escolar.Pages.Models;

namespace Becas_Escolar.Pages.Datos_Economicos_Service
{
    public class DetailsModel : PageModel
    {
        private readonly Becas_Escolar.Data.Becas_EscolarContext _context;

        public DetailsModel(Becas_Escolar.Data.Becas_EscolarContext context)
        {
            _context = context;
        }

        public Datos_Economicos Datos_Economicos { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Datos_Economicos = await _context.Datos_Economicos.FirstOrDefaultAsync(m => m.id == id);

            if (Datos_Economicos == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
