using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Turboo_playstore.Models
{
    public class InvoiceDetails
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public double Quantity { get; set; }
        public string Amount { get; set; }

        public int InvoiceId { get; set; }
        public Invoice Invoice { get; set; }
    }
}
