using System.Collections.Generic;

namespace GeeksBakery.Data.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public string Description { get; set; }
        public List<Cake> Cakes { get; set; }
    }
}