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
        [Required(ErrorMessage = "User Id is required.")]
        public Guid UserId { get; set; }

        [Required(ErrorMessage = "Cake Id is required.")]
        public int CakeId { get; set; }

        [Required(ErrorMessage = "Star is required.")]
        [Range(1, 5)]
        public int Star { get; set; }

        [Required(ErrorMessage = "Comment is required.")]
        [MinLength(10)]
        public string Comment { get; set; }
    }
}