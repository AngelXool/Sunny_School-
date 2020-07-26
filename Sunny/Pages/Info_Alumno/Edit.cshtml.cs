using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sunny.Data;
using SunnyModels;

namespace Sunny.Pages.Info_Alumno
{
    public class EditModel : PageModel
    {
        private readonly Sunny.Data.ApplicationDbContext _context;

        public EditModel(Sunny.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public AlumnoPers AlumnoPers { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AlumnoPers = await _context.AlumnoPers.FirstOrDefaultAsync(m => m.Id == id);

            if (AlumnoPers == null)
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

            _context.Attach(AlumnoPers).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AlumnoPersExists(AlumnoPers.Id))
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

        private bool AlumnoPersExists(int id)
        {
            return _context.AlumnoPers.Any(e => e.Id == id);
        }
    }
}
