using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain.Models
{
    public class Receipt
    {
        //receipt info should be readonly (only for displaying; no modifications)
        public int ReceiptId { get; set; }
        public DateTime Created { get; set; }

        public List<OrderLine>? Items { get; set; }

        public double Total { get; private set; }

        public virtual ICollection<OrderLine>? OrderLines  { get; set; } 
        public override string ToString()
        {
            return $"Receipt Nr. {ReceiptId} | {Created: dd.MM.yy hh:mm:ss}";
        }

    }
}
