using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksBakery.Data.Entities
{
    public class Cake
    {
        public int Id { get; set; }
        public string SEOAlias { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal OriginalPrice { get; set; }
        public int Size { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime? Updated_At { get; set; }
        public DateTime? Deleted_At { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
