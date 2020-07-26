using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sunny.Data;
using SunnyModels;

namespace Sunny.Pages.PadreINFO
{
    public class DeleteModel : PageModel
    {
        private readonly Sunny.Data.ApplicationDbContext _context;

        public DeleteModel(Sunny.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Info_Padre Info_Padre { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Info_Padre = await _context.Info_Padre.FirstOrDefaultAsync(m => m.id == id);

            if (Info_Padre == null)
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

            Info_Padre = await _context.Info_Padre.FindAsync(id);

            if (Info_Padre != null)
            {
                _context.Info_Padre.Remove(Info_Padre);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
