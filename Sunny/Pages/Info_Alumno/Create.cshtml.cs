﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Sunny.Data;
using SunnyModels;

namespace Sunny.Pages.Info_Alumno
{
    public class CreateModel : PageModel
    {
        private readonly Sunny.Data.ApplicationDbContext _context;

        public CreateModel(Sunny.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public AlumnoPers AlumnoPers { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.AlumnoPers.Add(AlumnoPers);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Create");
        }
    }
}
