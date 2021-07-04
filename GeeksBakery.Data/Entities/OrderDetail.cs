using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksBakery.Data.Entities
{
    public class OrderDetail
    {
        public int OrderId { get; set; }
        public Order Order{ get; set; }
        public int CakeId { get; set; }
        public Cake Cake{ get; set; }
        public int Amount { get; set; }
    }
}
