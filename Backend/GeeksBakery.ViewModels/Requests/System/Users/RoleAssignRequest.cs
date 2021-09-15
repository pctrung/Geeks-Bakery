using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksBakery.ViewModels.Requests.System.Users
{
    public class RoleAssignRequest
    {
        public List<RoleSelect> Roles { get; set; } = new List<RoleSelect>();
    }

    public class RoleSelect
    {
        public string Name { get; set; }
        public bool Selected { get; set; }
    }
}