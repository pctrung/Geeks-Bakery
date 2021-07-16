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
        public PagedResult<CakeViewModel> Cakes { get; set; }
        public List<CakeViewModel> FeaturedCakes { get; set; }
        public List<CategoryViewModel> Categories { get; set; }
        public UserViewModel User { get; set; }
    }
}