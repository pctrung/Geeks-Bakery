using System;
using System.Collections.Generic;

namespace GeeksBakery.Data.Entities
{
    public class Cake
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal OriginalPrice { get; set; }
        public int Size { get; set; }

        public string Slug { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }
        public DateTime? DateModified { get; set; }
        public DateTime? DateDeleted { get; set; }

        public DateTime DateCreated { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public List<CakeImage> CakeImages { get; set; }
        public List<Rate> Rates { get; set; }
    }
}