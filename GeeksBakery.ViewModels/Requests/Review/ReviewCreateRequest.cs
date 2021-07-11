using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksBakery.ViewModels.Requests.Review
{
    public class ReviewCreateRequest
    {
        public Guid UserId { get; set; }
        public int CakeId { get; set; }

        [Range(1, 5)]
        public int Star { get; set; }

        public string Comment { get; set; }
    }
}