using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Shop.Domain.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }

        [Display(Name = "Coffee")]
        public int StockCoffee { get; set; }

        [Display(Name = "Water")]
        public int StockWater { get; set; }
        [Display(Name = "Milk")]
        public int StockMilk { get; set; }
        [Display(Name = "Ice-cream")]
        public int StockIceCream { get; set; }

        [Display(Name = "Chocolate")]
        public int StockChocolate { get; set; }
        [Display(Name = "Sugar")]
        public int StockSugar { get; set; }

        //public virtual ICollection<OrderLine>? OrderLines { get; set; }

    }
}
