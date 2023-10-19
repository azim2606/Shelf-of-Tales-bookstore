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
    public class DetailsModel : PageModel
    {
        private readonly Shelf_of_Tales_bookstore.Data.Shelf_of_Tales_bookstoreContext _context;

        public DetailsModel(Shelf_of_Tales_bookstore.Data.Shelf_of_Tales_bookstoreContext context)
        {
            _context = context;
        }

      public Shops Shops { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Shops == null)
            {
                return NotFound();
            }

            var shops = await _context.Shops.FirstOrDefaultAsync(m => m.Id == id);
            if (shops == null)
            {
                return NotFound();
            }
            else 
            {
                Shops = shops;
            }
            return Page();
        }
    }
}
