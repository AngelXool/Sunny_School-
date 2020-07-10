using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sunny.Data;
using SunnyModels;

namespace Sunny.Pages.Info_Alumno
{
    public class DeleteModel : PageModel
    {
        private readonly Sunny.Data.ApplicationDbContext _context;

        public DeleteModel(Sunny.Data.ApplicationDbContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AlumnoPers = await _context.AlumnoPers.FindAsync(id);

            if (AlumnoPers != null)
            {
                _context.AlumnoPers.Remove(AlumnoPers);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
