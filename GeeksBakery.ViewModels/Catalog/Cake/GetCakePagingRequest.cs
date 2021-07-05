using GeeksBakery.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksBakery.ViewModels.Catalog.Dtos
{
    public class GetCakePagingRequest : PagingRequestBase
    {
        public string Keyword{ get; set; }
        public List<int> CategoryIds { get; set; }
    }
}
