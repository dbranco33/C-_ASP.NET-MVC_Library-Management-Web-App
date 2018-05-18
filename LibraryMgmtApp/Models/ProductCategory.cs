using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryMgmtApp.Models
{
    public class ProductCategory
    {
        [Key]
        public int Id { get; set; }

        [StringLength(255)]
        [Required(ErrorMessage = "This field is mandatory")]
        public string Name { get; set; }
    }
}