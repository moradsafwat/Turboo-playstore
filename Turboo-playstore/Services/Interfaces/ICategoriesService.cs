using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Turboo_playstore.Models;
using Turboo_playstore.ViewModels;

namespace Turboo_playstore.Services.Interfaces
{
    public interface ICategoriesService
    {
        IEnumerable<CategoryViewModel> GetAll();
    }
}
