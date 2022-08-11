using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Turboo_playstore.Models;
using Turboo_playstore.ViewModels;

namespace Turboo_playstore.AutoMapperProfile
{
    public class MappingProfile : Profile 
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductViewModel>()
                .ForMember(d => d.CategoryName, s => s.MapFrom(s => s.Category.Name))
                .ForMember(d => d.ImageView, s => s.MapFrom(s => s.Image)); 
            CreateMap<ProductViewModel, Product>();
            CreateMap<CategoryViewModel, Category>();
            CreateMap<Category, CategoryViewModel>();
        }
    }
}
