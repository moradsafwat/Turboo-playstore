using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Turboo_playstore.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Brand { get; set; }

        public double WholeSalePrice { get; set; }
        public double SellingPrice { get; set; }
        public double Quantity { get; set; }


        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
