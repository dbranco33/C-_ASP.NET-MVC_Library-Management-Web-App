using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using LibraryMgmtApp.Models;
using LibraryMgmtApp.ViewModels;

namespace LibraryMgmtApp.Controllers
{
    public class ProductsController : Controller
    {
        private ApplicationDbContext _context;

        public ProductsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Products
        public ActionResult Index(string sortBy)
        {
            var products = _context.Products.Include(p => p.Category).ToList();

            if (products == null) { return HttpNotFound(); }

            return View(products);
        }
    }
}