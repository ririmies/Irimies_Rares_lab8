﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Irimies_Rares_lab8.Data;
using Irimies_Rares_lab8.Models;

namespace Irimies_Rares_lab8.Pages.Categories
{
    public class DetailsModel : PageModel
    {
        private readonly Irimies_Rares_lab8.Data.Irimies_Rares_lab8Context _context;

        public DetailsModel(Irimies_Rares_lab8.Data.Irimies_Rares_lab8Context context)
        {
            _context = context;
        }

        public Category Category { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Category = await _context.Category.FirstOrDefaultAsync(m => m.ID == id);

            if (Category == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
