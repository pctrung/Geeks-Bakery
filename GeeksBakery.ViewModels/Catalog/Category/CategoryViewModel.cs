using GeeksBakery.ViewModels.Catalog.Cakes.Dtos;
using System.Collections.Generic;

namespace GeeksBakery.ViewModels.Catalog.Category
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public List<CakeViewModel> Products { get; set; }
    }
}
