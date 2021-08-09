using Core.Entities.OrderAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class OrderDetailModificationHistoryConfiguration : IEntityTypeConfiguration<OrderDetailModificationHistory>
    {
        public void Configure(EntityTypeBuilder<OrderDetailModificationHistory> builder)
        {
            builder.HasOne(b => b.OrderDetail).WithMany().HasForeignKey(p => p.OrderDetailId);
            builder.HasOne(b => b.Menu).WithMany().HasForeignKey(p => p.MenuId);
            builder.Property(i => i.Price).HasColumnType("decimal(18,2)");
        }
    }
}