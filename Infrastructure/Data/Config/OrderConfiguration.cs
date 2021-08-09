using System;
using Core.Entities.OrderAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.OwnsOne(o => o.ShipToAddress, a =>
            {
                a.WithOwner();
            });
            builder.Property(s => s.OrderStatus)
                .HasConversion(
                    o => o.ToString(),
                    o => (OrderStatus)Enum.Parse(typeof(OrderStatus), o)
                );
            builder.Property(s => s.PaymentStatus)
               .HasConversion(
                   o => o.ToString(),
                   o => (PaymentStatus)Enum.Parse(typeof(PaymentStatus), o)
               );
            builder.Property(s => s.OrderMode)
               .HasConversion(
                   o => o.ToString(),
                   o => (OrderMode)Enum.Parse(typeof(OrderMode), o)
               );
            builder.Property(i => i.TotalAmount).HasColumnType("decimal(18,2)");
            builder.Property(i => i.Discount).HasColumnType("decimal(18,2)");
            builder.Property(i => i.GrandTotal).HasColumnType("decimal(18,2)");
            builder.Property(i => i.TaxAmount).HasColumnType("decimal(18,2)");
            builder.Property(i => i.NetAmount).HasColumnType("decimal(18,2)");
            builder.HasMany(o => o.OrderDetail).WithOne().OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(o => o.OrderCustomer).WithOne().OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(o => o.TaxDetail).WithOne().OnDelete(DeleteBehavior.Cascade);
        }
    }
}