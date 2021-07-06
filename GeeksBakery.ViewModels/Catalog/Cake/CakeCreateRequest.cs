using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksBakery.ViewModels.Catalog.Cakes.Dtos
{
    public class CakeCreateRequest
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal OriginalPrice { get; set; }
        public int Size { get; set; }
        public string SEOAlias { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }

        public int CategoryId { get; set; }

        public IFormFile Thumbnail { get; set; }
    }
}
