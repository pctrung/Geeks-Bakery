using System.ComponentModel.DataAnnotations;

namespace GeeksBakery.Data.Entities
{
    public class OrderDetail
    {
        [Key]
        public int OrderId { get; set; }
        public Order Order { get; set; }
        [Key]
        public int CakeId { get; set; }
        public Cake Cake { get; set; }
        public int Amount { get; set; }
    }
}
