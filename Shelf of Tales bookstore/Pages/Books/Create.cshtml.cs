using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Shelf_of_Tales_bookstore.Data;
using Shelf_of_Tales_bookstore.Models;

namespace Shelf_of_Tales_bookstore.Pages.Books
{
    public class CreateModel : PageModel
    {
        private readonly Shelf_of_Tales_bookstore.Data.Shelf_of_Tales_bookstoreContext _context;

        public CreateModel(Shelf_of_Tales_bookstore.Data.Shelf_of_Tales_bookstoreContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Book Book { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Book == null || Book == null)
            {
                return Page();
            }

            _context.Book.Add(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
