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
    public class DetailsModel : PageModel
    {
        private readonly Sunny.Data.ApplicationDbContext _context;

        public DetailsModel(Sunny.Data.ApplicationDbContext context)
        {
            _context = context;
        }

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
    }
}
