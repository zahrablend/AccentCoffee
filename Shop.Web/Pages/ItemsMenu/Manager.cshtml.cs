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

namespace Shop.Web.Pages.ItemsMenu
{
    [Authorize(Policy = "MustBeStaffManager")]
    public class ManagerModel : PageModel
    {
        private readonly Shop.Web.Data.ShopWebContext _context;

        public ManagerModel(Shop.Web.Data.ShopWebContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Product != null)
            {
                Product = await _context.Product.ToListAsync();
            }
        }
    }
}
