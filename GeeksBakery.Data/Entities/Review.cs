using System;
using System.ComponentModel.DataAnnotations;

namespace GeeksBakery.Data.Entities
{
    public class Review
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public AppUser User { get; set; }
        public int CakeId { get; set; }
        public Cake Cake { get; set; }

        [Range(1, 5)]
        public int Star { get; set; }

        public string Comment { get; set; }
        public DateTime? DateModified { get; set; }
        public DateTime? DateDeleted { get; set; }
        public DateTime DateCreated { get; set; }
    }
}