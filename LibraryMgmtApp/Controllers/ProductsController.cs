using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibraryMgmtApp.Models;
using LibraryMgmtApp.ViewModels;

namespace LibraryMgmtApp.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index(string sortBy)
        {
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            var product = new Product()
            {
                Name = "Carrie",
                Author = "Stephen King",
                Category = ProductCategory.Book,
                ReleaseYear = 1976
            };

            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2" }
            };

            var viewModel = new IndexProductViewModel
            {
                Product = product,
                Customers = customers
            };

            return View(viewModel);
        }
    }
}