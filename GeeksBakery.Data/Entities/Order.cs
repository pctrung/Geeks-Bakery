﻿using GeeksBakery.Data.Enums;
using System;

namespace GeeksBakery.Data.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime DeliveryDate { get; set; }
        public Status Status { get; set; }
        public Guid UserId { get; set; }
        public AppUser User { get; set; }

#nullable enable
        public DateTime? DateModified { get; set; }
        public DateTime? DateDeleted { get; set; }
#nullable disable

        public DateTime DateCreated;
    }
}
