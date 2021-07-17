using GeeksBakery.Utilities.SystemConstants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace GeeksBakery.ViewModels.ViewModels
{
    public class UserViewModel
    {
        //private IList<string> _roles;

        //public IList<string> Roles
        //{
        //    get => _roles == null ? new List<string>() : _roles;
        //    set => _roles = value;
        //}

        public IList<string> Roles { get; set; }

        private string _avatarUrl;

        public string AvatarUrl
        {
            get => string.IsNullOrEmpty(_avatarUrl) ? SystemConstants.DEFAULT_AVATAR_URL : _avatarUrl;
            set => _avatarUrl = value;
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime DoB { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Id { get; set; }
    }
}