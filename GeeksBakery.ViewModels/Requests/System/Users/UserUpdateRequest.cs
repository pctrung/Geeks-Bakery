using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GeeksBakery.ViewModels.Requests.System.Users
{
    public class UserUpdateRequest
    {
        public Guid Id { get; set; }

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