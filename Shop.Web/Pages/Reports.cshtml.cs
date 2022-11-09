using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Shop.Domain.Models;
using Shop.Web.Data;

namespace Shop.Web.Pages
{
    [Authorize]
    public class ReportsModel : PageModel
    {
        private readonly ShopWebContext _context;

        public ReportsModel(ShopWebContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public async Task OnGetAsync()
        {
            //  wrong query or smth...
            IQueryable<string> milkQuery = from p in _context.Product
                                           where p.StockMilk > 0
                                           orderby p.StockMilk
                                           select p.Name;


            var products = from p in _context.Product
                           select p;


            if (!string.IsNullOrEmpty(SearchString))
            {
                products = products.Where(s => s.Name.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(products.ToQueryString()));

            Product = await _context.Product.ToListAsync();
        }
    }
}
