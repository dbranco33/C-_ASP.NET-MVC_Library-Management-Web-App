using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace LibraryMgmtApp.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [StringLength(255)]
        [Required(ErrorMessage = "This field is mandatory")]
        public string Name { get; set; }

        public string Author { get; set; }

        [Required(ErrorMessage = "This field is mandatory")]
        public ProductCategory Category { get; set; }

        public int ReleaseYear { get; set; }
    }
}