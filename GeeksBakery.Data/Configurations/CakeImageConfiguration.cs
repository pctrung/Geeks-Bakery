using GeeksBakery.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GeeksBakery.Data.Configurations
{
    public class CakeImageConfiguration : IEntityTypeConfiguration<CakeImage>
    {
        public void Configure(EntityTypeBuilder<CakeImage> builder)
        {

        }
    }
}
