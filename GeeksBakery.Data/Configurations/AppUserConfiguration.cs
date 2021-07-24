using GeeksBakery.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GeeksBakery.Data.Configurations
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasMaxLength(60);
            builder.Property(x => x.Address).IsRequired(false).HasMaxLength(100);

            builder.Property(p => p.Avatar).HasDefaultValue("default-avatar.png");
        }
    }
}