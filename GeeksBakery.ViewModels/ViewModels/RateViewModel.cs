using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksBakery.ViewModels.ViewModels
{
    public class RateViewModel
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public string UserAvatar { get; set; }
        public int CakeId { get; set; }

        [Range(0, 5)]
        public int Star { get; set; }

        public string Comment { get; set; }
        public DateTime DateCreated;
    }
}