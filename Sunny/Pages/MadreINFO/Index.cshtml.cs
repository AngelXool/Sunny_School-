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
    public class IndexModel : PageModel
    {
        private readonly Sunny.Data.ApplicationDbContext _context;

        public IndexModel(Sunny.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Info_Madre> Info_Madre { get;set; }

        public async Task OnGetAsync()
        {
            Info_Madre = await _context.Info_Madre.ToListAsync();
        }
    }
}
