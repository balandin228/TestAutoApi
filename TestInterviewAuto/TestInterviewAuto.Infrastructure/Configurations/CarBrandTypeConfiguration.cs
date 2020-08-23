using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestInterviewAuto.Domain.Model.CarBrand;

namespace TestInterviewAuto.Infrastructure.Configurations
{
    public class CarBrandTypeConfiguration : IEntityTypeConfiguration<CarBrand>
    {
        public void Configure(EntityTypeBuilder<CarBrand> builder)
        {
            builder.ToTable("CarBrand");
            builder.HasKey(x => x.Key);
            builder.Property(x => x.Key).HasColumnName("Id");
        }
    }
}