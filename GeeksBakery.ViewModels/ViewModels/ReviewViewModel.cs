using GeeksBakery.Utilities.SystemConstants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksBakery.ViewModels.ViewModels
{
    public class ReviewViewModel
    {
        private string _userAvatar;

        public string UserAvatar
        {
            get => string.IsNullOrEmpty(_userAvatar) ? SystemConstants.DEFAULT_AVATAR_URL : _userAvatar;
            set => _userAvatar = value;
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public int CakeId { get; set; }

        [Range(1, 5)]
        public int Star { get; set; }

        public string Comment { get; set; }
        public DateTime DateCreated;
    }
}