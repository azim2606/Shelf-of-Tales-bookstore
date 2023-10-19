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
    public class DeleteModel : PageModel
    {
        private readonly Shelf_of_Tales_bookstore.Data.Shelf_of_Tales_bookstoreContext _context;

        public DeleteModel(Shelf_of_Tales_bookstore.Data.Shelf_of_Tales_bookstoreContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Shops == null)
            {
                return NotFound();
            }
            var shops = await _context.Shops.FindAsync(id);

            if (shops != null)
            {
                Shops = shops;
                _context.Shops.Remove(Shops);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
