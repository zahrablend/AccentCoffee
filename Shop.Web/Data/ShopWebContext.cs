using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Shop.Domain.Models;

namespace Shop.Web.Data
{
    public class ShopWebContext : DbContext
    {
        public ShopWebContext (DbContextOptions<ShopWebContext> options)
            : base(options)
        {
        }

        public DbSet<Shop.Domain.Models.Product> Product { get; set; } = default!;
    }
}
