using Microsoft.EntityFrameworkCore;
using TestInterviewAuto.Domain.Model.Car;
using TestInterviewAuto.Domain.Model.Brand;
using TestInterviewAuto.Domain.Model.CarBrand;
using TestInterviewAuto.Domain.Model.CarColor;
using TestInterviewAuto.Domain.Model.Color;

namespace TestInterviewAuto.Infrastructure
{
    public class AutoDbContext : DbContext
    {
        public DbSet<Car> Cars;

        public DbSet<Brand> Brands;
        public DbSet<Color> Colors;
        public DbSet<CarColor> CarColors;
        public DbSet<CarBrand> CarBrands;
        public AutoDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AutoDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}