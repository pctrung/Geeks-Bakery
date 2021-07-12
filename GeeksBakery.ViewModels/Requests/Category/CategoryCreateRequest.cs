using System.ComponentModel.DataAnnotations;

namespace GeeksBakery.ViewModels.Requests.Category
{
    public class CategoryCreateRequest
    {
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Category Parent ID")]
        public int? ParentId { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }
    }
}