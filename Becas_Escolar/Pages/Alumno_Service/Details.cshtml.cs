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
    public class DetailsModel : PageModel
    {
        private readonly Becas_Escolar.Data.Becas_EscolarContext _context;

        public DetailsModel(Becas_Escolar.Data.Becas_EscolarContext context)
        {
            _context = context;
        }

        public Alumno Alumno { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Alumno = await _context.Alumno.FirstOrDefaultAsync(m => m.Id == id);

            if (Alumno == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
