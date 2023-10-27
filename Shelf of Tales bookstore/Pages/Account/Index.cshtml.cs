using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Shelf_of_Tales_bookstore.Data;
using Shelf_of_Tales_bookstore.Models;

namespace Shelf_of_Tales_bookstore.Pages.Account
{
    public class IndexModel : PageModel
    {
        private readonly Shelf_of_Tales_bookstore.Data.ApplicationUserContext _context;

        public IndexModel(Shelf_of_Tales_bookstore.Data.ApplicationUserContext context)
        {
            _context = context;
        }

        public IList<Registration> Registration { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Registration != null)
            {
                Registration = await _context.Registration.ToListAsync();
            }
        }
    }
}
