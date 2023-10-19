using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Shelf_of_Tales_bookstore.Data;
using Shelf_of_Tales_bookstore.Models;

namespace Shelf_of_Tales_bookstore.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly Shelf_of_Tales_bookstore.Data.Shelf_of_Tales_bookstoreContext _context;

        public DetailsModel(Shelf_of_Tales_bookstore.Data.Shelf_of_Tales_bookstoreContext context)
        {
            _context = context;
        }

      public Book Book { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Book == null)
            {
                return NotFound();
            }

            var book = await _context.Book.FirstOrDefaultAsync(m => m.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            else 
            {
                Book = book;
            }
            return Page();
        }
    }
}
