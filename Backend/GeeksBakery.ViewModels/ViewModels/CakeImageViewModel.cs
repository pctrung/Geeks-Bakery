using GeeksBakery.Utilities.SystemConstants;

namespace GeeksBakery.ViewModels.Catalog.CakeImage
{
    public class CakeImageViewModel
    {
        private string _fileUrl;
        private string _caption;

        public string FileUrl
        {
            get => string.IsNullOrEmpty(_fileUrl) ? SystemConstants.DEFAULT_CAKE_IMAGE_URL : _fileUrl;
            set => _fileUrl = value;
        }

        public int Id { get; set; }
        public int CakeId { get; set; }

        public string Caption
        {
            get => string.IsNullOrEmpty(_caption) ? SystemConstants.DEFAULT_CAKE_IMAGE_URL : _caption;
            set => _caption = value;
        }

        public bool IsDefault { get; set; }
        public int SortOrder { get; set; }
    }
}