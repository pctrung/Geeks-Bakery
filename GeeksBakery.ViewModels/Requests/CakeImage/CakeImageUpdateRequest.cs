using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace GeeksBakery.ViewModels.Requests.CakeImage
{
    public class CakeImageUpdateRequest
    {
        [Required(ErrorMessage = "Cake image Id is required.")]
        public int Id { get; set; }

        public int CakeId { get; set; }
        public string FileName { get; set; }
        public string Caption { get; set; }
        public bool IsDefault { get; set; }
        public int SortOrder { get; set; }
        public long FileSize { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}