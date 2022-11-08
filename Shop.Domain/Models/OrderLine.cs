using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain.Models
{
    public class OrderLine
    {
        public int OrderLineId { get; set; }
        public int ReceiptId { get; set; }
        public int ProductId { get; set; }
        public int Count { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Total { get; private set; }

        
        public virtual Receipt? Receipt { get; set; }
        public virtual Product? Product { get; set; }
        public virtual Report? Report { get; set; }

        private readonly List<OrderLine> _orderLines = new List<OrderLine>();

        private readonly List<Product> _products = new();
        public void AddProduct(Product product)
        {
            if (Count <= 0)
            {
                throw new ArgumentOutOfRangeException("Count must be greater than zero.");
            }
            _products.Add(product);
            Subtotal = product.Price * Count;
        }
        public IReadOnlyCollection<OrderLine> OrderLines => _orderLines;

        public void AddOrderLine(OrderLine orderLine)
        {
            _orderLines.Add(orderLine);
            Total += orderLine.Subtotal;
        }

    }
}
