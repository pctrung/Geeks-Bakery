using System.Collections.Generic;

namespace GeeksBakery.Data.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public List<Cake> Products { get; set; }
    }
}
