using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace GeeksBakery.ViewModels.ViewModels
{
    public class UserViewModel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string AvatarUrl { get; set; }
        public DateTime DoB { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Id { get; set; }
        public IList<string> Roles { get; set; }
        public List<OrderViewModel> Orders { get; set; }
        public List<CartViewModel> Carts { get; set; }
    }
}