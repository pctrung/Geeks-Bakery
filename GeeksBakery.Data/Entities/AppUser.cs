using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GeeksBakery.Data.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
        [Required]
        public string Name { get; set; }

#nullable enable
        public string? Address { get; set; }

        public string? Avatar { get; set; }
#nullable disable
        public DateTime DoB { get; set; }

        public List<Order> Orders { get; set; }

        public List<Cart> Carts { get; set; }
    }
}