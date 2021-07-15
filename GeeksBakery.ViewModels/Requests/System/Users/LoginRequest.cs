using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace GeeksBakery.ViewModels.Requests.System.Users
{
    public class LoginRequest
    {
        [Required(ErrorMessage = "Please enter username or email")]
        [Display(Name = "Username or Email:", Prompt = "Username or email...")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter password")]
        [DataType(DataType.Password)]
        [Display(Name = "Password:", Prompt = "********")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}