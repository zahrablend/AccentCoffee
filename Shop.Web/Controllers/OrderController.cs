using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Newtonsoft.Json.Linq;

namespace Shop.Web.Controllers
{
    public class OrderViewModel
    {
        public LineItem[] LineItems { get; set; }
        public float DiscountPercentage { get; set; }
        public float paidInCashEur { get; set; }
    }

    public class LineItem
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }

    [Route("api/constroller")]
    public class OrderController : Controller
    {
        [HttpPost]
        public IActionResult Create([FromBody] OrderViewModel order)
        {
            // 1. Generate the receipt from the order param and data from the database
            // 2. Save the receipt to the database
            return Json(new { OrderId = 123123 });
        }

        [HttpGet]
        public IActionResult Create(string name)
        {
            return Json(
                new
                {
                    Name = "Zahra",
                    Course = "C#"
                }
                );
        }
    }
}
