using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibraryMgmtApp.Models;

namespace LibraryMgmtApp.ViewModels
{
    public class IndexProductViewModel
    {
        public Product Product { get; set; }
        public List<Customer> Customers { get; set; }
    }
}