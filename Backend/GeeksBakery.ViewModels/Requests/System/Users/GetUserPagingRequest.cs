using GeeksBakery.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksBakery.ViewModels.Requests.System.Users
{
    public class GetUserPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
    }
}