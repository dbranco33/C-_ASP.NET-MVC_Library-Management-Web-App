using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using LibraryMgmtApp.Models;

namespace LibraryMgmtApp.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose (bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customers/Index
        public ActionResult Index()
        {
            //get all customers in the database
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();

            if(customers == null) { return HttpNotFound(); }

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            //get all customers in the database
            var customers = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customers == null) { return HttpNotFound(); }

            return View(customers);
        }
    }
}