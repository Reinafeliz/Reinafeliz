using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class AmenityConfiguration : IEntityTypeConfiguration<Amenity>
    {
        public void Configure(EntityTypeBuilder<Amenity> builder)
        {
            builder.HasOne(b => b.Restaurant).WithMany().HasForeignKey(p => p.RestaurantId);
            builder.Property(i => i.Charge).HasColumnType("decimal(18,2)");
        }
    }
}