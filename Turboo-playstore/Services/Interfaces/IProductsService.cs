using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Turboo_playstore.Models;
using Turboo_playstore.ViewModels;

namespace Turboo_playstore.Services.Interfaces
{
    public interface IProductsService
    {
        ProductViewModel GetById(int id);
        IEnumerable<ProductViewModel> GetByCategoryId(int id);
        IEnumerable<ProductViewModel> GetAll();
        void Create(ProductViewModel productVm);
        void Delete(ProductViewModel productVm);
        void Update(int id, ProductViewModel productVm);
    }
}
