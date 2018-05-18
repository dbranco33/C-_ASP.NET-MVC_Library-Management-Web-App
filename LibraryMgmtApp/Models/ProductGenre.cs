using System.ComponentModel.DataAnnotations;

namespace LibraryMgmtApp.Models
{
    public class ProductGenre
    {
        [Key]
        public int Id { get; set; }

        [StringLength(255)]
        [Required(ErrorMessage = "This field is mandatory")]
        public string Name { get; set; }
    }
}