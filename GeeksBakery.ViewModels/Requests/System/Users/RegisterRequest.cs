using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace GeeksBakery.ViewModels.Requests.System.Users
{
    public class RegisterRequest
    {
        [Required(ErrorMessage = "Please enter username")]
        [Display(Name = "Username:", Prompt = "Username...")]
        [RegularExpression("^(?=[a-zA-Z0-9._]{8,20}$)(?!.*[_.]{2})[^_.].*[^_.]$",
            ErrorMessage = "Username must be 8-20 characters long, does not contain special characters")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter password")]
        [DataType(DataType.Password)]
        [Display(Name = "Password:", Prompt = "********")]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[#$^+=!*()@%&]).{8,}$",
            ErrorMessage = "Passwords must be at least 6 characters, one digit, one uppercase, one non alphanumeric character")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please enter confirmation password")]
        [Compare("Password", ErrorMessage = "Password and Confirmation Password must match")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirmation Password:", Prompt = "********")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Please enter your full name")]
        [Display(Name = "Full Name:", Prompt = "Your full name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter email")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email:", Prompt = "example@example.com")]
        [RegularExpression("^[a-z][a-z0-9_\\.]{5,32}@[a-z0-9]{2,}(\\.[a-z0-9]{2,4}){1,2}$", ErrorMessage = "Email is invalid")]
        public string Email { get; set; }
    }
}