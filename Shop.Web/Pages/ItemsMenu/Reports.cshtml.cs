using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Shop.Domain.Models;
using Shop.Web.Data;

namespace Shop.Web.Pages.ItemsMenu
{
    [Authorize(Policy = "MustBeStaffManager")]
    public class ReportsModel : PageModel
    {
        private readonly Shop.Web.Data.ShopWebContext _context;

        public ReportsModel(Shop.Web.Data.ShopWebContext context)
        {
            _context = context;
        }

        // to be continued...
        public IList<Product> Product { get;set; } = default!;
        public string? SearchString { get; set; }
        public int? StockMilk { get; set; }

        public async Task OnGetAsync()
        {
         
        }
    }
}
