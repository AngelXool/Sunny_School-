using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Becas_Escolar.Data;
using Becas_Escolar.Pages.Models;

namespace Becas_Escolar.Pages.Madre_Service
{
    public class CreateModel : PageModel
    {
        private readonly Becas_Escolar.Data.Becas_EscolarContext _context;

        public CreateModel(Becas_Escolar.Data.Becas_EscolarContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Datos_Familiar_Madre Datos_Familiar_Madre { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Datos_Familiar_Madre.Add(Datos_Familiar_Madre);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
