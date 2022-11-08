using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain.Models
{
    public class Report
    {
        public int ReportId { get; set; }
        public string ReportName { get; set; } = string.Empty;
        public DateTime Created { get; set; }
        public virtual ICollection<OrderLine>? Sales { get; set; }
        public override string ToString()
        {
            return $"Report created: {Created: dd.MM.yy hh:mm:ss}";
        }
    }
}
