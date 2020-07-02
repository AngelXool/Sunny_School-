using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Becas_Escolar.Data;
using Becas_Escolar.Pages.Models;

namespace Becas_Escolar.Pages.Alumno_Escolar_Service
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
        public Alumno_Escolar Alumno_Escolar { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Alumno_Escolar.Add(Alumno_Escolar);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
