using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Turboo_playstore.Models;

namespace Turboo_playstore.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public IFormFile ImageFile { get; set; }
        public string ImageView { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Brand { get; set; }

        public double WholeSalePrice { get; set; }
        public double SellingPrice { get; set; }
        public double Quantity { get; set; }
        
        
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public List<CategoryViewModel> Categories { get; set; }
    }
}
