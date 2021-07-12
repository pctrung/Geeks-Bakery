using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksBakery.ViewModels.ViewModels
{
    public class UserViewModel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Avatar { get; set; }
        public DateTime DoB { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string UserName { get; set; }
        public Guid Id { get; set; }

        public List<OrderViewModel> Orders { get; set; }

        public List<CartViewModel> Carts { get; set; }
    }
}