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
    public class CategoriesService : ICategoriesService
    {
        private readonly IMapper _mapper;
        private readonly ICategoryRepository _categoryRepository;
        public CategoriesService(IMapper mapper, ICategoryRepository categoryRepository)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }

        public IEnumerable<CategoryViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<CategoryViewModel>>(_categoryRepository.List());
        }
    }
}
