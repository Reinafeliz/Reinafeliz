using Core.Entities.OrderAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class OrderDetailOptionConfiguration : IEntityTypeConfiguration<OrderDetailOption>
    {
        public void Configure(EntityTypeBuilder<OrderDetailOption> builder)
        {
            builder.HasOne(b => b.OrderDetail).WithMany().HasForeignKey(p => p.OrderDetailId);
            builder.HasOne(b => b.MenuOption).WithMany().HasForeignKey(p => p.MenuOptionId);
            builder.Property(i => i.Price).HasColumnType("decimal(18,2)");
        }
    }
}