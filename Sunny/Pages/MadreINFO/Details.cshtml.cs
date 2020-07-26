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
    public class DetailsModel : PageModel
    {
        private readonly Sunny.Data.ApplicationDbContext _context;

        public DetailsModel(Sunny.Data.ApplicationDbContext context)
        {
            _context = context;
        }

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
    }
}
