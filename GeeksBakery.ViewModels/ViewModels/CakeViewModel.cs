using GeeksBakery.ViewModels.Catalog.CakeImage;
using System.Collections.Generic;

namespace GeeksBakery.ViewModels.ViewModels
{
    public class CakeViewModel
    {
        //private List<CakeImageViewModel> _cakeImages;
        //private List<ReviewViewModel> _reviews;

        //public List<CakeImageViewModel> CakeImages
        //{
        //    get => _cakeImages == null ? new List<CakeImageViewModel>() : _cakeImages;
        //    set => _cakeImages = value;
        //}

        //public List<ReviewViewModel> Reviews
        //{
        //    get => _reviews == null ? new List<ReviewViewModel>() : _reviews;
        //    set => _reviews = value;
        //}

        public List<CakeImageViewModel> CakeImages { get; set; }
        public List<ReviewViewModel> Reviews { get; set; }

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
        public double AvgStar { get; set; }
    }
}