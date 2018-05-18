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
            var products = _context.Products.Include(p => p.Category).Include(p => p.Genre).ToList();

            if (products == null) { return HttpNotFound(); }

            return View(products);
        }

        public ActionResult Details(int id)
        {
            //get all products in the database
            var products = _context.Products.Include(p=> p.Category).Include(p => p.Genre).SingleOrDefault(p => p.Id == id);

            if (products == null) { return HttpNotFound(); }

            return View(products);
        }
    }
}