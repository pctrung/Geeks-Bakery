﻿namespace GeeksBakery.ViewModels.Catalog.Cakes.Dtos
{
    public class CakeUpdateRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal OriginalPrice { get; set; }
        public int Size { get; set; }
        public string SEOAlias { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }

        public int CategoryId { get; set; }
    }
}
