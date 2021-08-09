using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class BookingConfiguration : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder.HasOne(b => b.AppUser).WithMany().HasForeignKey(p => p.AppUserId);
            builder.HasOne(b => b.Restaurant).WithMany().HasForeignKey(p => p.RestaurantId);
            builder.HasOne(b => b.Amenity).WithMany().HasForeignKey(p => p.AmenityId);
            builder.Property(i => i.Price).HasColumnType("decimal(18,2)");
            builder.Property(i => i.Total).HasColumnType("decimal(18,2)");
        }
    }
}