using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace GeeksBakery.ViewModels.Requests.System.Users
{
    public class RegisterRequest
    {
        [Required(ErrorMessage = "Please enter username")]
        [Display(Name = "Username:", Prompt = "Username...")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter password")]
        [DataType(DataType.Password)]
        [Display(Name = "Password:", Prompt = "********")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please enter confirmation password")]
        [Compare("Password", ErrorMessage = "Password and Confirmation Password must match")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirmation Password:", Prompt = "********")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Please enter your full name")]
        [Display(Name = "Full Name:", Prompt = "Your full name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter phone number")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number:", Prompt = "Your phone number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please enter email")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email:", Prompt = "example@example.com")]
        public string Email { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Birthday:", Prompt = "Your birthday...")]
        [Required(ErrorMessage = "Please enter birthday")]
        public DateTime DoB { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Address:", Prompt = "Your address...")]
        public string Address { get; set; }

        public IFormFile Avatar { get; set; }
    }
}