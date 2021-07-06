using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksBakery.ViewModels.Catalog.CakeImage
{
    public class CakeImageUpdateRequest
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string Caption { get; set; }
        public bool IsDefault { get; set; }
        public int SortOrder { get; set; }
        public long FileSize { get; set; }
    }
}
