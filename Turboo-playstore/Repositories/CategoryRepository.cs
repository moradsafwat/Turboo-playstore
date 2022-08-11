using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Turboo_playstore.Data;
using Turboo_playstore.Models;
using Turboo_playstore.Repositories.Interfaces;

namespace Turboo_playstore.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext _db):base(_db)
        {
        }
    }
}
