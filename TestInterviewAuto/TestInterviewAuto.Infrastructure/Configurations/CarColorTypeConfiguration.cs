using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestInterviewAuto.Domain.Model.Color;

namespace TestInterviewAuto.Infrastructure.Configurations
{
    public class CarColorTypeConfiguration : IEntityTypeConfiguration<CarColor>
    {
        public void Configure(EntityTypeBuilder<CarColor> builder)
        {
            builder.ToTable("CarColors");
            builder.HasKey(x => x.Key);
            builder.Property(x => x.Key).HasColumnName("Id");
        }
    }
}