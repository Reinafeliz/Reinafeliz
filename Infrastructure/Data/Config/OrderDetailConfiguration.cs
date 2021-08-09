using Core.Entities.OrderAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.HasOne(b => b.Order).WithMany().HasForeignKey(p => p.OrderId);
            builder.HasOne(b => b.Menu).WithMany().HasForeignKey(p => p.MenuId);
            builder.HasOne(b => b.AppUser).WithMany().HasForeignKey(p => p.AppUserId);
            builder.Property(i => i.Price).HasColumnType("decimal(18,2)");
            builder.Property(i => i.ItemDiscount).HasColumnType("decimal(18,2)");
            builder.Property(i => i.Total).HasColumnType("decimal(18,2)");
        }
    }
}