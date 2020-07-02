using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Becas_Escolar.Data;
using Becas_Escolar.Pages.Models;

namespace Becas_Escolar.Pages.Datos_Economicos_Service
{
    public class EditModel : PageModel
    {
        private readonly Becas_Escolar.Data.Becas_EscolarContext _context;

        public EditModel(Becas_Escolar.Data.Becas_EscolarContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Datos_Economicos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Datos_EconomicosExists(Datos_Economicos.id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool Datos_EconomicosExists(int id)
        {
            return _context.Datos_Economicos.Any(e => e.id == id);
        }
    }
}
