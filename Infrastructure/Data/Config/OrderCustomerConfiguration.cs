using Core.Entities.OrderAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class OrderCustomerConfiguration : IEntityTypeConfiguration<OrderCustomer>
    {
        public void Configure(EntityTypeBuilder<OrderCustomer> builder)
        {
            builder.HasOne(b => b.Order).WithMany().HasForeignKey(p => p.OrderId);
            builder.HasOne(b => b.User).WithMany().HasForeignKey(p => p.UserId);
        }
    }
}