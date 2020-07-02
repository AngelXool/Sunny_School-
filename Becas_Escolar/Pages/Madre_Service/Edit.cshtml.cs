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

namespace Becas_Escolar.Pages.Madre_Service
{
    public class EditModel : PageModel
    {
        private readonly Becas_Escolar.Data.Becas_EscolarContext _context;

        public EditModel(Becas_Escolar.Data.Becas_EscolarContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Datos_Familiar_Madre).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Datos_Familiar_MadreExists(Datos_Familiar_Madre.id))
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

        private bool Datos_Familiar_MadreExists(int id)
        {
            return _context.Datos_Familiar_Madre.Any(e => e.id == id);
        }
    }
}
