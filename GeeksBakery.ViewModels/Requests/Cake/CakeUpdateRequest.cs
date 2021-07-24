using GeeksBakery.ViewModels.Requests.CakeImage;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GeeksBakery.ViewModels.Requests.Cake
{
    public class CakeUpdateRequest
    {
        [Required(ErrorMessage = "Cake Id is required.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Cake category is required.")]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Cake name is required.")]
        [Display(Name = "Cake Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Cake price is required.")]
        [Display(Name = "Price")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Display(Name = "Original Price")]
        [DataType(DataType.Currency)]
        public decimal OriginalPrice { get; set; }

        [Display(Name = "Size")]
        public int Size { get; set; }

        [Display(Name = "SEO Name")]
        public string Slug { get; set; }

        [Display(Name = "Stock")]
        public int Stock { get; set; }

        [Display(Name = "Cake Price Description")]
        public string Description { get; set; }
    }
}