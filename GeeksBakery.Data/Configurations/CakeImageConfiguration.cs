using GeeksBakery.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GeeksBakery.Data.Configurations
{
    public class CakeImageConfiguration : IEntityTypeConfiguration<CakeImage>
    {
        public void Configure(EntityTypeBuilder<CakeImage> builder)
        {
            builder.Property(x => x.CakeId).IsRequired();
            builder.Property(x => x.FileName).IsRequired();
            builder.Property(x => x.Caption).IsRequired(false);

            builder.Property(x => x.SortOrder).HasDefaultValue(1);
            builder.Property(x => x.FileSize).HasDefaultValue(0);
            builder.Property(x => x.IsDefault).HasDefaultValue(false);
        }
    }
}