using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVCCRUD.ViewModel
{
    public class ProductViewModel: EditImageViewModel
    {
        [DisplayName("ProductName")]
        [StringLength(100)]
        [Required]
        public string Name { get; set; }
        [DisplayName("Price")]
        [Required]
        public decimal Price { get; set; }
       
    }
}
