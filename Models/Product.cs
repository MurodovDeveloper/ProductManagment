using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCCRUD.Models
{
    [Table("Product")]
    public class Product
    {
        [Column("product_id")]
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("product_name")]
        [StringLength(50)]
        public string Name { get; set; }
      
        [Column("price")]
        public decimal Price { get; set; }
    }
} 
