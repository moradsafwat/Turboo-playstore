using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Turboo_playstore.Models;
using Turboo_playstore.Repositories.Interfaces;
using Turboo_playstore.Services.Interfaces;
using Turboo_playstore.ViewModels;

namespace Turboo_playstore.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IWebHostEnvironment _webHost;
        private readonly IProductsService _productsService;
        private readonly ICategoriesService _categoriesService;
        public ProductsController(IWebHostEnvironment webHost, 
            IProductsService productsService, 
            ICategoriesService categoriesService)
        {
            _webHost = webHost;
            _productsService = productsService;
            _categoriesService = categoriesService;
        }

        // GET: ProductsController
        public ActionResult Index()
        {
            var products = _productsService.GetAll();
            return View(products);
        }
        // GET: Products by Category
        public ActionResult Products(int id)
        {
            return View(_productsService.GetByCategoryId(id));
        }

        // GET: ProductsController/Details/5
        public ActionResult DetailsProduct(int id)
        {
            var product = _productsService.GetById(id);
            if (product != null)
                return View(product);

            return View();
        }

        // GET: ProductsController/Create
        public ActionResult CreateProduct()
        {
            var model = new ProductViewModel
            {
                Categories = _categoriesService.GetAll().ToList()
            };

            return View(model);
        }

        // POST: ProductsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateProduct(ProductViewModel productVm)
        {
            try
            {
                string fileName = string.Empty;
                if (ModelState.IsValid)
                {
                    if(productVm.ImageFile != null)
                    {
                        string uploads = Path.Combine(_webHost.WebRootPath, "Uploads");
                        fileName = productVm.ImageFile.FileName;

                        string fullPath = Path.Combine(uploads, fileName);
                        productVm.ImageFile.CopyTo(new FileStream(fullPath, FileMode.Create));
                    };
                    _productsService.Create(productVm);
                    return RedirectToAction("Index", "Products");
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductsController/Edit/5
        public ActionResult EditProduct(int id)
        {
            var product = _productsService.GetById(id);

            if (product != null)
            {
                product.Categories = _categoriesService.GetAll().ToList();
                return View(product);
            };
            return View();
        }

        // POST: ProductsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditProduct(int id, ProductViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string fileName = string.Empty;
                    if(model.ImageFile != null)
                    {
                        string uploads = Path.Combine(_webHost.WebRootPath, "Uploads");
                        fileName = model.ImageFile.FileName;

                        string fullPath = Path.Combine(uploads, fileName);
                        model.ImageFile.CopyTo(new FileStream(fullPath, FileMode.Create));
                    }
                    _productsService.Update(id, model);
                    return RedirectToAction("Index", "Products");
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductsController/Delete/5
        public ActionResult DeleteProduct(int id)
        {
            var product = _productsService.GetById(id);
            if (product != null)
                return View(product);

            return View();
        }

        // POST: ProductsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteProduct(int id, ProductViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _productsService.Delete(model);
                    return RedirectToAction("Index", "Products");
                }
                return View();
            }
            catch
            {
                return View();
            }
        }
    }
}
