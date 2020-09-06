using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestInterviewAuto.Domain.Model.Car;
using TestInterviewAuto.Domain.Model.CarColor;

namespace TestInterviewAuto.Infrastructure.Configurations
{
    public class CarColorTypeConfiguration : IEntityTypeConfiguration<CarColor>
    {
        public void Configure(EntityTypeBuilder<CarColor> builder)
        {
            builder.ToTable("CarColors");
            builder.HasKey(x => x.Key);
            builder.Property(x => x.Key).HasColumnName("Id");
            builder.HasOne(x => x.Car)
                .WithOne(x=>x.CarColor)
                .HasForeignKey<CarColor>(x=>x.CarId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.Color)
                .WithMany()
                .HasForeignKey(x => x.ColorId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
