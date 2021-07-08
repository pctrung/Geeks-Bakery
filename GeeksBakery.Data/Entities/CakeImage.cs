using Newtonsoft.Json.Linq;
using System;

namespace GeeksBakery.Data.Entities
{
    public class CakeImage
    {
        public int Id { get; set; }
        public int CakeId { get; set; }
        public string FileName { get; set; }
        public string Caption { get; set; }
        public bool IsDefault { get; set; }
        public DateTime DateCreated { get; set; }
        public int SortOrder { get; set; }
        public long FileSize { get; set; }
        public Cake Cake { get; set; }
    }
}