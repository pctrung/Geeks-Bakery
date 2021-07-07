using System.ComponentModel.DataAnnotations;

namespace GeeksBakery.ViewModels.Requests.Cake
{
    public class CakeUpdateRequest
    {
        [Required(ErrorMessage = "Cake Id is required.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Cake category is required.")]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Cake name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Cake price is required.")]
        public decimal Price { get; set; }

        public decimal OriginalPrice { get; set; }
        public int Size { get; set; }
        public string SEOAlias { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }
    }
}