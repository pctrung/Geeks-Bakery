﻿using GeeksBakery.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GeeksBakery.Data.Configurations
{
    public class RateConfiguration : IEntityTypeConfiguration<Rate>
    {
        public void Configure(EntityTypeBuilder<Rate> builder)
        {
            builder.HasKey(c => new { c.UserId, c.CakeId });

            builder.Property(x => x.Comment).IsRequired();
            builder.Property(x => x.Star).IsRequired();
        }
    }
}