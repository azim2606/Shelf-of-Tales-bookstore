using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Shelf_of_Tales_bookstore.Models;

namespace Shelf_of_Tales_bookstore.Data
{
    public class Shelf_of_Tales_bookstoreContext : DbContext
    {
        public Shelf_of_Tales_bookstoreContext (DbContextOptions<Shelf_of_Tales_bookstoreContext> options)
            : base(options)
        {
        }

        public DbSet<Shelf_of_Tales_bookstore.Models.Shops> Shops { get; set; } = default!;
    }
}
