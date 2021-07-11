using System;
using System.ComponentModel.DataAnnotations;

namespace GeeksBakery.Data.Entities
{
    public class Cart
    {
        [Key]
        public Guid UserId { get; set; }

        public AppUser User { get; set; }

        [Key]
        public int CakeId { get; set; }

        public Cake Cake { get; set; }
        public int Amount { get; set; }
    }
}