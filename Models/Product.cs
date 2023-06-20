using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCCRUD.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public Guid Id { get; set; }
        [DisplayName("ProductName")]
        [StringLength(100)]
        [Required]
        public string Name { get; set; }
        [DisplayName("Price")]
        [Required]
        public decimal Price { get; set; }
        [Required]
        [Display(Name = "Image")]
        public string ProductPicture { get; set; }

    }
} 
