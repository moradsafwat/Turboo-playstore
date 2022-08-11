using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Turboo_playstore.Controllers
{
    public class InvoiceDetailsController : Controller
    {
        // GET: InvoiceDetailsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: InvoiceDetailsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: InvoiceDetailsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InvoiceDetailsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InvoiceDetailsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: InvoiceDetailsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InvoiceDetailsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: InvoiceDetailsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
