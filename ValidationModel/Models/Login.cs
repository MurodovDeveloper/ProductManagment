using System.ComponentModel.DataAnnotations;

namespace MVCCRUD.ValidationModel.Models
{
    public class Login
    {
        public Guid Id { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
