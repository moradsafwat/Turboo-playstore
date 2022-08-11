using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Turboo_playstore.Models;

namespace Turboo_playstore.Repositories.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> GetProductsWithCategory(int categoryId);
        IEnumerable<Product> GetProductsWithCategory();
    }
}
