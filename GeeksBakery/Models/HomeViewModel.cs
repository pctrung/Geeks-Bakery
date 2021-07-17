using GeeksBakery.ViewModels.Common;
using GeeksBakery.ViewModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeeksBakery.ClientSite.Models
{
    public class HomeViewModel
    {
        //private PagedResult<CakeViewModel> _cakes;
        //private List<CategoryViewModel> _categories;
        //private List<CakeViewModel> _featuredCakes;

        //public PagedResult<CakeViewModel> Cakes
        //{
        //    get => _cakes == null ? new PagedResult<CakeViewModel>() { Items = new List<CakeViewModel>() } : _cakes;
        //    set => _cakes = value;
        //}

        //public List<CategoryViewModel> Categories
        //{
        //    get => _categories == null ? new List<CategoryViewModel>() : _categories;
        //    set => _categories = value;
        //}

        //public List<CakeViewModel> FeaturedCakes
        //{
        //    get => _featuredCakes == null ? new List<CakeViewModel>() : _featuredCakes;
        //    set => _featuredCakes = value;
        //}
        public PagedResult<CakeViewModel> Cakes { get; set; }

        public List<CategoryViewModel> Categories { get; set; }
        public List<CakeViewModel> FeaturedCakes { get; set; }
    }
}