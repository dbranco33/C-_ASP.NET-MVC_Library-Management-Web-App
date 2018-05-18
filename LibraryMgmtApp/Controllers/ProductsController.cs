using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibraryMgmtApp.Models;

namespace LibraryMgmtApp.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            var product = new Product()
            {
                Name = "Carrie",
                Author = "Stephen King",
                Category = ProductCategory.Book,
                ReleaseYear = 1976
            };

            return View(product);
        }
    }
}