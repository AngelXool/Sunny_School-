using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sunny.Data;
using SunnyModels;

namespace Sunny.Pages.MadreINFO
{
    public class DeleteModel : PageModel
    {
        private readonly Sunny.Data.ApplicationDbContext _context;

        public DeleteModel(Sunny.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Info_Madre Info_Madre { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Info_Madre = await _context.Info_Madre.FirstOrDefaultAsync(m => m.id == id);

            if (Info_Madre == null)
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

            Info_Madre = await _context.Info_Madre.FindAsync(id);

            if (Info_Madre != null)
            {
                _context.Info_Madre.Remove(Info_Madre);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
