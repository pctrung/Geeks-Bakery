using Microsoft.AspNetCore.Http;
using System;

namespace GeeksBakery.ViewModels.Catalog.CakeImage
{
    public class CakeImageCreateRequest
    {
        public int CakeId { get; set; }
        public string FileName { get; set; }
        public string Caption { get; set; }
        public bool IsDefault { get; set; }
        public DateTime DateCreated { get; set; }
        public int SortOrder { get; set; }
        public long FileSize { get; set; }
        IFormFile ImageFile { get; set; }
    }
}
