using System.ComponentModel.DataAnnotations;

namespace GeeksBakery.ViewModels.Requests.System.Users
{
    public class LoginRequest
    {
        [Required(ErrorMessage = "Username is required.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}