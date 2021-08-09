using Core.Entities.MasterAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class StateCityConfiguration : IEntityTypeConfiguration<StateCity>
    {
        public void Configure(EntityTypeBuilder<StateCity> builder)
        {
            builder.HasOne(p=>p.Country).WithMany().HasForeignKey(p=>p.CountryId);
        }
    }
}