using System.ComponentModel.DataAnnotations;

namespace GeeksBakery.ViewModels.Requests.Category
{
    public class CategoryUpdateRequest
    {
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Category Parent ID")]
        public int? ParentId { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }
    }
}