using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestInterviewAuto.Domain.Model.CarBrand;

namespace TestInterviewAuto.Infrastructure.Configurations
{
    public class CarBrandTypeConfiguration : IEntityTypeConfiguration<CarBrand>
    {
        public void Configure(EntityTypeBuilder<CarBrand> builder)
        {
            builder.ToTable("CarBrands");
            builder.HasKey(x => x.Key);
            builder.Property(x => x.Key).HasColumnName("Id");
            builder.HasOne(x => x.Brand)
                .WithMany()
                .HasForeignKey(x=>x.BrandId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.Car)
                .WithMany(x => x.CarBrands)
                .HasForeignKey(x => x.CarId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
