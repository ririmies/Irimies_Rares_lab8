using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Irimies_Rares_lab8.Models;

namespace Irimies_Rares_lab8.Data
{
    public class Irimies_Rares_lab8Context : DbContext
    {
        public Irimies_Rares_lab8Context (DbContextOptions<Irimies_Rares_lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Irimies_Rares_lab8.Models.Book> Book { get; set; }

        public DbSet<Irimies_Rares_lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Irimies_Rares_lab8.Models.Category> Category { get; set; }
    }
}
