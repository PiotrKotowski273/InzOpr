﻿using System.ComponentModel.DataAnnotations;

namespace TASKERApp.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Hasła nie są zgodne.")]
        public string ConfirmPassword { get; set; }
    }
}
