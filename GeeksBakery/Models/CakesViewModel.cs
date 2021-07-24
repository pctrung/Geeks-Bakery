using GeeksBakery.ViewModels.Common;
using GeeksBakery.ViewModels.ViewModels;
using System.Collections.Generic;

namespace GeeksBakery.ClientSite.Models
{
    public class CakesViewModel
    {
        public PagedResult<CakeViewModel> Cakes;
        public List<CategoryViewModel> Categories;
        //private PagedResult<CakeViewModel> _cakes;
        //private List<CategoryViewModel> _categories;

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
    }
}