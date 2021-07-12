using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace GeeksBakery.ViewModels.Requests.CakeImage
{
    public class CakeImageCreateRequest
    {
        [Required(ErrorMessage = "Cake Id is required.")]
        public int CakeId { get; set; }

        [Required(ErrorMessage = "Cake image is required.")]
        public IFormFile ImageFile { get; set; }

        public string Caption { get; set; }
        public bool IsDefault { get; set; }
        public int SortOrder { get; set; }
    }
}