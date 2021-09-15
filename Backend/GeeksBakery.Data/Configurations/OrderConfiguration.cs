using GeeksBakery.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GeeksBakery.Data.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.DateDeleted).IsRequired(false);
            builder.Property(x => x.DateModified).IsRequired(false);
            builder.Property(x => x.DeliveryDate).IsRequired(false);
        }
    }
}