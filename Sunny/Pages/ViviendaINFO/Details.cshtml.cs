using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sunny.Data;
using SunnyModels;

namespace Sunny.Pages.ViviendaINFO
{
    public class DetailsModel : PageModel
    {
        private readonly Sunny.Data.ApplicationDbContext _context;

        public DetailsModel(Sunny.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Info_Vivienda Info_Vivienda { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Info_Vivienda = await _context.Info_Vivienda.FirstOrDefaultAsync(m => m.Id == id);

            if (Info_Vivienda == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
