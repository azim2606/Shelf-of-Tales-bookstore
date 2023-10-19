using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Shelf_of_Tales_bookstore.Data;
using Shelf_of_Tales_bookstore.Models;

namespace Shelf_of_Tales_bookstore.Pages.Shops
{
    public class IndexModel : PageModel
    {
        private readonly Shelf_of_Tales_bookstore.Data.Shelf_of_Tales_bookstoreContext _context;

        public IndexModel(Shelf_of_Tales_bookstore.Data.Shelf_of_Tales_bookstoreContext context)
        {
            _context = context;
        }

        public IList<Shops> Shops { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Shops != null)
            {
                Shops = await _context.Shops.ToListAsync();
            }
        }
    }
}
