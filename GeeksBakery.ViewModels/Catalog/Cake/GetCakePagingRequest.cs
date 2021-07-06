using GeeksBakery.ViewModels.Common;
using System.Collections.Generic;

namespace GeeksBakery.ViewModels.Catalog.Dtos
{
    public class GetCakePagingRequest : PagingRequestBase
    {
#nullable enable
        public string? Keyword { get; set; }
        public List<int>? CategoryIds { get; set; }
#nullable disable
    }
}
