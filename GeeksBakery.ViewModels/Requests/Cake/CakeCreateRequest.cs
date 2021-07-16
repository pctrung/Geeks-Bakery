using GeeksBakery.ViewModels.Requests.CakeImage;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GeeksBakery.ViewModels.Requests.Cake
{
    public class CakeCreateRequest
    {
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

        [DataType(DataType.Currency)]
        [Display(Name = "Original Price")]
        public decimal OriginalPrice { get; set; }

        [Display(Name = "Size")]
        public int Size { get; set; }

        [Display(Name = "SEO Name")]
        public string Slug { get; set; }

        [Display(Name = "Stock")]
        public int Stock { get; set; }

        [Display(Name = "Cake Price Description")]
        public string Description { get; set; }

        // not available now
        //public List<int> CakeImageIds { get; set; }
    }
}