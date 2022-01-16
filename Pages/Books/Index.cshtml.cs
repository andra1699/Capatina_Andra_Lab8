using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Capatina_Andra_Lab8.Data;
using Capatina_Andra_Lab8.Models;

namespace Capatina_Andra_Lab8.Pages
{
    public class IndexModel : PageModel
    {
        private readonly Capatina_Andra_Lab8.Data.Capatina_Andra_Lab8Context _context;

        public IndexModel(Capatina_Andra_Lab8.Data.Capatina_Andra_Lab8Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }

        public async Task OnGetAsync()
        {
            Book = await _context.Book
                .Include(b => b.Publisher)
                .ToListAsync();
        }
    }
}
