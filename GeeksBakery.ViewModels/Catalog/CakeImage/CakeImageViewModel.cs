using GeeksBakery.ViewModels.Catalog.Cakes.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksBakery.ViewModels.Catalog.CakeImage
{
    public class CakeImageViewModel
    {
        public int Id { get; set; }
        public int CakeId { get; set; }
        public string FileName { get; set; }
        public string Caption { get; set; }
        public bool IsDefault { get; set; }
        public int SortOrder { get; set; }
    }
}
