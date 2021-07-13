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
        [RegularExpression("^(0|\\+84)(\\s|\\.)?((3[2-9])|(5[689])|(7[06-9])|(8[1-689])|(9[0-46-9]))(\\d)(\\s|\\.)?(\\d{3})(\\s|\\.)?(\\d{3})$",
            ErrorMessage = "Phone number is invalid")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please enter email")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email:", Prompt = "example@example.com")]
        [RegularExpression("^[a-z][a-z0-9_\\.]{5,32}@[a-z0-9]{2,}(\\.[a-z0-9]{2,4}){1,2}$", ErrorMessage = "Email is invalid")]
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