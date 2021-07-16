using GeeksBakery.ViewModels.Common;
using GeeksBakery.ViewModels.ViewModels;
using System.Collections.Generic;

namespace GeeksBakery.ClientSite.Models
{
    public class CakesViewModel
    {
        public PagedResult<CakeViewModel> Cakes { get; set; }
        public List<CategoryViewModel> Categories { get; set; }
    }
}