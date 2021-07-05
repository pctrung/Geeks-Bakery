using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksBakery.ViewModels.Common
{
    public class PagingRequestBase
    {
        public int PageSize { get; set; }
        public int PageIndex { get; set; }
    }
}
