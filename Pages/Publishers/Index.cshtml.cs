using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Capatina_Andra_Lab8.Data;
using Capatina_Andra_Lab8.Models;

namespace Capatina_Andra_Lab8.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Capatina_Andra_Lab8.Data.Capatina_Andra_Lab8Context _context;

        public IndexModel(Capatina_Andra_Lab8.Data.Capatina_Andra_Lab8Context context)
        {
            _context = context;
        }

        public IList<Models.Publisher> Publisher { get;set; }

        public async Task OnGetAsync()
        {
            Publisher = await _context.Publisher.ToListAsync();
        }
    }
}
