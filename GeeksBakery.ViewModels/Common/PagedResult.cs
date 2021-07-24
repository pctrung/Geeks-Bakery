using System.Collections.Generic;

namespace GeeksBakery.ViewModels.Common
{
    public class PagedResult<T> : PagedResultBase
    {
        public List<T> Items { get; set; }
#nullable enable

        // for paged cakes
        public List<string>? CategoryNames { get; set; }

        public List<int>? CategoryIds { get; set; }

#nullable disable
    }
}