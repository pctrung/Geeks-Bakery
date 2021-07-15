namespace GeeksBakery.ViewModels.Catalog.CakeImage
{
    public class CakeImageViewModel
    {
        public int Id { get; set; }
        public int CakeId { get; set; }
        public string FileUrl { get; set; }
        public string Caption { get; set; }
        public bool IsDefault { get; set; }
        public int SortOrder { get; set; }
    }
}