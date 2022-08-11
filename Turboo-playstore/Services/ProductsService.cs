using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Turboo_playstore.Models;
using Turboo_playstore.Repositories.Interfaces;
using Turboo_playstore.Services.Interfaces;
using Turboo_playstore.ViewModels;

namespace Turboo_playstore.Services
{
    public class ProductsService : IProductsService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public ProductsService(IMapper mapper,  IProductRepository productRepository)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }

        public IEnumerable<ProductViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<ProductViewModel>>(_productRepository.GetProductsWithCategory().OrderBy(n => n.Name));
        }

        public ProductViewModel GetById(int id)
        {
            return _mapper.Map<ProductViewModel>(_productRepository.Find(id));
        }

        public IEnumerable<ProductViewModel> GetByCategoryId(int id)
        {
            return _mapper.Map<IEnumerable<ProductViewModel>>
                (_productRepository.GetProductsWithCategory(id));
        }

        public void Create(ProductViewModel productVm)
        {
            var product = _mapper.Map<Product>(productVm);
            _productRepository.Add(product);
        }

        public void Delete(ProductViewModel productVm)
        {
            var product = _mapper.Map<Product>(productVm);
            _productRepository.Remove(product);

        }

        public void Update(int id, ProductViewModel productVm)
        {
            var product = _mapper.Map<Product>(productVm);
            _productRepository.Update(product);
        }
    }
}
