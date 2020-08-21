using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestInterviewAuto.Domain.Model.Car;

namespace TestInterviewAuto.Infrastructure.Configurations
{
    public class CarTypeConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.ToTable("Cars");
            builder.HasKey(x => x.Key);
            builder.Property(x => x.Key).HasColumnName("Id");
        }
    }
}