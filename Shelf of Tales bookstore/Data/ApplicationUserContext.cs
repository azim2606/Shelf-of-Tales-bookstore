using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Shelf_of_Tales_bookstore.Models;

namespace Shelf_of_Tales_bookstore.Data
{
    public class ApplicationUserContext : DbContext
    {
        public ApplicationUserContext (DbContextOptions<ApplicationUserContext> options)
            : base(options)
        {
        }

        public DbSet<Shelf_of_Tales_bookstore.Models.Registration> Registration { get; set; } = default!;
    }
}
