using Microsoft.EntityFrameworkCore;
using TestInterviewAuto.Domain.Model.Car;
using TestInterviewAuto.Domain.Model.CarBrand;
using TestInterviewAuto.Domain.Model.Color;

namespace TestInterviewAuto.Infrastructure
{
    public class AutoDbContext : DbContext
    {
        public DbSet<Car> Cars;

        public DbSet<CarBrand> CarBrands;
        public DbSet<CarColor> CarColors;

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