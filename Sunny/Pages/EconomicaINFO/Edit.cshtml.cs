﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sunny.Data;
using SunnyModels;

namespace Sunny.Pages.EconomicaINFO
{
    public class EditModel : PageModel
    {
        private readonly Sunny.Data.ApplicationDbContext _context;

        public EditModel(Sunny.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Info_Economica Info_Economica { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Info_Economica = await _context.Info_Economica.FirstOrDefaultAsync(m => m.Id == id);

            if (Info_Economica == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Info_Economica).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Info_EconomicaExists(Info_Economica.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool Info_EconomicaExists(int id)
        {
            return _context.Info_Economica.Any(e => e.Id == id);
        }
    }
}
