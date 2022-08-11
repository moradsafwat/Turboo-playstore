using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Turboo_playstore.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // relation with product
        public List<Product> Products { get; set; }
    }
}
