using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Capatina_Andra_Lab8.Models;

namespace Capatina_Andra_Lab8.Data
{
    public class Capatina_Andra_Lab8Context : DbContext
    {
        public Capatina_Andra_Lab8Context (DbContextOptions<Capatina_Andra_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Capatina_Andra_Lab8.Models.Book> Book { get; set; }

        public DbSet<Capatina_Andra_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Capatina_Andra_Lab8.Models.BookCategory> BookCategory { get; set; }
    }
}
