using GeeksBakery.ViewModels.Catalog.CakeImage;
using System.Collections.Generic;

namespace GeeksBakery.ViewModels.Catalog.Cakes.Dtos
{
    public class CakeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal OriginalPrice { get; set; }
        public int Size { get; set; }

        public string SEOAlias { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }

        public string CategoryName { get; set; }
        public int CategoryId { get; set; }
        public List<CakeImageViewModel> CakeImages { get; set; }
    }
}
