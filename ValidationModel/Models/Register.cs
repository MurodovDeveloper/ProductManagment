﻿using System.ComponentModel.DataAnnotations;

namespace MVCCRUD.ValidationModel.Models
{
    public class Register
    {

        public Guid Id { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "pasword did not match")]
        public string ConfirmPassword { get; set; }
    }
}
