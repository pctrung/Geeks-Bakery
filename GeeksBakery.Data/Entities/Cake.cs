using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksBakery.Data.Entities
{
    public class Cake
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Size { get; set; }

        #nullable enable
        public string? SEOAlias { get; set; }
        public int? Stock { get; set; }
        public string? Description { get; set; }
        public decimal? OriginalPrice { get; set; }
        public DateTime? DateModified { get; set; }
        public DateTime? DateDeleted { get; set; }
        #nullable disable

        public DateTime DateCreated;

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public List<CakeImage> CakeImages { get; set; }
    }
}
