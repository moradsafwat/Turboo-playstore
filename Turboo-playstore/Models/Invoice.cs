using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Turboo_playstore.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public double TotalAmount { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public List<InvoiceDetails> InvoicesDetails { get; set; }
    }
}
