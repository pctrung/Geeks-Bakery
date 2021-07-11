using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksBakery.ViewModels.Requests.Rate
{
    public class RateCreateRequest
    {
        public Guid UserId { get; set; }
        public int CakeId { get; set; }

        [Range(0, 5)]
        public int Star { get; set; }

        public string Comment { get; set; }
    }
}