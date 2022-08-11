using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Turboo_playstore.Data;
using Turboo_playstore.Models;
using Turboo_playstore.Repositories.Interfaces;

namespace Turboo_playstore.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext _db):base(_db)
        {
        }

        public IEnumerable<Product> GetProductsWithCategory(int categoryId)
        {
            return db.Products.Include(c => c.Category).Where(c => c.CategoryId == categoryId).ToList();
        }
        public IEnumerable<Product> GetProductsWithCategory()
        {
            return db.Products.Include(c => c.Category).ToList();
        }
    }
}
