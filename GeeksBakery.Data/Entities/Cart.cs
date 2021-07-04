using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
