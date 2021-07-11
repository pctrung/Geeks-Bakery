using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksBakery.Data.Entities
{
    public class Rate
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public AppUser User { get; set; }
        public int CakeId { get; set; }
        public Cake Cake { get; set; }

        [Range(0, 5)]
        public int Star { get; set; }

        public string Comment { get; set; }
        public DateTime? DateModified { get; set; }
        public DateTime? DateDeleted { get; set; }
        public DateTime DateCreated;
    }
}