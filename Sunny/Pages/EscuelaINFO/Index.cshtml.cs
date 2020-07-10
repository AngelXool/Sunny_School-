using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sunny.Data;
using SunnyModels;

namespace Sunny.Pages.EscuelaINFO
{
    public class IndexModel : PageModel
    {
        private readonly Sunny.Data.ApplicationDbContext _context;

        public IndexModel(Sunny.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Info_Escolar> Info_Escolar { get;set; }

        public async Task OnGetAsync()
        {
            Info_Escolar = await _context.Info_Escolar.ToListAsync();
        }
    }
}
