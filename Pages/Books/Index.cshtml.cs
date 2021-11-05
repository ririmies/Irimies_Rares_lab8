﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Irimies_Rares_lab8.Data;
using Irimies_Rares_lab8.Models;

namespace Irimies_Rares_lab8.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Irimies_Rares_lab8.Data.Irimies_Rares_lab8Context _context;

        public IndexModel(Irimies_Rares_lab8.Data.Irimies_Rares_lab8Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }

        public async Task OnGetAsync()
        {
            Book = await _context.Book.Include(b => b.Publisher).ToListAsync();
        }
    }
}
