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

namespace Becas_Escolar.Pages.Alumno_Escolar_Service
{
    public class EditModel : PageModel
    {
        private readonly Becas_Escolar.Data.Becas_EscolarContext _context;

        public EditModel(Becas_Escolar.Data.Becas_EscolarContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Alumno_Escolar).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Alumno_EscolarExists(Alumno_Escolar.id))
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

        private bool Alumno_EscolarExists(int id)
        {
            return _context.Alumno_Escolar.Any(e => e.id == id);
        }
    }
}
