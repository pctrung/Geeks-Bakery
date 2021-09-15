using GeeksBakery.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GeeksBakery.Data.Configurations
{
    public class CakeConfiguration : IEntityTypeConfiguration<Cake>
    {
        public void Configure(EntityTypeBuilder<Cake> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasMaxLength(60);
            builder.Property(x => x.Price).IsRequired().HasColumnType("decimal(10, 2)");
            builder.Property(x => x.OriginalPrice).IsRequired().HasColumnType("decimal(10, 2)");
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.DateDeleted).IsRequired(false);
            builder.Property(x => x.DateModified).IsRequired(false);

            builder.Property(x => x.Slug).IsRequired(false).HasMaxLength(50);

            builder.Property(x => x.Stock).HasDefaultValue(0);
        }
    }
}