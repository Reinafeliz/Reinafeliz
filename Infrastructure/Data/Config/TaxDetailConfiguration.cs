using Core.Entities.OrderAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class TaxDetailConfiguration : IEntityTypeConfiguration<TaxDetail>
    {
        public void Configure(EntityTypeBuilder<TaxDetail> builder)
        {
            builder.HasOne(b => b.Order).WithMany().HasForeignKey(p => p.OrderId);
            builder.Property(i => i.TaxAmount).HasColumnType("decimal(18,2)");
        }
    }
}