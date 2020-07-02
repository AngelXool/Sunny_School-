using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Becas_Escolar.Data;
using Becas_Escolar.Pages.Models;

namespace Becas_Escolar.Pages.Alumno_Escolar_Service
{
    public class DetailsModel : PageModel
    {
        private readonly Becas_Escolar.Data.Becas_EscolarContext _context;

        public DetailsModel(Becas_Escolar.Data.Becas_EscolarContext context)
        {
            _context = context;
        }

        public Alumno_Escolar Alumno_Escolar { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Alumno_Escolar = await _context.Alumno_Escolar.FirstOrDefaultAsync(m => m.id == id);

            if (Alumno_Escolar == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
