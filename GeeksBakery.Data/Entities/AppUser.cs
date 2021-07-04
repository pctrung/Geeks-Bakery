using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace GeeksBakery.Data.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
        public string Name { get; set; }

        public string Address { get; set; }

        [DefaultValue("default.png")]
        public string Avatar { get; set; }

        public DateTime DoB { get; set; }

        public List<Order> Orders { get; set; }
        public List<Cart> Carts { get; set; }
    }
}